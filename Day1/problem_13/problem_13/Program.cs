using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace problem_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Date in formate DD/MM/YY");
            Console.WriteLine("Enter the Date :");
            int DD = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month :");
            int MM = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year :");
            int YY = int.Parse(Console.ReadLine());


            Console.WriteLine($" The Entered Date is : {DD}/{MM}/{YY}");

            switch (MM) { 
            
                case 1:
                    Console.WriteLine("The Month is January");
                    Console.WriteLine("31 Days in Month of January");
                    break;
                case 2:
                    Console.WriteLine("The Month is February");
                    Console.WriteLine("28 Days in Month of February");
                    break;
                case 3:
                    Console.WriteLine("The Month is March");
                    Console.WriteLine("31 Days in Month of March");
                    break;
                case 4:
                    Console.WriteLine("The Month is April");
                    Console.WriteLine("30 Days in Month of April");
                    break;
                case 5:
                    Console.WriteLine("The Month is May");
                    Console.WriteLine("31 Days in Month of May");
                    break;
                case 6:
                    Console.WriteLine("The Month is June");
                    Console.WriteLine("30 Days in Month of June");
                    break;
                case 7:
                    Console.WriteLine("The Month is July");
                    Console.WriteLine("31 Days in Month of July");
                    break;
                case 8:
                    Console.WriteLine("The Month is August");
                    Console.WriteLine("31 Days in Month of August");
                    break;
                case 9:
                    Console.WriteLine("The Month is September");
                    Console.WriteLine("30 Days in Month of September");
                    break;
                case 10:
                    Console.WriteLine("The Month is Octomber");
                    Console.WriteLine("31 Days in Month of Octomber ");
                    break;
                case 11:
                    Console.WriteLine("The Month is November");
                    Console.WriteLine("30 Days in Month of November");
                    break;
                case 12:
                    Console.WriteLine("The Month is December");
                    Console.WriteLine("31 Days in Month of December");
                    break;
               default: Console.WriteLine("Invalid Month Entered !"); break;

            }
            
            
            

        Console.ReadKey();
        }
    }
}
