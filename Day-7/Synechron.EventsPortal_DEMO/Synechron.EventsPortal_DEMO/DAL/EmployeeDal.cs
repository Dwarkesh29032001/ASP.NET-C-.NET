using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Synechron.EventsPortal_DEMO.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;


namespace Synechron.EventsPortal_DEMO.DAL
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
                    List<Employee> employees = new List<Employee>();
                    while (DR.Read())
                    {
                        employees.Add(new Employee()
                        {
                            EmployeeId = Convert.ToInt32(DR["EmployeeId"]),
                            EmployeeName = Convert.ToString(DR["EmployeeName"]),
                            //Address = Convert.ToString(DR["Address"]),
                            City = Convert.ToString(DR["City"]),
                            //  Country = Convert.ToString(DR["Country"]),
                            Phone = Convert.ToString(DR["Phone"]),
                            Email = Convert.ToString(DR["Email"]),
                            //   SkillSets = Convert.ToString(DR["SkillSets"]),
                            //  Avatar = Convert.ToString(DR["Avatar"]),
                            //  Zipcode = Convert.ToString(DR["Zipcode"]

                        });
                    }

                    DR.Close();
                    CN.Close();
                    return employees;

                }

            }


        }


        //  public Employee GetEmployeeDetails(int employee)
        public Employee GetEmployeeDetails(int employeeId)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetEmployeeDetails";
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
                        SkillSets = Convert.ToString(DR["Skillsets"]),
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
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertEmployee";
                    CMD.Parameters.AddWithValue("P_EmployeeName", employee.EmployeeName);
                    CMD.Parameters.AddWithValue("P_EmployeeAddress", employee.Address);
                    CMD.Parameters.AddWithValue("P_City", employee.City);
                    CMD.Parameters.AddWithValue("P_Country", employee.Country);
                    CMD.Parameters.AddWithValue("P_Phone", employee.Phone);
                    CMD.Parameters.AddWithValue("P_Email", employee.Email);
                    CMD.Parameters.AddWithValue("P_Skillset", employee.SkillSets);
                    CMD.Parameters.AddWithValue("P_Avatar", employee.Avatar);
                    CMD.Parameters.AddWithValue("P_Zipcode", employee.Zipcode);
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }

        }
    }


        
}