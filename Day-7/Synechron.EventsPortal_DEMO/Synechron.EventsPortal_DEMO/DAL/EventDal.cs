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
    public class EventDal
    {
        public List<Event> GetAllEvents()
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllEvents";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    List<Event> events = new List<Event>();
                    while (DR.Read())
                    {
                        events.Add(new Event()
                        {
                            EventId = Convert.ToInt32(DR["EventId"]),
                            EventCode = Convert.ToString(DR["EventCode"]),
                           
                            EventName = Convert.ToString(DR["EventName"]),
                           
                            Description = Convert.ToString(DR["Description"]),
                            Fee = Convert.ToInt32(DR["Fee"])
                          

                        });
                    }

                    DR.Close();
                    CN.Close();
                    return events;

                }

            }


        }


        //  public Employee GetEmployeeDetails(int employee)
        public Event GetEventDetails(int id)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetEventDetails";
                    CMD.Parameters.AddWithValue("P_EventId", id);
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DR.Read();
                    Event events = new Event()
                    {
                        EventId = Convert.ToInt32(DR["EventId"]),
                        EventCode = Convert.ToString(DR["EventCode"]),

                        EventName = Convert.ToString(DR["EventName"]),

                        Description = Convert.ToString(DR["Description"]),

                        StartDate = Convert.ToDateTime(DR["StartDate"]),
                        EndDate = Convert.ToDateTime(DR["EndDate"]),
                        Fee = Convert.ToInt32(DR["Fee"]),
                        TotalSeatFilled = Convert.ToInt32(DR["TotalSeatFilled"]),
                        Logo = Convert.ToString(DR["Logo"])

                    };

                    DR.Close();
                    CN.Close();
                    return events;
                }
            }
        }




        public int InsertEvent(Event events)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "InsertEvent";
                    CMD.Parameters.AddWithValue("P_Eventcode", events.EventCode);
                    CMD.Parameters.AddWithValue("P_EventName", events.EventName);
                    CMD.Parameters.AddWithValue("P_Description", events.Description);
                    CMD.Parameters.AddWithValue("P_StartDate", events.StartDate);
                    CMD.Parameters.AddWithValue("P_EndDate", events.EndDate);
                    CMD.Parameters.AddWithValue("P_Fee", events.Fee);
                    CMD.Parameters.AddWithValue("P_TotalSeatFilled", events.TotalSeatFilled);
                    CMD.Parameters.AddWithValue("P_Logo", events.Logo);
                   
                    int result = CMD.ExecuteNonQuery();
                    CN.Close();
                    return result;
                }
            }

        }
    }



}