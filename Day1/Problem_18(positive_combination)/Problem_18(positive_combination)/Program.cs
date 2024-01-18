using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Problem_18_positive_combination_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers you Want :");
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the {i} element of the array :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            // for printing the array element 
            Console.WriteLine("The Element of the array is ");
            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The Combination of the number is are follows ");
            foreach (var num1 in arr)
            {
                foreach (var num2 in arr)
                {
                    foreach (var num3 in arr)
                    {
                        Console.WriteLine($"{num1} {num2} {num3}");
                    }
                }
            }
            Console.ReadKey();

            //int[] numbers = { 1, 2, 3 };

            // Loop through all combinations using nested loops





        }
    }
}
