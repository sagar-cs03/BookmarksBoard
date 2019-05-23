using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pinboard.Controllers
{
    public class TweetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}