using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter the Year you want to Check : ");
            int year = int.Parse(Console.ReadLine());
            int num = year;
            if((num%4==0 && num%100!=0) || num%400==0)
            {
                Console.WriteLine($"The year {num} is LEAP year ! ");
            }
            else
            {
                Console.WriteLine("Not Leap Year  it's Normal Year !");
            }*/

            Console.WriteLine("Enter the Year you want to Check : ");
            int year = int.Parse(Console.ReadLine());
            int num = year;
            String result = ((num % 4 == 0 && num % 100 != 0) || num % 400 == 0) ? ( $"The year {num} is LEAP year ! " ):( "Not Leap Year  it's Normal Year !");
            Console.WriteLine(result);  
            Console.ReadKey();
        }
    }
}
