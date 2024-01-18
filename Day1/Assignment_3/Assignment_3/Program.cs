using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Your Character : ");
            char A = char.Parse(Console.ReadLine());
            int num = A;
            Console.WriteLine($"The ASCII value of the Entered Character {A} is {num}  ");
            Console.ReadKey();
        }
    }
}
