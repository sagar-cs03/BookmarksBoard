using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Pinboard.Models;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Text.RegularExpressions;
using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;

namespace Pinboard.Controllers
{
    
    public class SettingsController : Controller
    {

        private readonly PinboardContext _Context;

        public SettingsController(PinboardContext context)
        {
            _Context = context;
        }

        [SessionCheck]
        public IActionResult Account()
        {

            ViewData["flashMessage"] = HttpContext.Session.GetString("flashMessage");
            HttpContext.Session.Remove("flashMessage");
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        [SessionCheck]
        public async Task<IActionResult> Account(string Password, string OldPassword, string ConfirmPassword)
        {
            if(ModelState.IsValid)
            {
                String emailID = HttpContext.Session.GetString("emailID");

                User _user = _Context.Users.SingleOrDefault(o => (o.EmailID == emailID));
                if(_user.Password == OldPassword && ConfirmPassword == Password) 
                {
                    _user.Password = Password;
                    try
                    {
                         _Context.Update(_user);
                        await _Context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!UserExists(_user.EmailID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    HttpContext.Session.SetString("flashMessage", "Password successfully updated");
                    return RedirectToAction("Account", "Settings");
                } else
                {
                    HttpContext.Session.SetString("flashMessage", "Password mismatch or wrong old password");
                    return RedirectToAction("Account", "Settings");
                }
            }
         
            return View();
        }

        [SessionCheck]
        public IActionResult Import()
        {
            ViewData["flashMessage"] = HttpContext.Session.GetString("flashMessage");
            HttpContext.Session.Remove("flashMessage");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [SessionCheck]
        public async Task<IActionResult> Import(IFormFile bookmarksFile)
        {
            string emailID = HttpContext.Session.GetString("emailID");
            if (bookmarksFile == null || bookmarksFile.Length == 0 || bookmarksFile.ContentType != "text/html")
                return Content("file not selected or upload a proper file");

            var uniqueFileName = string.Format(@"{0}.html", Guid.NewGuid());

            var path = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot", "bookmark_uploads", emailID,
                   uniqueFileName
                 );

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await bookmarksFile.CopyToAsync(stream);
            }

            return await ProcessFile(path);       
        }

        public async Task<IActionResult>  ProcessFile(string path)
        {
            //use below for debugging
            //System.Diagnostics.Debug.WriteLine()

            string htmlString = System.IO.File.ReadAllText(path);
            var client = new RestClient("http://localhost:5000");
            var request = new RestRequest("get_links", Method.POST);
            request.AddParameter("html_string", htmlString);
            IRestResponse response = client.Execute(request);
            var content = response.Content;
            
            if(content != "")
            {
                var jsonObject = JToken.Parse(content);
                var resultsArray = jsonObject.Children<JProperty>().FirstOrDefault(x => x.Name == "results").Value;
                foreach(var item in resultsArray.Children())
                {
                    var itemProperties = item.Children<JProperty>();
                    var url = itemProperties.FirstOrDefault(x => x.Name == "url").Value;
                    var title = itemProperties.FirstOrDefault(x => x.Name == "title");
                    Bookmark bookmark = new Bookmark();
                    bookmark.URL = (String)url;
                    bookmark.Title = (String)title;
                    _Context.Add(bookmark);
                    await _Context.SaveChangesAsync();
                }
                HttpContext.Session.SetString("flashMessage", "Bookmarks successfully imported");
                return RedirectToAction("Import", "Settings");
            } else
            {
                HttpContext.Session.SetString("flashMessage", "Bookmarks couldn't be imported");
                return RedirectToAction("Import", "Settings");
            }
        }


        [SessionCheck]
        public  IActionResult Backup()
        {
            return View();
        }


        public async Task<IActionResult> DownloadBackUpFileInJson()
        {

            var contentType = "text/json";

            var bookmarks = _Context.Bookmarks.ToList();
            string bookmarkBackUpJson = JsonConvert.SerializeObject(bookmarks);

            var bytes = Encoding.UTF8.GetBytes(bookmarkBackUpJson);

            var result = new FileContentResult(bytes, contentType);
            result.FileDownloadName = "BackUpFromPinboard.json";

            return result;
        }

        [SessionCheck]
        public IActionResult Services()
        {
            return View();
        }


        [SessionCheck]
        private bool UserExists(string emailId)
        {
            return _Context.Users.Any(e => e.EmailID == emailId);
        }
    }
}