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
    public partial class frmOrders : Form
    {
        public bool isAdmin { get; set; }
        public Member loginUser { get; set; }
        private IEnumerable<Order>? orders;

        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;

        public frmOrders()
        {
            InitializeComponent();
        }
        private Order GetCurrentOrderInDgv()
        {
            try
            {
                int Id = int.Parse(txtOrderID.Text.Trim());
                return orderRepository.GetOrderByID(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please choose at least one Order Row");
            }
            return new Order();
        }
        public void LoadOrderList(IEnumerable<Order> orders)
        {
            if (orders.Count() != 0)
            {
                try
                {
                    source = new BindingSource();
                    source.DataSource = orders;
                    txtOrderID.DataBindings.Clear();
                    txtMemberID.DataBindings.Clear();
                    txtOrderDate.DataBindings.Clear();
                    txtRequiredDate.DataBindings.Clear();
                    txtShippedDate.DataBindings.Clear();
                    txtFreight.DataBindings.Clear();
                    txtOrderID.DataBindings.Add("Text", source, "Id");
                    txtMemberID.DataBindings.Add("Text", source, "MemberId");
                    txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                    txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                    txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                    txtFreight.DataBindings.Add("Text", source, "Freight");
                    dgvOrderList.DataSource = source;
                    dgvOrderList.Columns["OrderDetails"].Visible = false;
                    dgvOrderList.Columns["Member"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load Order list");
                }
            }
            else
            {
                dgvOrderList.Rows.Clear();
            }

        }

        private void btnUpdate_click(object sender, EventArgs e)
        {
            if (loginUser != null)
            {
                
            }
            else
            {
                if (dgvOrderList.Rows.Count != 0)
                {
                    frmUpdateOrder frmUpdateOrder = new frmUpdateOrder
                    {
                        Text = "Update Order",
                        Frm = this,
                        OrderInfo = GetCurrentOrderInDgv()
                    };
                    frmUpdateOrder.ShowDialog();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (loginUser != null)
            {
                
            }
            else
            {
                frmUpdateOrder frmUpdateOrder = new frmUpdateOrder
                {
                    Text = "Add New Order",
                    Frm = this
                };
                frmUpdateOrder.ShowDialog();
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetAllOrder());
            if (loginUser != null)
            {
                btnDelete.Visible = false;
                LoadOrderList(orderRepository.GetByMemberId(loginUser.Id));
            }
            else LoadOrderList(orderRepository.GetAllOrder());

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetAllOrder());
            if (loginUser != null)
            {
                btnDelete.Visible = false;
                LoadOrderList(orderRepository.GetByMemberId(loginUser.Id));
            }
            else LoadOrderList(orderRepository.GetAllOrder());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (loginUser != null)
            {
                btnDelete.Visible = false;
            }
            else
            {
                if (dgvOrderList.Rows.Count != 0)
                {
                    try
                    {
                        var product = GetCurrentOrderInDgv();
                        orderRepository.DeleteOrder(product);
                        LoadOrderList(orderRepository.GetAllOrder());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Delete a Order Error");
                    }
                }
            }
        }
        private IEnumerable<Order> AllOrderInForm()
        {
            return loginUser == null ? orderRepository.GetAllOrder() : orderRepository.GetAllOfMember(loginUser.Id);
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                frmOrderDetails frm = new frmOrderDetails()
                {
                    OrderInfo = orderRepository.GetOrderByID(Int32.Parse(txtOrderID.Text)),
                    loginUser = loginUser
                };
                frm.Show();
                frm.FormClosed += delegate
                {
                    orders = AllOrderInForm();
                    LoadOrderList(orders);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnSort_Click(object sender, EventArgs e)
        {
            orders = orderRepository.SortDescByDate();
            LoadOrderList(orders);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = txtStartDate.Value;
            DateTime endDate = txtEndDate.Value;
            orders = orderRepository.FilterByDate(startDate, endDate);
            LoadOrderList(orders);
            txtStartDate.Value = startDate;
            txtEndDate.Value = endDate;
        }
    }
}
