using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Web.Models
{
    public class CitySearchModel
    {
        [Display(Name ="Enter a country code")]
        public string CountryCode { get; set; }

        [Display(Name ="Enter a district")]
        public string District { get; set; }

        public IList<City> Results { get; set; }
    }
}
