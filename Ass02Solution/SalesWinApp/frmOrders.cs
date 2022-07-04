﻿using System;
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
                    source.DataSource = orders.OrderBy(product => product.OrderDate);
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
                    dgvOrderList.Columns["Products"].Visible = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmUpdateOrder frmUpdateOrder = new frmUpdateOrder
            {
                Text = "Add Order",
                Frm = this
            };
            frmUpdateOrder.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadOrderList(orderRepository.GetAllOrder());
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    MessageBox.Show(ex.Message, "Delete a order Error");
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
