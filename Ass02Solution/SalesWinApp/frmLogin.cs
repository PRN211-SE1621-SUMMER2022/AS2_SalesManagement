using BusinessObject.Models;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (memberRepository.CheckLoginFromAccountInFile(email, password))
            {
                frmMain frmMain = new frmMain()
                {
                    isAdmin = true
                };
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                Member? loginUser = memberRepository.CheckLogin(email, password);
                if (loginUser != null)
                {
                    frmMain frmMain = new frmMain()
                    {
                        loginUser = loginUser
                    };
                    this.Hide();
                    frmMain.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password, please try again!", "Login fail");
                }
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
        }
    }
}