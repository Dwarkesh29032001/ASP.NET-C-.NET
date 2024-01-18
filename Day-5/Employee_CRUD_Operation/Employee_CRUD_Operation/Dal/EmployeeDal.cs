using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_CRUD_Operation.Model;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;


namespace Employee_CRUD_Operation.Dal
{
    public class EmployeeDal
    {

        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllEmployees";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Employee> Employees = new List<Employee>();
                    while (DR.Read())
                    {
                        Employees.Add(new Employee()
                        {
                            empId = Convert.ToInt32(DR["empID"]),
                            empName = Convert.ToString(DR["empName"]),
                            empSal = Convert.ToInt32(DR["empSal"]),
                            empAddress = Convert.ToString(DR["empAddress"]),
                            empDesignation = Convert.ToString(DR["empDesignation"]),
                            

                        });
                    }

                    DR.Close();
                    CN.Close();
                    return Employees;

                }

            }


        }


        public int InsertEmployee(Employee employee)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertEmployee";
                    CMD.Parameters.AddWithValue("P_EmployeeID", employee.empId);
                    CMD.Parameters.AddWithValue("P_EmployeeName", employee.empName);
                    CMD.Parameters.AddWithValue("P_EmployeeSalary", employee.empSal);
                    CMD.Parameters.AddWithValue("P_EmployeeAddress", employee.empAddress);
                    CMD.Parameters.AddWithValue("P_EmployeeDesignation", employee.empDesignation);
               
                    int result = CMD.ExecuteNonQuery();
                    return result;

                }
            }
        }


        public int UpdateEmployee(Employee employee)
        {

            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateEmployee";
                    CMD.Parameters.AddWithValue("P_EmployeeID", employee.empId);
                    CMD.Parameters.AddWithValue("P_EmployeeName", employee.empName);
                    CMD.Parameters.AddWithValue("P_EmployeeSalary", employee.empSal);
                    CMD.Parameters.AddWithValue("P_EmployeeAddress", employee.empAddress);
                    CMD.Parameters.AddWithValue("P_EmployeeDesignation", employee.empDesignation);
                   
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }

        }

        public int DeleteEmployee(Employee employee)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteEmployee";
                    CMD.Parameters.AddWithValue("P_EmployeeID", employee.empId);
                    int result = CMD.ExecuteNonQuery();
                    return result;

                }
            }

        }

    }
}
