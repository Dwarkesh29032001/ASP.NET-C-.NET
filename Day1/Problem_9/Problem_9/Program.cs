using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Basic Salary of salesperson :");
            int BasicSalary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Sales of salesperson :");
            int Sales = int.Parse(Console.ReadLine());
            double commision=0.0;
            if (Sales >= 50000 && Sales <= 7500)
            {
               commision = 0.03;
            }
           else if (Sales >= 7501 && Sales <= 10500)
            {
                commision = 0.08;
            }
           else if (Sales >= 10501 && Sales <= 15000)
            {
                commision = 0.11;
            }
            else if (Sales >= 15000)
            {
               commision = 0.15;
            }
            else
            {
                Console.WriteLine("There is No Commosion for this Amount of sales .");
            }

            double commEarned = (double)Sales * commision;

            Console.WriteLine($"The Commission Earned is : {commEarned} ");

            double Netsalary = BasicSalary + commEarned;


            Console.WriteLine($"The Net Salary of SalesPerson is : {Netsalary}");
            Console.ReadLine();
        }
    }
}
