using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_16_first_25_prime_Number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The first 25 prime Numbers are as below : ");
            int Mcount = 1;
            for (int i = 1; i <= num && Mcount<=25; i++)
            {
                
                int count = 0;
                int checkNum = i;
                for (int j = 1; (j <= checkNum ); j++)
                {

                    if (checkNum % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2 )
                {
                    Console.WriteLine($" {Mcount}) prime number is {i}");
                    Mcount++;   
                }
              //  Mcount++;


            }
            Console.ReadKey();
        }
            


       
    }
  }

