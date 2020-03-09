using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;

namespace Validation.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("LoginSuccess");
            }
            else
            {
                return View("Index", model);
            }
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View("Registration");
        }

        public IActionResult RegistrationSuccessful()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationViewModel model)
        {
            if(model.Email != model.ConfirmationEmail)
            {
                ModelState.AddModelError("ConfirmationEmail", "Email addresses do not match");
            }
            if(model.Password != model.ConfirmationPassword)
            {
                ModelState.AddModelError("ConfirmationPassword", "Passwords do not match");
            }
            if(model.Birthday.AddYears(13) > DateTime.Now)
            {
                ModelState.AddModelError("Birthday", "You must be at least 13 years old to register");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("RegistrationSuccessful");
            }
            else
            {
                return View("Registration", model);
            }            
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
