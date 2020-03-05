using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Post.Web.DAL;
using Post.Web.Models;

namespace Post.Web.Controllers
{
    public class HomeController : Controller
    {
        private IReviewDAO dao;
        public HomeController(IReviewDAO dAO)
        {
            dao = dAO;
        }
        // GET: Home
        public ActionResult Index()
        {

            return View(dao.GetAllReviews());
        }       
        public ActionResult NewReview()
        {

            return View("NewReview");
        }

        [HttpPost]
        public ActionResult AddReview(Review review)
        {
            if (!ModelState.IsValid)
            {
                TempData["msg"] = "TASK FAILED SUCCESSFULLY";                
                return View("NewReview",review);
            }
            else
            {
                TempData["msg"] = "TASK FAILED UNSUCCESSFULLY";
            }
            dao.SaveReview(review);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
