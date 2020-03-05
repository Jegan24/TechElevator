using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Forms.Web.Models;
using Forms.Web.DAL;

namespace Forms.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICityDAO cityDao;

        public HomeController(ICityDAO cityDao)
        {
            this.cityDao = cityDao;
        }

        //let's just play around with our random data validator model
        [HttpGet]
        public IActionResult RandomDataForm()
        {
            return View();

        }

        [HttpPost]
        public IActionResult RandomDataForm(RandomDataValidatorModel myData)
        {
            if (ModelState.IsValid)
            {
                return View("ConfirmationView");
            }
            else
            {
                return View(myData);
            }
        }



        /// <summary>
        /// Represents an index action.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Represents a search action.
        /// </summary>
        /// <returns></returns>
        public IActionResult Search()
        {
            // Display a search page
            return View();
        }
        
        /// <summary>
        /// Represents a search result.
        /// </summary>
        /// <param name="searchModel"></param>
        /// <returns></returns>
        public IActionResult Results(CitySearchModel searchModel)
        {
            // Use the search model to get our data
            // Connection Strings are outside of the scope of this content            
            var cities = cityDao.GetCities(searchModel.CountryCode, searchModel.District);

            // Update the search model with the cities returned
            searchModel.Results = cities;

            // Display search results
            return View(searchModel);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
