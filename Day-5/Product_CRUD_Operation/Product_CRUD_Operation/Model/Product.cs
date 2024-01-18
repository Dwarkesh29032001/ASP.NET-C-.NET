using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_CRUD_Operation.Model
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }

        public decimal productPrice { get; set; }

        public  string productCompany { get; set; }

        public decimal productRating { get; set; }
    }
}
