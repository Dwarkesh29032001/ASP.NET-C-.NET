using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    internal class DubaiSales : Sales
    {


        public double SalesNetProfit(double cogs , double expense , double actualSales , int gstPercentage , double shippingCharges  )
        {
            double gstAmount = actualSales * gstPercentage / 100;
            return actualSales - (cogs + expense + gstAmount + shippingCharges);
        }
        public override int GetTaxPercentage(string field)
        {
            return 0;
        }
    }
}
