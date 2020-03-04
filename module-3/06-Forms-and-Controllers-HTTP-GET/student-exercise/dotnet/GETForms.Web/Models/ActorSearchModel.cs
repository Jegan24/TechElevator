using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class ActorSearchModel
    {
        [Display(Name  = "Enter last name")]
        public string LastName { get; set; }

        public IEnumerable<Actor>Actors { get; set; }
    }
}
