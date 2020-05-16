using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Final_Project.Controllers
{
    public class GuidePageController : Controller
    {
        private readonly ILogger<GuidePageController> _logger;

        public GuidePageController(ILogger<GuidePageController> logger)
        {
            _logger = logger;
        }

        public IActionResult Guide()
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