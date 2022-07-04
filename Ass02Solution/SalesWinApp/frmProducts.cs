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
    public partial class frmProducts : Form
    {
        public bool isAdmin { get; set; }
        public Member loginUser { get; set; }
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        public frmProducts()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProductList.Rows.Count != 0)
            {
                frmProductDetail frmProductDetail = new frmProductDetail
                {
                    Text = "Update product",
                    Frm = this,
                    ProductInfor = GetCurrentProductInDgv()
                };
                frmProductDetail.ShowDialog();
            }
        }
        public void LoadProductList(IEnumerable<Product> products)
        {
            if (products.Count() != 0)
            {
                try
                {
                    source = new BindingSource();
                    source.DataSource = products.OrderBy(product => product.ProductName);
                    txtProductID.DataBindings.Clear();
                    txtCategoryID.DataBindings.Clear();
                    txtProductName.DataBindings.Clear();
                    txtWeight.DataBindings.Clear();
                    txtUnitPrice.DataBindings.Clear();
                    txtUnitsInStock.DataBindings.Clear();
                    txtProductID.DataBindings.Add("Text", source, "Id");
                    txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                    txtProductName.DataBindings.Add("Text", source, "ProductName");
                    txtWeight.DataBindings.Add("Text", source, "Weight");
                    txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                    txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                    dgvProductList.DataSource = source;
                    dgvProductList.Columns["Orders"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load product list");
                }
            }
            else
            {
                dgvProductList.Rows.Clear();
            }

        }

        private Product GetCurrentProductInDgv()
        {
            try
            {
                int Id = int.Parse(txtProductID.Text.Trim());
                return productRepository.GetProductById(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product Error");
            }
            return new Product();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList(productRepository.GetAllProduct());
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList(productRepository.GetAllProduct());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProductList.Rows.Count!=0)
            {
                try
                {
                    var product = GetCurrentProductInDgv();
                    productRepository.RemoveProduct(product);
                    LoadProductList(productRepository.GetAllProduct());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a product Error");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Add product",
                Frm = this
            };
            frmProductDetail.ShowDialog();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            LoadProductList(productRepository.GetProductByName(txtSearchByName.Text.Trim()));
        }

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            String searchID = txtSearchByID.Text.Trim();
            if (searchID == null)
            {
                LoadProductList(productRepository.GetAllProduct());
            }
            else
            {
                try
                {
                    var product = productRepository.GetProductById(int.Parse(searchID)); ;
                    if (product == null)
                    {
                        dgvProductList.Rows.Clear();
                    }
                    else
                    {
                        List<Product> lst = new List<Product>();
                        lst.Add(product);
                        LoadProductList(lst);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Invalid productID!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchByID.Text = "";
            txtSearchByName.Text = "";
        }
    }
}
