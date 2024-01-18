using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_12__by_creating_Employee_class_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] Employees = new Employee[5];
            for(int i=0; i<Employees.Length; i++)
            {
                Console.WriteLine("Enter Employee ID :");
                int EmpID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee DepartmentId   :");
                int DeptID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Department Name :");
                String DeptName = (Console.ReadLine());
                Console.WriteLine("Enter Employee Desgination Code :");
                char DesgCode = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Desgination Name :");
                String DesgName = (Console.ReadLine());


                Employees[i] = new Employee(EmpID, DeptID, DeptName, DesgCode,DesgName);

            }

            foreach(var Employee in Employees)
            {
                Employee.printEmployeeData();
            }
            Console.ReadKey();

           
        }
    }
}
