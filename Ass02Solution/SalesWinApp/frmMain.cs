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

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool isAdmin { get; set; }
        public Member loginUser { get; set; }
        public frmMain()
        {
            InitializeComponent();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers() { isAdmin = this.isAdmin, loginUser = this.loginUser};
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts frm = new frmProducts() { isAdmin = this.isAdmin, loginUser = this.loginUser };
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders() { isAdmin = this.isAdmin, loginUser = this.loginUser };
            frm.MdiParent = this;
            frm.Show();
            frm.Activate();
        }
    }
}
