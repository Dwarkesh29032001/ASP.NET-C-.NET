using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DisconnectedArchitectureExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection CN=new MySqlConnection("Data Source=192.168.100.80;Port=3306;Database=PurchaseOrderDb;User Id=saleel;Password=saleel"))
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("Select * from Customers", CN);
                DataSet DS=new DataSet();
                DA.Fill(DS, "Customers");
                customersDataGridView.DataSource = DS.Tables[0];
            }
        }
    }
}
