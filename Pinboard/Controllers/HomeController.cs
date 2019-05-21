using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Pinboard.Models;

namespace Pinboard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            String isUserLoggedIn = HttpContext.Session.GetString("isUserLoggedIn");
            if (isUserLoggedIn != "True")
            {
                return View();
            } else
            {
                ViewData["isUserLoggedIn"] = "True";
                return View();
            }
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
