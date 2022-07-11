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
    public partial class frmUpdateOrder : Form
    {
        public Order OrderInfo { get; set; }
        OrderRepository orderRepository = new OrderRepository();
        public Member loginUser { get; set; }
        public frmOrders Frm { get; set; }  
        public frmUpdateOrder() => InitializeComponent();
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Add New Order"))
            {
                try
                {
                    int orderID = int.Parse(txtOrderID.Text);
                    if (orderRepository.GetOrderByID(orderID) == null)
                    {
                        var order = new Order
                        {
                            Id = orderID,
                            MemberId = int.Parse(txtMemberID.Text),
                            OrderDate = Convert.ToDateTime(txtOrderDate.Value),
                            RequiredDate = Convert.ToDateTime(txtRequiredDate.Value),
                            ShippedDate = Convert.ToDateTime(txtShippedDate.Value),
                            Freight = decimal.Parse(txtFreight.Text),
                        };
                        orderRepository.InsertOrder(order);
                        MessageBox.Show("Add new order successfully!");
                        this.Hide();
                        Frm.LoadOrderList(orderRepository.GetAllOrder());
                    }
                    else
                    {
                        MessageBox.Show("Duplicated OrderID!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add new order fail!");
                }
            }
            else
            {
                try
                {
                    this.OrderInfo.MemberId = int.Parse(txtMemberID.Text);
                    this.OrderInfo.OrderDate = txtOrderDate.Value;
                    this.OrderInfo.RequiredDate = txtRequiredDate.Value;
                    this.OrderInfo.ShippedDate = txtShippedDate.Value;
                    this.OrderInfo.Freight = decimal.Parse(txtFreight.Text);
                    orderRepository.UpdateOrder(this.OrderInfo);
                    MessageBox.Show("Update order successfully!");
                    this.Hide();
                    Frm.LoadOrderList(orderRepository.GetAllOrder());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update Order fail!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            {
                if (!this.Text.Equals("Update Order"))
                {
                    txtOrderID.Text = "";
                }
                txtMemberID.Text = "";
                txtOrderDate.Text = "";
                txtRequiredDate.Text = "";
                txtShippedDate.Text = "";
                txtFreight.Text = "";
            }
        }
        private void frmUploadOrders_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Update Order"))
            {
                txtOrderID.Text = this.OrderInfo.Id.ToString();
                txtOrderID.Enabled = false;
                txtMemberID.Text = this.OrderInfo.MemberId.ToString();
                txtOrderDate.Text = this.OrderInfo.OrderDate.ToString();
                txtRequiredDate.Text = this.OrderInfo.RequiredDate.ToString();
                txtShippedDate.Text = this.OrderInfo.ShippedDate.ToString();
                txtFreight.Text = this.OrderInfo.Freight.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}
