using ConnectedArchitectureExamples.Dal;
using ConnectedArchitectureExamples.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ConnectedArchitectureExamples
{
    public partial class frmCustomerCrudForm : Form
    {
        public frmCustomerCrudForm()
        {
            InitializeComponent();
        }
        CustomerDal customerDal = new CustomerDal();
        int index = 0;
        List<Customer> customersList;
        private void frmCustomerCrudForm_Load(object sender, EventArgs e)
        {
            customersList = customerDal.GetAllCustomers();
            Navigate(index);
        }
        private void Navigate(int currentIndex)
        {
            if (customersList.Count > 0)
            {
                txtCustomerId.Text = customersList[currentIndex].CustomerId.ToString();
                txtContactName.Text = customersList[currentIndex].ContactName;
                txtCity.Text = customersList[currentIndex].City;
            }
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            index = customersList.Count - 1;
            Navigate(index);
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            }
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (index < customersList.Count - 1)
            {
                index++;
                Navigate(index);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCustomerId.Text = string.Empty;
            txtContactName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCustomerId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                ContactName = txtContactName.Text,
                City = txtCity.Text
            };
            int result = customerDal.InsertCustomer(customer);
            if (result>0)
            {
                customersList = customerDal.GetAllCustomers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                ContactName = txtContactName.Text,
                City = txtCity.Text
            };
            int result = customerDal.UpdateCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllCustomers();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer()
            {
                CustomerId = int.Parse(txtCustomerId.Text),
                ContactName = txtContactName.Text,
                City = txtCity.Text
            };
            int result = customerDal.DeleteCustomer(customer);
            if (result > 0)
            {
                customersList = customerDal.GetAllCustomers();
            }
        }
    }
}
