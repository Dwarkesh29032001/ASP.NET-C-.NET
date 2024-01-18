using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_CRUD_Operation.Dal;
using Employee_CRUD_Operation.Model;

namespace Employee_CRUD_Operation
{
    public partial class frmEmployeeCrudForm : Form
    {
        public frmEmployeeCrudForm()
        {
            InitializeComponent();
        }

        EmployeeDal employeeDal = new EmployeeDal();
        int index = 0;

        List<Employee> EmployeeList;

        private void frmEmployeeCrudForm_Load(object sender, EventArgs e)
        {
            EmployeeList = employeeDal.GetAllEmployees();
            Navigate(index);

        }

        private void Navigate(int currentIndex)
        {
            if (EmployeeList.Count > 0)
            {
                txtEmployeeID.Text = EmployeeList[currentIndex].empId.ToString();
                txtEmployeeName.Text = EmployeeList[currentIndex].empName;
                txtEmployeeSalary.Text = EmployeeList[currentIndex].empSal.ToString();
                txtEmployeeAddress.Text = EmployeeList[currentIndex].empAddress;
                txtEmployeeDesignation.Text = EmployeeList[currentIndex].empDesignation;
                
            }
        }

        private void btn_MoveFirst_Click_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);
        }

        private void btn_MoveLast_Click_Click(object sender, EventArgs e)
        {
            index = EmployeeList.Count - 1;
            Navigate(index);
        }

        private void btn_MovePrevious_Click_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            }

        }

        private void btn_MoveNext_Click_Click(object sender, EventArgs e)
        {
            if (index < EmployeeList.Count - 1)
            {
                index++;
                Navigate(index);
            }
        }

        private void btn_AddNewEmployee_Click_Click(object sender, EventArgs e)
        {
            txtEmployeeID.Text = string.Empty;
            txtEmployeeName.Text = string.Empty;
            txtEmployeeSalary.Text = string.Empty;
            txtEmployeeAddress.Text = string.Empty;
            txtEmployeeDesignation.Text = string.Empty;
            txtEmployeeID.Focus();
        }

        private void btn_Save_Employee_Click_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                empId = int.Parse(txtEmployeeID.Text),
                empName = txtEmployeeName.Text,
                empSal = int.Parse(txtEmployeeSalary.Text),
                empAddress = txtEmployeeAddress.Text,
                empDesignation = txtEmployeeDesignation.Text
                

            };
            int result = employeeDal.InsertEmployee(employee);
            if (result > 0)
            {
                EmployeeList = employeeDal.GetAllEmployees();

            }
        }

        private void btn_Update_Employee_Details_Click_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                empId = int.Parse(txtEmployeeID.Text),
                empName = txtEmployeeName.Text,
                empSal = int.Parse(txtEmployeeSalary.Text),
                empAddress = txtEmployeeAddress.Text,
                empDesignation = txtEmployeeDesignation.Text

            };
            int result = employeeDal.UpdateEmployee(employee);
            if (result > 0)
            {
                EmployeeList = employeeDal.GetAllEmployees();
            }
        }

        private void btn_Delete_Employee_Click_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee()
            {
                empId = int.Parse(txtEmployeeID.Text),
                empName = txtEmployeeName.Text,
                empSal = int.Parse(txtEmployeeSalary.Text),
                empAddress = txtEmployeeAddress.Text,
                empDesignation = txtEmployeeDesignation.Text


            };
            int result = employeeDal.DeleteEmployee(employee);
            if (result > 0)
            {
                EmployeeList = employeeDal.GetAllEmployees();
            }
        }
    }
}
