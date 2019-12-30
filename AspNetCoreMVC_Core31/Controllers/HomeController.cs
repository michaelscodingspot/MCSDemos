using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreMVC_Core31.Models;

namespace AspNetCoreMVC_Core31.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         
        public IActionResult CauseInvalid()
        {
            Foo();
            return Error();
        }

        private void Foo()
        {
            int x = 4;
            int y = 6;
            Bar(x, y);
        }

        private void Bar(int x, int y)
        {
            int z = x + y;
            throw new InvalidOperationException("Something really bad happened to cause this. z = " + z);
        }
    }
}
