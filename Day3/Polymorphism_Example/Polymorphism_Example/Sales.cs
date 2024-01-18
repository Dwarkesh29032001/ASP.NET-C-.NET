using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{


    // SalesNetProfit = Incoming Money + Outgoing Money 
    // Outgoing Money - COGS , Expense , GST 
    // Income Class Sales 


    internal class Sales
    {
        public virtual int GetTaxPercentage(String field)
        {
            if (field == "IT")
            {
                return 18;
            }
            else
            {
                return 12;
            }
        }

        public double SalesNetProfit(double cogs, double expense, double actualSales) 
        {
        return actualSales - (cogs + expense);
        }

        public double SalesNetProfit(double cogs, double expense, double actualSales , int gstPercentage)
        {
            double gstAmount = actualSales*gstPercentage/100;

            return actualSales - (cogs + expense + gstAmount);
        }
    }
}
