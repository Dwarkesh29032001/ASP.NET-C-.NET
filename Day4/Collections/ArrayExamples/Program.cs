using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First Example
            /*int[] numbers = new int[5] { 100, 200, 300, 400, 500 };
            for (int i = 0; i < numbers.Length; i++)
            {
                //logic
                Console.WriteLine(numbers[i]);
            }*/
            //Second Example
            /* int[,] numbers = new int[2, 2] { { 0, 5 }, { 1, 10 } };
             for (int row = 0; row < 2; row++)
             {
                 for (int col = 0; col < 2; col++)
                 {
                     Console.WriteLine(numbers[row, col]);
                 }
             }*/
            //Third Example - Jagged Array
            int[][] studentMarks = new int[3][];
            studentMarks[0] = new int[3] { 78, 90, 78 };
            studentMarks[1] = new int[5] { 78, 90, 78, 56,45 };
            studentMarks[2] = new int[2] { 90, 78 };

            for (int index = 0; index < 3; index++)
            {
                Console.WriteLine($"Student Id - {index}");
                for (int subjects = 0; subjects < studentMarks[index].Length; subjects++)
                {
                    Console.Write($"Subject Marks {studentMarks[index][subjects]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
