using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage ="*")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "*")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "*"),EmailAddress(ErrorMessage ="invalid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "*")]
        public string ConfirmationEmail { get; set; }
        [Required(ErrorMessage = "*"), RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",ErrorMessage = "Password minimum is 8 characters and must contain a number, lower and uppercase letter")]
        public string Password { get; set; }
        [Required(ErrorMessage = "*")]
        public string ConfirmationPassword { get; set; }
        [Required(ErrorMessage = "*"), DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "*")]
        public int NumberOfTickets { get; set; }
    }
}