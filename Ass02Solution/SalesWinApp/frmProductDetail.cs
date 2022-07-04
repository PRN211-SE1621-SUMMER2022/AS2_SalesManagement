using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public Product ProductInfor { get; set; }
        ProductRepository productRepository = new ProductRepository();
        public frmProducts Frm { get; set; }
        public frmProductDetail() => InitializeComponent();

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Add product"))
            {
                try
                {
                    int productID = int.Parse(txtProductID.Text);
                    if (productRepository.GetProductById(productID) == null)
                    {
                        var product = new Product
                        {
                            Id = productID,
                            CategoryId = int.Parse(txtCategoryID.Text.Trim()),
                            ProductName = txtProductName.Text,
                            Weight = txtWeight.Text,
                            UnitPrice =decimal.Parse(txtUnitPrice.Text.Trim()),
                            UnitsInStock = int.Parse(txtUnitsInStock.Text.Trim()),
                        };
                        productRepository.InsertProduct(product);
                        MessageBox.Show("Add new product successfully!");
                        this.Hide();
                        Frm.LoadProductList(productRepository.GetAllProduct());
                    }
                    else
                    {
                        MessageBox.Show("Duplicated productID!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add new product fail!");
                }
            }
            else
            {
                try
                {
                    this.ProductInfor.CategoryId = int.Parse(txtCategoryID.Text.Trim());
                    this.ProductInfor.ProductName = txtProductName.Text;
                    this.ProductInfor.Weight = txtWeight.Text;
                    this.ProductInfor.UnitPrice = decimal.Parse(txtUnitPrice.Text.Trim());
                    this.ProductInfor.UnitsInStock = int.Parse(txtUnitsInStock.Text.Trim());
                    productRepository.UpdateProduct(this.ProductInfor);
                    MessageBox.Show("Update product successfully!");
                    this.Hide();
                    Frm.LoadProductList(productRepository.GetAllProduct());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update product fail!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!this.Text.Equals("Update product"))
            {
                txtProductID.Text = "";
            }
            txtCategoryID.Text = "";
            txtProductName.Text = "";
            txtWeight.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Update product"))
            {
                txtProductID.Text = this.ProductInfor.Id.ToString();
                txtProductID.Enabled = false;
                txtCategoryID.Text = this.ProductInfor.CategoryId.ToString();
                txtProductName.Text = this.ProductInfor.ProductName.ToString();
                txtWeight.Text = this.ProductInfor.Weight.ToString();
                txtUnitPrice.Text = this.ProductInfor.UnitPrice.ToString();
                txtUnitsInStock.Text = this.ProductInfor.UnitsInStock.ToString();
            }
        }
    }
}
