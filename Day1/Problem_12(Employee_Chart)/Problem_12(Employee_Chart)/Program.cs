using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12_Employee_Chart_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter Employee ID number :");
            int EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Department ID number :");
            int EmpDeptNo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Employee Department Name  :");
            //String DeptName = Console.ReadLine();
            Console.WriteLine("Enter Employee Designation Code :");
            char DesgCode = char.Parse(Console.ReadLine());
            // Console.WriteLine("Enter Employee Designation Name  :");
            // String DesgName = Console.ReadLine();

            //printEmployeeData();


            Console.WriteLine($"Employee Number is : {EmpID}");
            Console.WriteLine($"Employee Department Number is : {EmpDeptNo}");
            Console.WriteLine($"Employee Designation Code  is : {DesgCode}");


            switch (EmpDeptNo) {
                case 10:
                    Console.WriteLine("Employee Department Name : Purchase");
                    break;
                case 20:
                    Console.WriteLine("Employee Department Name : Sales");
                    break;
                case 30:
                    Console.WriteLine("Employee Department Name : Production");
                    break;
                case 40:
                    Console.WriteLine("Employee Department Name : Marketing");
                    break;
                case 50:
                    Console.WriteLine("Employee Department Name : Accounts");
                    break;
              

            }


            switch (DesgCode) {


                case 'M':
                    Console.WriteLine("Employee Designation Name is : Manager");
                    break;

                case 'S':
                    Console.WriteLine("Employee Designation Name is : Supervisor");
                    break;

                case 'A':
                    Console.WriteLine("Employee Designation Name is : Analyst");
                    break;
                case 's':
                    Console.WriteLine("Employee Designation Name is : Sales Person");
                    break;
                case 'a':
                    Console.WriteLine("Employee Designation Name is : Accountant");
                    break;

            }




            
            //Console.WriteLine($"Employee Department Name is : {DeptName}");
          //  Console.WriteLine($"Employee Designation Code  is : {DesgCode}");
           // Console.WriteLine($"Employee Designation Name is : {DesgName}");




            

            Console.ReadKey();

        }

        /*static void printEmployeeData()
        {
            Console.WriteLine($"{}");

        }*/
    }
}
