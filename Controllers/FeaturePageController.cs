using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class FeaturePageController : Controller
    {
        public IActionResult Feature()
        {
            return View();
        }
    }
}