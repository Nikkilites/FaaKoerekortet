using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FåKoerekortet.Models;
using Microsoft.AspNetCore.Mvc;

namespace FåKoerekortet.Controllers
{
    public class PricesController : Controller
    {
        public IActionResult Index()
        {
            DatabaseController databaseController = new DatabaseController();
            Schoolrepository schools = new Schoolrepository(databaseController.GetSchools());

            return View(schools);
        }

        public IActionResult School()
        {
            return View();
        }
    }
}