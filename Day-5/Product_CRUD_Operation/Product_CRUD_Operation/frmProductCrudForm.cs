using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product_CRUD_Operation.Dal;
using Product_CRUD_Operation.Model;


namespace Product_CRUD_Operation
{
    public partial class frmProductCrudForm : Form
    {
        public frmProductCrudForm()
        {
            InitializeComponent();
        }

        ProductDal productDal = new ProductDal();
        int index = 0;

        List<Product> ProductList;

        private void frmProductCrudForm_Load(object sender, EventArgs e)
        {
            ProductList = productDal.GetAllProducts();
            Navigate(index);
        }

        private void Navigate(int currentIndex)
        {
            if (ProductList.Count > 0)
            {
                txtProductID.Text = ProductList[currentIndex].productID.ToString();
                txtProductName.Text = ProductList[currentIndex].productName;
                txtProductPrice.Text = ProductList[currentIndex].productPrice.ToString();
                txtProductCompany.Text = ProductList[currentIndex].productCompany;
                txtProductRating.Text = ProductList[currentIndex].productRating.ToString();

            }
        }

        private void btn_MoveFirst_Click(object sender, EventArgs e)
        {
            index = 0;
            Navigate(index);
        }

        private void btn_MoveLast_Click(object sender, EventArgs e)
        {
            index = ProductList.Count - 1;
            Navigate(index);
        }

        private void btn_MovePervious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                Navigate(index);
            }
        }

        private void btn_MoveNext_Click(object sender, EventArgs e)
        {
            if (index < ProductList.Count - 1)
            {
                index++;
                Navigate(index);
            }
        }

        private void btn_NewProduct_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductPrice.Text = string.Empty;
            txtProductCompany.Text = string.Empty;
            txtProductRating.Text = string.Empty;
            txtProductID.Focus();
        }

        private void btn_SaveProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                productID = int.Parse(txtProductID.Text),
                productName = txtProductName.Text,
                productPrice = decimal.Parse(txtProductPrice.Text),
                productCompany = txtProductCompany.Text,
               productRating = decimal.Parse(txtProductRating.Text)


            };
            int result = productDal.InsertProduct(product);
            if (result > 0)
            {
                ProductList = productDal.GetAllProducts();

            }
        }

        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                productID = int.Parse(txtProductID.Text),
                productName = txtProductName.Text,
                productPrice = decimal.Parse(txtProductPrice.Text),
                productCompany = txtProductCompany.Text,
                productRating = decimal.Parse(txtProductRating.Text)

            };
            int result = productDal.UpdateProduct(product);
            if (result > 0)
            {
                ProductList = productDal.GetAllProducts();

            }
        }

        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {

            Product product = new Product()
            {
                productID = int.Parse(txtProductID.Text),
                productName = txtProductName.Text,
                productPrice = decimal.Parse(txtProductPrice.Text),
                productCompany = txtProductCompany.Text,
                productRating = decimal.Parse(txtProductRating.Text)

            };
            int result = productDal.DeleteEmployee(product);
            if (result > 0)
            {
                ProductList = productDal.GetAllProducts();

            }

        }
    }
}
