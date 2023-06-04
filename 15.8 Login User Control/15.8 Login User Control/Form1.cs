using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;

namespace _15._8_Login_User_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Update user credentials from user login and password
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Login
            lbl_userLogin.Text = "Login: " + LoginPasswordUserControl.userLogin;
            //Password
            lbl_userPassword.Text = "Password: " + LoginPasswordUserControl.password;
        }

        private void loginPasswordUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}