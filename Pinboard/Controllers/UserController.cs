using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pinboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pinboard.Controllers
{
    public class UserController : Controller
    {

        private readonly PinboardContext _Context;

        public UserController(PinboardContext context)
        {
            _Context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [SessionCheck(AllowIfLoggedIn = false)]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string EmailID, string Password)
        {
            User _user = _Context.Users.SingleOrDefault(o => (o.EmailID == EmailID && o.Password == Password));
            if (_user != null)
            {
                HttpContext.Session.SetString("isUserLoggedIn", "True");
                HttpContext.Session.SetString("emailID", EmailID);
                HttpContext.Session.SetString("userHandle", _user.UserHandle);
                return RedirectToAction("Index", "Dashboard");
            }
            return View();

        }

        [SessionCheck(AllowIfLoggedIn = false)]
        public IActionResult Register()
        {
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("EmailID, UserHandle, Password")] User user, string ConfirmPassword)
        {
            if (ModelState.IsValid)
            {
                if(!(user.Password == ConfirmPassword))
                {
                    ViewData["ErrorMessage"] = "Passwords don't match";
                    return View();
                }

                if(!_Context.Users.Any(o => o.EmailID == user.EmailID))
                {
                    _Context.Add(user);
                    await _Context.SaveChangesAsync();
                    
                    string path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot", "bookmark_uploads", user.EmailID);
                 

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    return RedirectToAction(nameof(Login));
                } else
                {
                    ViewData["ErrorMessage"] = "User already exists with the given emailId";
                    return View();
                }
            }
            return View();
        }

        [SessionCheck(AllowIfLoggedIn = false)]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [SessionCheck]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
