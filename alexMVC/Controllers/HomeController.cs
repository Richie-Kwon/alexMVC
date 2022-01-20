using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using alexMVC.Models;
using Microsoft.AspNetCore.Hosting;

namespace alexMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly PubsDbContext _pubsDbContext;

        public HomeController(ILogger<HomeController> logger,
            IWebHostEnvironment webHostEnvironment,
            PubsDbContext PubsDb)
        {
            _logger = logger;  
            // _webHostEnvironment = webHostEnvironment;
            _pubsDbContext = pubsDb;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult AuthorList()
        {
            // string path = Path.Combine(_webHostEnvironment.ContentRootPath, "authors.txt");
            // string jsonStr =System.IO.File.ReadAllText(path);
            // // List<Author> authors = new List<Author>();
            // List<Author> authors = JsonSerializer.Deserialize<List<Author>>(jsonStr);
            // return View(authors);  
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}