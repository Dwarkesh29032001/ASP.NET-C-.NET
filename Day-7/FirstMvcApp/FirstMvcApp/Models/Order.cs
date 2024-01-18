using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstMvcApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public int CustomerId { get; set; }
    }
}