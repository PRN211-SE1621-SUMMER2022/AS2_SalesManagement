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
        public frmOrders Frm { get; set; }  
        public frmUpdateOrder() => InitializeComponent();
        

        private void btnSave_Click(object sender, EventArgs e)
        {

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
