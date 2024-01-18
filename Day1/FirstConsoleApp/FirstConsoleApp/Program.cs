using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please Enter Your Name : ");
                String myname = Console.ReadLine();
                Console.WriteLine("Please Enter Your Age : ");
                int age = int.Parse(Console.ReadLine());
                // Console.WriteLine("My name is Dwarkesh Virkhare !");
                //    Console.WriteLine("Hello Dwarkesh Welcome to .NET framework");
                Console.WriteLine($"My name is : {myname} and Age is : {age} ");
               
            }
            catch (Exception X)
            {

                Console.WriteLine(X.Message);
            }
             Console.ReadKey();
        }
    }
}
