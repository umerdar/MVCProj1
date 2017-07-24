using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Attendees
    {
        [Required(ErrorMessage = "Select Client", AllowEmptyStrings = false)]
        public string ClientId { get; set; }
        [Required(ErrorMessage = "Please Enter First Name", AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Last Name", AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please Enter Email", AllowEmptyStrings = false)]
        public string Email { get; set; }
    }
}