using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            char ch;


            do
            {
                Console.WriteLine("Enter The First Number :");
                 num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter The Second Number :");
                 num2 = int.Parse((string)Console.ReadLine());

                Console.WriteLine("1. Press A for Addtion ");
                Console.WriteLine("2. Press B for Subtarction ");
                Console.WriteLine("3. Press C for Division ");
                Console.WriteLine("4. Press D for Multiplication ");
                Console.WriteLine("5. Press E for Exit ");

                Console.WriteLine("Enter Your Choice of OPeration :");
                 ch = char.Parse(Console.ReadLine());
                //char ch=;
                switch (ch)
                {

                    case 'A':
                        Console.WriteLine(num1 + num2);
                        break;
                    case 'B':
                        Console.WriteLine(num1 - num2);
                        break;
                    case 'C':
                        Console.WriteLine(num1 / num2);
                        break;
                    case 'D':
                        Console.WriteLine(num1 * num2);
                        break;
                    case 'E':
                        // Console.WriteLine("Invalid choice !!");
                        break;
                        //default: Console.WriteLine("Invalid choice ! ");
                }

            } while (ch != 'E');


        }


        }
    }

