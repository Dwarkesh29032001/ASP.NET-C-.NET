using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Swap_number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20;
            int num2 = 50;

            Console.WriteLine($"The number Before swap is num1 = {num1} and num2 = {num2} ");

            int temp = num2; ;
            num2 = num1;
            num1 = temp;

            Console.WriteLine($"The number After Swap is num1 = {num1} and num2 = {num2} ");
            Console.ReadKey();  

        }
    }
}
