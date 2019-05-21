using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Pinboard.Models;
using Pinboard.Controllers;

namespace Pinboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly PinboardContext _Context;

        public DashboardController(PinboardContext context)
        {
            _Context = context;
        }

        [SessionCheck]
        public IActionResult Index()
        {
            return
                RedirectToAction("Index", "Bookmarks");
        }
    }
}