using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection CN = new MySql.Data.MySqlClient.MySqlConnection("Data Source=127.0.0.1;Port=3306;Database=dwarkesh;User Id=root;Password=Dsv@29032001"))
            {
                MySqlDataAdapter DA = new MySqlDataAdapter("Select * from customer" , CN);
                DataSet DS = new DataSet();
                DA.Fill(DS , "customer");
                dataGridView1.DataSource = DS.Tables[0];

            }

        }
    }
}
