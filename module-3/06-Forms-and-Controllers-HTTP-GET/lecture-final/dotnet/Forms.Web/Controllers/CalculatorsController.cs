using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Web.Controllers
{
    public class CalculatorsController : Controller
    {

        //step 1 - create the calc controller. index was automagic
        public IActionResult Index()
        {
            return View();
        }

        //step 4 - create the method to get the results
        public IActionResult Result(CalculatorModel cm)
        {
            //step 6 return the view
            return View(cm);
        }
    }
}