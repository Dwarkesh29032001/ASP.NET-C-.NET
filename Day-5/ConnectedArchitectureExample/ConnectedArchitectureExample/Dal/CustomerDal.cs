using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectedArchitectureExample.Models;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;



namespace ConnectedArchitectureExample.Dal
{
    public class CustomerDal
    {
        public List<Customer> GetAllcustomers()
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
                    List<Customer> Customers = new List<Customer>();
                    while (DR.Read())
                    {
                        Customers.Add(new Customer()
                        {
                            customerID = Convert.ToInt32(DR["customerID"]),
                            customerName = Convert.ToString(DR["customerName"]),
                            customerEmail = Convert.ToString(DR["customerEmail"]),
                            customerPhone = Convert.ToString(DR["customerPhone"]),
                            customerAddress = Convert.ToString(DR["customerAddress"]),
                            //registrationDate = Convert.ToString(DR["registrationDate"]),

                        });
                    }

                    DR.Close();
                    CN.Close();
                    return Customers;

                }

            }

            
        }

        public int InsertCustomer(Customer customer)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using(MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertCustomer";
                    CMD.Parameters.AddWithValue("P_customerID" , customer.customerID);
                    CMD.Parameters.AddWithValue("P_customerName", customer.customerName);
                    CMD.Parameters.AddWithValue("P_CustomerEmail", customer.customerEmail);
                    CMD.Parameters.AddWithValue("P_Customerphone", customer.customerPhone);
                    CMD.Parameters.AddWithValue("P_CustomerAddress", customer.customerAddress);
                    //CMD.Parameters.AddWithValue("P_registrationDate", customer.registrationDate);
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
                    CMD.Parameters.AddWithValue("P_customerID", customer.customerID);
                    CMD.Parameters.AddWithValue("P_customerName", customer.customerName);
                    CMD.Parameters.AddWithValue("P_CustomerEmail", customer.customerEmail);
                    CMD.Parameters.AddWithValue("P_Customerphone", customer.customerPhone);
                    CMD.Parameters.AddWithValue("P_CustomerAddress", customer.customerAddress);
                   // CMD.Parameters.AddWithValue("P_registrationDate", customer.registrationDate);
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
                    CMD.Parameters.AddWithValue("P_customerID", customer.customerID);
                    int result = CMD.ExecuteNonQuery();
                    return result;

                }
            }

        }



    }
}
