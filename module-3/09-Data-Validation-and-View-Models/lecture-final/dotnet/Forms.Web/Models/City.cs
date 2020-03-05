using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forms.Web.Models
{
    public class City
    {
        public int CityId { get;  set; }

        [Required, StringLength(10,ErrorMessage ="Name can be a max of 10")]
        public string Name { get;  set; }

        [Required]
        public string CountryCode { get;  set; }

        [Required]
        public string District { get;  set; }
        
        [Required]
        public int Population { get;  set; }
    }
}
