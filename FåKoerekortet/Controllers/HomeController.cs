using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FåKoerekortet.Models;

namespace FåKoerekortet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            throw new Exception("Privacy Page could not be shown");
            //return View();
        }

        [Route("blog/{year:int}/{month:int}/{key}")]
        public IActionResult PrintData(int year, int month, string key)
        {
            return new ContentResult
            {
                Content = string.Format("Year: {0}; Month: {1}; Key: {2}",
                                      year, month, key)
            };
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
