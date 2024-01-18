using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Sales sales = new Sales();
           // Sales sales1 = new DubaiSales(); 


           /* Console.WriteLine($"India Sales Net Profit without GST in INR {sales1.SalesNetProfit(12000 , 13000 , 150000)} ");
            Console.WriteLine($"India Sales Net Profit with 18% GST in INR {sales1.SalesNetProfit(12000,13000,150000,sales1.GetTaxPercentage("IT"))} ");
            Console.WriteLine($"India Sales Net Profit with 18% GST in INR {sales1.SalesNetProfit(12000,13000,150000,sales1.GetTaxPercentage("FOOD"))} ");*/

           // Console.WriteLine($"Dubai Sales Net Profit with 18% GST in INR {sales.SalesNetProfit(12000,13000,150000,sales.GetTaxPercentage("FOOD"))} ");
           // Console.WriteLine($" ");

            BasicMath basicMath = new BasicMath();
            AdvanceMath advanceMath = new AdvanceMath();    
            BasicMath basicMath1 = new AdvanceMath();

            Console.WriteLine(basicMath.Addition(100,500));
            Console.WriteLine(basicMath1.Addition(100,500));
            Console.WriteLine(advanceMath.Addition(100,500));
            // Console.WriteLine(basicMath.Addition(100,500));
            advanceMath.Notice();
            basicMath.Notice();


            Console.ReadKey();  

        }
    }
}
