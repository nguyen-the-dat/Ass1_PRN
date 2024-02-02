
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        string email;
        string pass;
        IMemberRepository memRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
            InitializeComponent();
        }
        private void CLear()
        {
            tbMail.Text = string.Empty;
            tbPass.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (email != null && pass != null && email.Equals(tbMail.Text.ToString()) && pass.Equals(tbPass.Text.ToString()))
            {
                this.Hide();
                frmMemberManager form2 = new frmMemberManager();
                form2.ShowDialog();
                this.Close();
            }else if(memRepository.CheckMember(tbMail.Text.ToString(), tbPass.Text.ToString()) !=null  )
            {
                this.email = "";this.pass = "";
                this.email = tbMail.Text.ToString();
                this.pass = tbPass.Text.ToString();
                this.Hide();
                frmUpdate form3 = new frmUpdate(memRepository.CheckMember(email, pass));
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                lbRes.Text = "Email or password is incorrect!";
                lbRes.ForeColor = Color.Red;
                CLear();
            }

        }

        private void lbCLear_Click(object sender, EventArgs e)
        {
            CLear();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbMail.Text = "admin@fstore.com";
            tbPass.Text = "admin@@";
        }
    }
}
