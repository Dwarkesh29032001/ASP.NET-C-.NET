using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Problem_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            int num = int.Parse(Console.ReadLine());
            if (Check(num))
            {
                Prime(num);
            }
            else
            {
                Console.WriteLine("Enter the number Again !");
            }
            Console.ReadKey();

        }

       static void Prime(int num)
        {
            int count = 0;
            for (int j=1; j<=num; j++)
            {
               
                for(int i=j; i<=j; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
            

            }
            if (count > 2)
            {
                Console.WriteLine("Number is Not A Prime Number");
            }
            else
            {
                Console.WriteLine("Number is Prime Number");

            }
            

            
        }

        static Boolean Check(int num)
        {
            if (num >= 0)
            {
               // Console.WriteLine("The Number is Positive");
               return true;
            }
            else { //Console.WriteLine("The Number is Negative");
                return false;
            }
        }
    }
}
