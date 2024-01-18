using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMvcApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
    }
}