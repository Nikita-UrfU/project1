using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;

namespace Project.Controllers
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
            return View();
        }

        [HttpGet]
        public IActionResult Cylindrical()
        {
            CylindricalDataModel data = new CylindricalDataModel();

            data.SetDefaultData();

            return View(data);

        }

        [HttpPost]
        public IActionResult Cylindrical(CylindricalDataModel data)
        {
            data.Graph();
            return View("Result", data);
        }
        [HttpPost]
        
        public IActionResult Grafic(CylindricalDataModel Graph)
        {

            return View("Result", Graph);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
