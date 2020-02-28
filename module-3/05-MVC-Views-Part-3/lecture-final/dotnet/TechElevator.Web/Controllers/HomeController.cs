using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.Models;

namespace TechElevator.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {           
           
            return View();
        }

        public IActionResult SnackDetail(string name, int numCalories)
        {
            ViewData["g"] = "happy friday";
            ViewData["1"] = "happy saturday";
            Cookie chocolateCHip = new Cookie(name, numCalories);
            return View(chocolateCHip);
        }
    }
}