using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Synechron.EventsPortal.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Employee Name is a required field!")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Employee Address is a required field!")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Employee City is a required field!")]
        public string City { get; set; }
        public string Country { get; set; }
        [Required(ErrorMessage = "Employee Contact # is a required field!")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Employee Email is a required field!")]
        public string Email { get; set; }
        public string Skillsets { get; set; }
        public string Avatar { get; set; }
        public string Zipcode { get; set; }
    }
}