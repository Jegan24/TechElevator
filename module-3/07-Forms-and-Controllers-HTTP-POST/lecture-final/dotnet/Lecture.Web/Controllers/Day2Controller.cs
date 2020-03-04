using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture.Web.DAL;
using Lecture.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lecture.Web.Controllers
{
    public class Day2Controller : Controller
    {
        private ICityDAO cityDAO;

        public Day2Controller(ICityDAO icd)
        {
            cityDAO = icd;
        }

        //1. Create an action so the user can go to an add city page
        [HttpGet]
        public IActionResult AddCity()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCity(City city)
        {
            cityDAO.AddCity(city);
            // return RedirectToAction("Confirmation");

            //let's search for the city within it's country and district
            return RedirectToAction("SearchResult", "Day1", new { CountryCode = city.CountryCode, District = city.District });
        }

        [HttpGet]
        public IActionResult Confirmation()
        {
            return View();
        }

        //1. create a page/form to create a countyr country
        [HttpGet]
        public IActionResult CreateCountry()
        {
            return View();
        }

        //4. create a method to hanlde the post
        [HttpPost]
        public IActionResult CreateCountry(Country c)
        {
            //6. have it really create a country
            //Not DEPENDENCY INJECTION
            try
            {
                ICountryDAO countryDAO = new CountrySqlDAO(@"Data Source=.\sqlexpress;Initial Catalog=world;Integrated Security=true;");
                countryDAO.AddCountry(c);
            }
            catch (Exception e)
            {
                //SINCE our sql is broke as a joke we should return oops
                return RedirectToAction("oops");
            }

            //5. path of least resistance is to send them to the dora page
            return RedirectToAction("Confirmation");
        }

        public IActionResult oops()
        {
            return View();
        }
    }
}