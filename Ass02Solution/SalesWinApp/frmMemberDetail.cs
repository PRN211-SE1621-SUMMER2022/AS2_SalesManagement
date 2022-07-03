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
    public partial class frmMemberDetail : Form
    {
        public Member MemberInfor { get; set; }
        MemberRepository memberRepository = new MemberRepository();
        public frmMembers Frm { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.Text.Equals("Add member"))
            {
                try
                {
                    int memberID = int.Parse(txtMemberID.Text);
                    if (memberRepository.GetMemberByID(memberID) == null)
                    {
                        var member = new Member
                        {
                            Id = memberID,
                            CompanyName = txtCompanyName.Text,
                            City = txtCity.Text,
                            Email = txtEmail.Text,
                            Country = txtCountry.Text,
                            Password = txtPassword.Text,
                        };
                        memberRepository.AddMember(member);
                        MessageBox.Show("Add new member successfully!");
                        this.Hide();
                        Frm.LoadMemberList();
                    }
                    else
                    {
                        MessageBox.Show("Duplicated memberID!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add new member fail!");
                }
            }
            else
            {
                try
                {
                    this.MemberInfor.CompanyName = txtCompanyName.Text;
                    this.MemberInfor.City = txtCity.Text;
                    this.MemberInfor.Email = txtEmail.Text;
                    this.MemberInfor.Country = txtCountry.Text;
                    this.MemberInfor.Password = txtPassword.Text;
                    memberRepository.UpdateMember(this.MemberInfor);
                    MessageBox.Show("Update member successfully!");
                    this.Hide();
                    Frm.LoadMemberList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Update member fail!");
                }
            }
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if (this.Text.Equals("Update member"))
            {
                txtMemberID.Text = this.MemberInfor.Id.ToString();
                txtMemberID.Enabled = false;
                txtCompanyName.Text = this.MemberInfor.CompanyName.ToString();
                txtEmail.Text = this.MemberInfor.Email.ToString();
                txtCountry.Text = this.MemberInfor.Country.ToString();
                txtCity.Text = this.MemberInfor.City.ToString();
                txtPassword.Text = this.MemberInfor.Password.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!this.Text.Equals("Update member"))
            {
                txtMemberID.Text = "";
            }
            txtCompanyName.Text = "";
            txtEmail.Text = "";
            txtCountry.Text = "";
            txtCity.Text = "";
            txtPassword.Text = "";
        }
    }
}
