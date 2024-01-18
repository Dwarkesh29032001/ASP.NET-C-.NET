using ConnectedArchitectureExamples.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace ConnectedArchitectureExamples.Dal
{
    public class CustomerDal
    {
        public List<Customer> GetAllCustomers()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomers";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Customer> customers = new List<Customer>();
                    while (DR.Read())
                    {
                        customers.Add(new Customer()
                        {
                            CustomerId = Convert.ToInt32(DR["CustomerId"]),
                            ContactName = Convert.ToString(DR["ContactName"]),
                            City = Convert.ToString(DR["City"])
                        });
                    }
                    DR.Close();
                    CN.Close();
                    return customers;
                }
            }
        }
        public int InsertCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    CMD.Parameters.AddWithValue("p_ContactName", customer.ContactName);
                    CMD.Parameters.AddWithValue("p_City", customer.City);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int UpdateCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    CMD.Parameters.AddWithValue("p_ContactName", customer.ContactName);
                    CMD.Parameters.AddWithValue("p_City", customer.City);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
        public int DeleteCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteCustomer";
                    CMD.Parameters.AddWithValue("p_CustomerId", customer.CustomerId);
                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }
        }
    }
}
