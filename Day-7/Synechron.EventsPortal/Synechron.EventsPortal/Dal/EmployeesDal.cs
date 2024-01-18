using System.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Synechron.EventsPortal.Models;
using System.Data;

namespace Synechron.EventsPortal.Dal
{
    public class EmployeesDal
    {
        public List<Employee> GetAllEmployees()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "ShowAllEmployees";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Employee> employees = new List<Employee>();
                    while (DR.Read())
                    {
                        employees.Add(new Employee()
                        {
                            EmployeeId = Convert.ToInt32(DR["EmployeeId"]),
                            EmployeeName = Convert.ToString(DR["EmployeeName"]),
                            City = Convert.ToString(DR["City"]),
                            Email = Convert.ToString(DR["Email"]),
                            Phone = Convert.ToString(DR["Phone"]),
                        });
                    }
                    DR.Close();
                    CN.Close();
                    return employees;
                }
            }
        }
        public Employee GetEmployeeDetails(int employeeId)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "ShowEmployeeDetails";
                    CMD.Parameters.AddWithValue("p_EmployeeId", employeeId);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    Employee employee = new Employee()
                    {
                        EmployeeId = Convert.ToInt32(DR["EmployeeId"]),
                        EmployeeName = Convert.ToString(DR["EmployeeName"]),
                        Address = Convert.ToString(DR["Address"]),
                        City = Convert.ToString(DR["City"]),
                        Email = Convert.ToString(DR["Email"]),
                        Phone = Convert.ToString(DR["Phone"]),
                        Zipcode = Convert.ToString(DR["Zipcode"]),
                        Skillsets = Convert.ToString(DR["Skillsets"]),
                        Avatar = Convert.ToString(DR["Avatar"]),
                        Country = Convert.ToString(DR["Country"])
                    };

                    DR.Close();
                    CN.Close();
                    return employee;
                }
            }
        }
        public int InsertEmployee(Employee employee)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertEmployee";
                    CMD.Parameters.AddWithValue("p_EmployeeName",employee.EmployeeName);
                    CMD.Parameters.AddWithValue("p_Address", employee.Address);
                    CMD.Parameters.AddWithValue("p_City", employee.City);
                    CMD.Parameters.AddWithValue("p_Country", employee.Country);
                    CMD.Parameters.AddWithValue("p_Phone", employee.Phone);
                    CMD.Parameters.AddWithValue("p_Email", employee.Email);
                    CMD.Parameters.AddWithValue("p_Skillsets", employee.Skillsets);
                    CMD.Parameters.AddWithValue("p_Avatar", employee.Avatar);
                    CMD.Parameters.AddWithValue("p_Zipcode", employee.Zipcode);
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }
        }
    }
}