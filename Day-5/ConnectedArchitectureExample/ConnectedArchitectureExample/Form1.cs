﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConnectedArchitectureExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD = new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection = CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllcustomers";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DataTable customer = new DataTable("customer");
                    customer.Load(DR);

                    dataGridView1.DataSource = customer;
                    CN.Close();
                }

            }
        }
    }
}