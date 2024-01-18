using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("Choose A for Square");
            Console.WriteLine("Choose B for Circle");
            Console.WriteLine("Choose C for Rectangle");
            //Console.WriteLine("Choose  for Square");
            Console.WriteLine("Select Your Choice  from Below:");

            char ch = char.Parse(Console.ReadLine());   

            //Console.WriteLine("Select Your Shape :");

            switch (ch)
            {
                case 'A':
                    Console.WriteLine("Enter the side of Square");
                    double side = double.Parse(Console.ReadLine());           
                    Console.WriteLine("Select Operation to Perform :");
                    Console.WriteLine("Select 1 for Area");
                    Console.WriteLine("Select 2 for Perimeter");
                    Console.WriteLine("Select 3 for Both Area and Perimeter");
                    int num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1: Console.Write("The Area is :");
                            Console.Write(side * side);
                            break;
                        case 2:
                            Console.Write("The Perimeter is :");
                            Console.Write(4 * side);
                            break;
                        case 3:
                            Console.WriteLine("The Area and Perimeter Both is :");
                            Console.WriteLine("The Area is :"+(side * side));
                            Console.WriteLine("The Perimeter is :"+(4 * side));
                            break;
                    }


                    break;

                case 'B':
                    Console.WriteLine("Enter the Radius of Circle");
                    double Radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Select Operation to Perform :");
                    Console.WriteLine("Select 1 for Area");
                    Console.WriteLine("Select 2 for Perimeter");
                    Console.WriteLine("Select 3 for Both Area and Perimeter");
                    int num1 = int.Parse(Console.ReadLine());
                    switch (num1)
                    {
                        case 1:
                            Console.Write("The Area is :");
                            Console.Write(3.147*Radius * Radius);
                            break;
                        case 2:
                            Console.Write("The Perimeter is :");
                            Console.Write(2 * 3.14*Radius);
                            break;
                        case 3:
                            Console.WriteLine("The Area and Perimeter Both is :");
                            Console.WriteLine("The Area is :"+ (3.147 * Radius * Radius));
                            Console.WriteLine("The Perimeter is :"+ (2 * 3.14 * Radius));
                            break;
                    }


                    break;

                case 'C':

                    Console.WriteLine("Enter the Length of Rectangle");
                    double Length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Breath of Rectangle");
                    double Breath = double.Parse(Console.ReadLine());
                    Console.WriteLine("Select Operation to Perform :");
                    Console.WriteLine("Select 1 for Area");
                    Console.WriteLine("Select 2 for Perimeter");
                    Console.WriteLine("Select 3 for Both Area and Perimeter");
                    int num2 = int.Parse(Console.ReadLine());
                    switch (num2)
                    {
                        case 1:
                            Console.Write("The Area is :");
                            Console.Write(Length*Breath);
                            break;
                        case 2:
                            Console.Write("The Perimeter is :");
                            Console.Write(2 * (Length + Breath));
                            break;
                        case 3:
                            Console.WriteLine("The Area and Perimeter Both is :");
                            Console.WriteLine("The Area is :" + (Length * Breath));
                            Console.WriteLine("The Perimeter is :"+ (2 * (Length + Breath)));
                            break;
                    }

                    break;



            }

            Console.ReadKey();
        }
    }
}
