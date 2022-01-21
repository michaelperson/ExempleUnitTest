using HelloTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelloTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMySession _mySession;

        public HomeController(ILogger<HomeController> logger, IMySession mySession)
        {
            _logger = logger;
            _mySession = mySession;
        }
        
        public IActionResult Index()
        {
            if (_mySession.IsLogged == true)
                return View();
            else
                return RedirectToAction("Login","Account");
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
