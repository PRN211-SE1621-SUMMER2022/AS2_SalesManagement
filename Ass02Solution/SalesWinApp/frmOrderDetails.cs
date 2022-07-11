using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderDetails : Form
    {
        public bool isAdmin { get; set; }
        public Member loginUser { get; set; }

        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private OrderDetail GetCurrentOrderInDgv()
        {
            try
            {
                int OrderId = int.Parse(txtOrderID.Text.Trim());
                int ProductId = int.Parse(txtProductID.Text.Trim());
                return orderDetailRepository.GetOrderDetailByID(OrderId,ProductId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please choose at least one line");
            }
            return new OrderDetail();
        }

        public void LoadOrderDetailList(IEnumerable<OrderDetail> orders)
        {
            if (orders.Count() != 0)
            {
                try
                {
                    source = new BindingSource();
                    source.DataSource = orders.OrderBy(product => product.ProductId);
                    txtOrderID.DataBindings.Clear();
                    txtProductID.DataBindings.Clear();
                    txtUnitPrice.DataBindings.Clear();
                    txtQuantity.DataBindings.Clear();
                    txtDiscount.DataBindings.Clear();
                    txtOrderID.DataBindings.Add("Text", source, "OrderId");
                    txtProductID.DataBindings.Add("Text", source, "ProductId");
                    txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                    txtQuantity.DataBindings.Add("Text", source, "Quantity");
                    txtDiscount.DataBindings.Add("Text", source, "Discount");
                    dgvOrderDetail.DataSource = source;
                    dgvOrderDetail.Columns["Order"].Visible = false;
                    dgvOrderDetail.Columns["Product"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load OrderDetail list");
                }
            }
            else
            {
                dgvOrderDetail.Rows.Clear();
            }
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            LoadOrderDetailList(orderDetailRepository.GetAllOrderDetail());
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
