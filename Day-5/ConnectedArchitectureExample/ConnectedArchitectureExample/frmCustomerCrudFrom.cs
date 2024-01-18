using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectedArchitectureExample.Dal;
using ConnectedArchitectureExample.Models;


namespace ConnectedArchitectureExample
{
    public partial class frmCustomerCrudFrom : Form
    {
        public frmCustomerCrudFrom()
        {
            InitializeComponent();
        }


        CustomerDal customerDal = new CustomerDal();
        int index = 0;

        List<Customer> customersList;

        private void frmCustomerCrudFrom_Load(object sender, EventArgs e)
        {
            customersList = customerDal.GetAllcustomers();
            Navigate(index);

        }

        private void Navigate(int currentIndex)
        {
            if (customersList.Count > 0)
            {
                txtCustomerID.Text = customersList[currentIndex].customerID.ToString();
                txtCustomerName.Text = customersList[currentIndex].customerName;
                txtCustomerEmail.Text = customersList[currentIndex].customerEmail;
                txtCustomerPhone.Text = customersList[currentIndex].customerPhone.ToString();
                txtCustomerAddress.Text = customersList[currentIndex].customerAddress;
               // txtRegdate.Text = customersList[currentIndex].registrationDate.ToString();
            }
        }

        private void btnMoveFirst_Click_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);
        }

        private void btnMoveLast_Click_Click(object sender, EventArgs e)
        {
            index = customersList.Count - 1;
            Navigate(index);
        }

        private void btnMovePrevious_Click_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            }

        }

        private void btnMoveNext_Click_Click(object sender, EventArgs e)
        {
            if (index < customersList.Count - 1)
            {
                index++;
                Navigate(index);
            }
        }

        private void btnNew_Click_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerEmail.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
          //  txtRegdate.Text = string.Empty;
            txtCustomerID.Focus();
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customerID = int.Parse(txtCustomerID.Text),
                customerName = txtCustomerName.Text,
                customerEmail = txtCustomerEmail.Text,
                customerPhone = txtCustomerPhone.Text,
                customerAddress = txtCustomerAddress.Text,
               // registrationDate = txtRegdate.Text,

            };
            int result = customerDal.InsertCustomer(customer);
            if (result > 0) { 
            customersList = customerDal.GetAllcustomers();

            }
        }

        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customerID = int.Parse(txtCustomerID.Text),
                customerName = txtCustomerName.Text,
                customerEmail = txtCustomerEmail.Text,
                customerPhone = txtCustomerPhone.Text,
                customerAddress = txtCustomerAddress.Text,
               // registrationDate = txtRegdate.Text

            };
            int result = customerDal.UpdateCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllcustomers();
            }
        }

        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                customerID = int.Parse(txtCustomerID.Text),
                customerName = txtCustomerName.Text,
                customerEmail = txtCustomerEmail.Text,
                customerPhone = txtCustomerPhone.Text,
                customerAddress = txtCustomerAddress.Text,
                //registrationDate = txtRegdate.Text

            };
            int result = customerDal.DeleteCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllcustomers();
            }
        }
    }
}
