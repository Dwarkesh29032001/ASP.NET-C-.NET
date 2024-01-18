using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_15_ASCII_0_255__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<=255; i++)
            {
                int Number = i;
                char charValue = (char)Number;
                Console.WriteLine( $"The ASCII of Interger {i} is " + charValue);
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine(); 
                    Thread.Sleep(1000); 
                }
            }
            Console.ReadKey();
        }
    }
}
