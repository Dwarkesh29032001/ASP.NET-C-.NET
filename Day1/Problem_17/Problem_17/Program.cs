using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number rows :");
            int row =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number Colunms :");
            int colunms = int.Parse(Console.ReadLine());

            for(int i=0; i < row; i++)
            {
                for(int j=0 ; j < colunms; j++)
                {

                    Console.Write($"{j}  ");

                }
                Console.WriteLine("\n");
            }
           Console.ReadLine();
        }
    }
}
