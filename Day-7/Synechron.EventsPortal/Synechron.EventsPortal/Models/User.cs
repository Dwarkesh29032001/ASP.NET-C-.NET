using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Synechron.EventsPortal.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="Email Id is a required field!")]
        [EmailAddress(ErrorMessage ="Please provide correct email Id!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is a required field!")]
        [MinLength(4,ErrorMessage ="Password must be minimum of 4 characters!")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}