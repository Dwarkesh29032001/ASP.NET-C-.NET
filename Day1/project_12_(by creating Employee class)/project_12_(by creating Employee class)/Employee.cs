using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_12__by_creating_Employee_class_
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public int DeptID { get; set; }
        public String DeptName { get; set; }
        public char DesgCode { get; set; }
        public String DesgName { get; set; }

        public Employee(int employeeID, int deptID, string deptName, char desgCode, string desgName)
        {
            EmployeeID = employeeID;
            DeptID = deptID;
            DeptName = deptName;
            DesgCode = desgCode;
            DesgName = desgName;
        }   


        public void printEmployeeData()
        {
            Console.WriteLine($"EmployeeID is : {EmployeeID} ");
            Console.WriteLine($"Employee Department ID is : {DeptID} ");
            Console.WriteLine($"Employee Department Name is : {DeptName} ");
            Console.WriteLine($"Employee Designation Code is : {DesgCode} ");
            Console.WriteLine($"Employee Designation Name is : {DesgName} ");

            Console.WriteLine();
        }

    }
}
