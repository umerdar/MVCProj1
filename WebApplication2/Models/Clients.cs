using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Clients
    {
        [Required(ErrorMessage = "Please Enter Name", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Phone", AllowEmptyStrings = false)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Email", AllowEmptyStrings = false)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Street", AllowEmptyStrings = false)]
        public string Street { get; set; }
        [Required(ErrorMessage = "Please Enter City", AllowEmptyStrings = false)]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter State", AllowEmptyStrings = false)]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter Zip", AllowEmptyStrings = false)]
        public string ZipCode { get; set; }
    }
}