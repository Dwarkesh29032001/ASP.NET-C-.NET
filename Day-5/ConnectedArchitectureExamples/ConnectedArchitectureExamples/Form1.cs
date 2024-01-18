using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedArchitectureExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["InfowayPoDbConStr"].ConnectionString))
            {
                using (MySqlCommand CMD=new MySqlCommand())
                {
                    CN.Open();
                    CMD.Connection= CN;
                    CMD.CommandType = CommandType.StoredProcedure;
                    CMD.CommandText = "GetAllCustomers";
                    MySqlDataReader DR = CMD.ExecuteReader();
                    DataTable customersTable=new DataTable("Customers");
                    customersTable.Load(DR);
                    dgvCustomer.DataSource= customersTable;
                    CN.Close();
                }
            }
        }
    }
}
