using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmDAO dao;

        public FilmsController(IFilmDAO d)
        {
            dao = d;
        }
        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return SearchResult(0, 0, "");
        }

        /// <summary>
        /// Receives the search result request and goes to th database looking for the information.
        /// </summary>
        /// <param name="request">A request model that contains the search parameters.</param>
        /// <returns></returns>
        public ActionResult SearchResult(int minimumLength, int maximumLength, string genre)
        {
            /* Call the DAL and pass the values as a model back to the View */
            FilmSearchModel fsm = new FilmSearchModel(dao.GetGenres());
            fsm.Films = dao.GetFilmsBetween(genre, minimumLength, maximumLength);
            return View("Index", fsm);
        }
    }
}