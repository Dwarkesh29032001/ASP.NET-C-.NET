using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] marks= {50 ,38,50 ,90, 76};
            int[] marks = new int[5];


            for(int i = 0;i<marks.Length; i++)
            {
                Console.WriteLine($"Enter the marks of {i} subject : ");
                int num = int.Parse(Console.ReadLine());
                marks[i] = num;

            }
           int sum = 0;
            for(int i = 0;  i<marks.Length; i++)
            {

               sum = sum + marks[i];
               
            }
            int avg = sum / 5;
            Console.WriteLine($"The Sum Of 5 subject is : {sum}");            
            Console.WriteLine($"The Average of Marks of Suject is :{avg} ");
            Console.ReadKey();
        }
      
    }
}
