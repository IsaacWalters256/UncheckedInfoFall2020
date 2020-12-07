using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UncheckedInformationSite.Models;

namespace UncheckedInformationSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;//remove later on

        public HomeController(ILogger<HomeController> logger) //test
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Games()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Adventure()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adventure(AdventureVM adventure)
        {
            adventure.RunGame();
            return View(adventure);
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
