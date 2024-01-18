using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14_Absolute_number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number :");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine( "The Absolute Number is : " + num/(-1));
            }
            else
            {
                Console.WriteLine("The Absolute Number is : "+ num);
            }
            Console.ReadKey();
        }
    }
}
