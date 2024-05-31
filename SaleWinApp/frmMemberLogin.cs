using BusinessObject;
using Microsoft.Extensions.Configuration;
using SaleWinApp;
namespace SaleWinApp
{
    public partial class frmMemberLogin : Form
    {

        public frmMemberLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            this.CancelButton = btnClose;

        }

        public List<Member> memberList;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Member m = MemberDAO.Instance.GetMemberLogin(email, password);
            if (m != null)
            {
                frmAdminHome frmManage = new frmAdminHome(m.MemberId);
                this.Hide();
                frmManage.ShowDialog();

            }
            else
            {
                MessageBox.Show("Login fail! Please check email or password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
