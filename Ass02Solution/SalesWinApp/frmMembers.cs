using BusinessObject.Models;
using DataAccess;
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
    public partial class frmMembers : Form
    {
        public bool isAdmin { get; set; }
        public Member loginUser { get; set; }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;

        public frmMembers() => InitializeComponent();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMembers_Load(object sender, EventArgs e) => LoadMemberList();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
        public void LoadMemberList()
        {
            var members = memberRepository.GetAllMember();
            if (members.Count()!=0)
            {
                try
                {
                    source = new BindingSource();
                    if (isAdmin == false)
                    {
                        Member? member = members.SingleOrDefault(m => m.Id == loginUser.Id);
                        source.DataSource = member;
                    }
                    else
                    {
                        source.DataSource = members.OrderBy(member => member.Id);
                    }
                    txtMemberID.DataBindings.Clear();
                    txtCompanyName.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtCountry.DataBindings.Clear();
                    txtCity.DataBindings.Clear();
                    txtMemberID.DataBindings.Add("Text", source, "Id");
                    txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                    txtPassword.DataBindings.Add("Text", source, "Password");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    txtCountry.DataBindings.Add("Text", source, "Country");
                    txtCity.DataBindings.Add("Text", source, "City");

                    dgvMemberList.DataSource = source;
                    dgvMemberList.Columns["Orders"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load member list");
                }
            }
            else
            {
                dgvMemberList.Rows.Clear();
            }

        }
        private Member GetCurrentMemberInDgv()
        {
            try
            {
                int Id = int.Parse(txtMemberID.Text.Trim());
                return memberRepository.GetMemberByID(Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member Error");
            }
            return new Member();
        }

        private void dgvMemberList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMemberList.Columns[e.ColumnIndex].Index == 5 && e.Value != null)
            {
                dgvMemberList.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMemberList.Rows.Count != 0)
            {
                try
                {
                    var member = GetCurrentMemberInDgv();
                    memberRepository.DeleteMember(member);
                    LoadMemberList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete a member Error");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add member",
                Frm = this
            };
            frmMemberDetail.ShowDialog();
        }

        private void btnUpdateClick(object sender, EventArgs e)
        {
            if (dgvMemberList.Rows.Count!=0)
            {
                frmMemberDetail frmMemberDetail = new frmMemberDetail
                {
                    Text = "Update member",
                    Frm = this,
                    MemberInfor = GetCurrentMemberInDgv()
                };
                frmMemberDetail.ShowDialog();
            }
        }

        private void dgvMemberList_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
