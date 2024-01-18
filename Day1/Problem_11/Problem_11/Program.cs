using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number :");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number :");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Using If Else Statement");
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"{num1} is the largest Number");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"{num2} is the largest Number");
            }
            else { Console.WriteLine($"{num3} is the largest Number"); }




            Console.WriteLine(">>>>>>>>>>>Using Conditonal Operator");
            int largest_Number = (num1>num2  && num1 > num3) ? num1 : (num2 > num1 && num2 > num3) ? num2 : num3 ;

            Console.WriteLine($"The largest Number is : {largest_Number} ");


            Console.ReadKey();
        }
    }
}
