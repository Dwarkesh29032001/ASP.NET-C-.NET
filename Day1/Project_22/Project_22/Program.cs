using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the date :");
            int DD = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Month :");
            int MM = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Year :");
            int YY = int.Parse(Console.ReadLine());
            Console.WriteLine("The date Funtion outPut is :");
            getDate(DD, MM, YY);
            Console.ReadKey();  

        }
        static void getDate(int day, int month, int year) 
        {

            Console.WriteLine($"{day}/{month}/{year}");
        }
    }
}
