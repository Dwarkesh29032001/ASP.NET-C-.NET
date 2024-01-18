using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7_Net_Salary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("Enter the BasicSalary : ");
            int BasicSalary =  int.Parse(Console.ReadLine());
            int num = BasicSalary;


            double HRA = 0.20 * num;
            double DA = 0.40 * num;
            double PF = 0.10 * num;

            double GrossSalary = HRA + DA + BasicSalary ;
            //double num2 = GrossSalary ;

            Console.WriteLine($"The GrossSalary is :{GrossSalary} ");

            //double NetSalary; 
            double NetSalary = GrossSalary - PF;

            Console.WriteLine($"The NetSalary is :{NetSalary} ");

            Console.ReadKey();  
        }
    }
}
