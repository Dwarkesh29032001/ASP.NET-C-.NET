using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Product_CRUD_Operation.Model;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Product_CRUD_Operation.Dal
{
    public class ProductDal
    {
        public List<Product> GetAllProducts()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllProducts";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Product> products = new List<Product>();
                    while (DR.Read())
                    {
                        products.Add(new Product()
                        {
                            productID = Convert.ToInt32(DR["productID"]),
                            productName = Convert.ToString(DR["productName"]),
                            productPrice = Convert.ToDecimal(DR["productPrice"]),
                            productCompany = Convert.ToString(DR["productCompany"]),
                            productRating = Convert.ToDecimal(DR["productRating"]),


                        });
                    }

                    DR.Close();
                    CN.Close();
                    return products;

                }

            }


        }

        public int InsertProduct(Product product)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertProduct";
                    CMD.Parameters.AddWithValue("P_ProductID", product.productID);
                    CMD.Parameters.AddWithValue("P_ProductName", product.productName);
                    CMD.Parameters.AddWithValue("P_ProductPrice", product.productPrice);
                    CMD.Parameters.AddWithValue("P_ProductCompany", product.productCompany);
                    CMD.Parameters.AddWithValue("P_ProductRating", product.productRating);

                    int result = CMD.ExecuteNonQuery();
                    return result;

                }
            }
        }

        public int UpdateProduct(Product product)
        {

            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "UpdateProduct";
                    CMD.Parameters.AddWithValue("P_ProductID", product.productID);
                    CMD.Parameters.AddWithValue("P_ProductName", product.productName);
                    CMD.Parameters.AddWithValue("P_ProductPrice", product.productPrice);
                    CMD.Parameters.AddWithValue("P_ProductCompany", product.productCompany);
                    CMD.Parameters.AddWithValue("P_ProductRating", product.productRating);

                    int result = CMD.ExecuteNonQuery();
                    return result;
                }
            }

        }

        public int DeleteEmployee(Product product)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "DeleteProduct";
                    CMD.Parameters.AddWithValue("P_ProductID", product.productID);
                    int result = CMD.ExecuteNonQuery();
                    return result;

                }
            }

        }









    }
}
