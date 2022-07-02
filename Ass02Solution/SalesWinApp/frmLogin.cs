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
            if(memberRepository.CheckLoginFromAccountInFile(email,password))
            {   
                frmMain frmMain = new frmMain(); ;
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else if (memberRepository.CheckLogin(email , password))
            {
                frmMain frmMain = new frmMain(); ;
                this.Hide();
                frmMain.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong email or pass word, please try again", "Wrong user");
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}