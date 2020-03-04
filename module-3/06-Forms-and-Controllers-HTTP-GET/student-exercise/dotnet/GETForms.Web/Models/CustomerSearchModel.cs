using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearchModel
    {
        [Display(Name = "Name:")]
        public string Search { get; set; }

        [Display(Name ="Sort By:")]
        public string SortBy { get; set; }

        public IEnumerable<Customer> Customers { get; set; }

        public static List<SelectListItem> SortOptions = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "First Name", Value = "first_name" },
            new SelectListItem() { Text = "Last Name", Value = "last_name" },
            new SelectListItem() { Text = "Email", Value = "email" },
            new SelectListItem() { Text = "Active", Value = "active" }
        };
    }
}
