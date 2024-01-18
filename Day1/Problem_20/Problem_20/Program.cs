using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Problem_20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the How many trems you want in the Fibonacii Series :");
            int  num= int.Parse(Console.ReadLine());
            Console.WriteLine("The Fibonacci Series is as follows :");
            for(int i=0; i<num; i++)
            {
                Console.Write(fibonaciSeries(i));
                Console.Write(",");
            }
            Console.ReadKey();

        }

       static int fibonaciSeries(int num)
        {
            if (num == 1 || num==0)
            {
                return 1;
            }

            else
            {
                return fibonaciSeries(num-1) + fibonaciSeries(num-2);

            }

            
        }


        
    }
}
