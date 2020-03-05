using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Display(Name = "Enter your name:"), Required(ErrorMessage ="This field is required")]
        public string Username { get; set; }
        [Display(Name = "How many stars:"), Required(ErrorMessage = "This field is required")]
        public int Rating { get; set; }
        [Display(Name = "Provide a title"), Required(ErrorMessage = "This field is required")]
        public string Title { get; set; }
        [Display(Name = "Review"), Required(ErrorMessage = "This field is required")]
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
