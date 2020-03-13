using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsumingAPIs.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;

namespace ConsumingAPIs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult> Index()
        {
            Fact[] arrayOfFacts = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://cat-fact.herokuapp.com");
                //HTTP GET
                var responseTask = client.GetAsync("facts");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();
                    arrayOfFacts = JsonConvert.DeserializeObject<Rootobject>(content).all;

                }
            }

            return View(arrayOfFacts);
        }

        [HttpGet]
        public async Task<ActionResult> CatPictures(SearchImageViewModel sivm)
        {            
            string url = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.thecatapi.com/v1/images/");
               
                //HTTP GET
                var responseTask = client.GetAsync("search?category_ids="+sivm.SelectedValue);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    string content = await result.Content.ReadAsStringAsync();
                    var array = JsonConvert.DeserializeObject<IEnumerable<PicInfo>>(content);
                    url = array.First().url;
                }
            }
            ViewData["image"] = url;
           
            return View(sivm);
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
