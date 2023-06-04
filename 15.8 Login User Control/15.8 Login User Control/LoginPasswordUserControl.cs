using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _15._8_Login_User_Control
{

    public partial class LoginPasswordUserControl : UserControl
    {


        public LoginPasswordUserControl()
        {
            InitializeComponent();
        }
        //variables for login and password
        public static string userLogin = "";
        public static string password = "";
        
        //update password to currently input
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            password = passwordTextBox.Text;
        }

        //update login to currently input
        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            userLogin = loginTextBox.Text;
        }

    }
}
