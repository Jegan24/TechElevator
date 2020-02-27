using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechElevator.Web.DAL;

namespace TechElevator.Web.Controllers
{
    public class FilmController : Controller
    {
       
        public IActionResult Index()
        {
            IStarWarsDAO dao = new MockStarWarsDAO();
            var films = dao.GetFilms();
            return View("Index", films);
        }

        public IActionResult Detail(string id)
        {
            //get the film with the corresponding id and show the details
            IStarWarsDAO dao = new MockStarWarsDAO();
            var film = dao.GetFilm(id);
            return View("Detail",film);
        }
    }
}