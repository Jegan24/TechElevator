using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Forms.Web.Models
{
    public class RandomDataValidatorModel
    {
        [Required, StringLength(10,MinimumLength =5,ErrorMessage ="required string between 5 and 10")]
        public string RequiredStringOfLengthBetween5And10 { get; set; }

        [Range(5, 10, ErrorMessage = "must be between 5 and 10")]
        public int InRange5To10 { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

     
        [Required, DataType(DataType.Password),Compare("Password", ErrorMessage = "Password does not match")]      
        public string PasswordMatcher { get; set; }

        [Required]
        public DateTime date;
    }
}
