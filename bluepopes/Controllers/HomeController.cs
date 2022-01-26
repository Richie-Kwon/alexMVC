using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bluepopes.Models;

namespace bluepopes.Controllers
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
        public IActionResult Test(List<int> x, string y)
        {
            return View();
        }
        public IActionResult Test2(string x, string y)
        {
            ViewData["x"] = x;
            ViewBag.y = y;
            return PartialView();
        }
        
        public IActionResult Test3(List<int> x, string y)
        {
            var model = new TestModel();
            model.X = 1;
            model.Y = "Yera lee";
            
            return Json(model);
        }
        
        public IActionResult Test4(string x, string y)
        {
            ViewData["x"] = x;
            ViewBag.y = y;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}