using MySql.Data.MySqlClient;
using Synechron.EventsPortal.Models;
using System;
using System.Configuration;
using System.Data;

namespace Synechron.EventsPortal.Dal
{
    public class SecurityDal
    {
        public User AuthenticateCredentials(User user)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["SynechronEventsConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "AuthenticateCredentials";
                    CMD.Parameters.AddWithValue("p_Email", user.Email);
                    CMD.Parameters.AddWithValue("p_Password", user.Password);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    User existingUser = new User()
                    {
                        Email = Convert.ToString(DR["Email"]),
                        Role = Convert.ToString(DR["RoleName"]),
                    };

                    DR.Close();
                    CN.Close();
                    return existingUser;
                }
            }
        }
    }
}