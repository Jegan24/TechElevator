using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class FilmSearchModel
    {
        [Display(Name = "Minimum Length")]
        public int MinimumLength { get; set; }

        [Display(Name = "Maximum Length")]
        public int MaximumLength { get; set; }
        [Display(Name = "Genre")]
        public string Genre { get; set; }
        public IEnumerable<Film> Films { get; set; }
        private List<string> _genres;
        public FilmSearchModel(IEnumerable<string> genres)
        {
            _genres = new List<string>(genres);
        }

        public List<SelectListItem> Genres
        {
            get
            {
                List<SelectListItem> mySelectList = new List<SelectListItem>();
                foreach (string s in _genres)
                {
                    SelectListItem item = new SelectListItem() { Text = s, Value = s };
                    mySelectList.Add(item);
                }
                return mySelectList;
            }
        }
    }
}
