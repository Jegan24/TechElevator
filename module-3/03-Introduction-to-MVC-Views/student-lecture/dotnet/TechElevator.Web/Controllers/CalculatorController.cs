using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechElevator.Web.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult ConversionTable()
        {
            return View();
        }
    }
}
