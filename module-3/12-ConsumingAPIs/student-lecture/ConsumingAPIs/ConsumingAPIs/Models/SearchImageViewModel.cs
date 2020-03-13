using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumingAPIs.Models
{
    public class SearchImageViewModel
    {
        public int SelectedValue { get; set; } = 2;

       public SelectList ImageCategories= new SelectList(
        new List<SelectListItem>
        {
           new SelectListItem { Selected = false,  Text = "boxes", Value = "5"},
           new SelectListItem { Selected = false,  Text = "clothes", Value = "15"},
           new SelectListItem { Selected = false,  Text = "hats", Value = "1"},
           new SelectListItem { Selected = false,  Text = "sinks", Value = "14"},
           new SelectListItem { Selected = false,  Text = "space", Value = "2"},
           new SelectListItem { Selected = false,  Text = "sunglasses", Value = "4"},
           new SelectListItem { Selected = false,  Text = "ties", Value = "7"},
        }, "Value" , "Text", 1);
    }
}
