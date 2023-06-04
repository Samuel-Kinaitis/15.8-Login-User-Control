namespace _15._8_Login_User_Control
{
    partial class LoginPasswordUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLabel1 = new System.Windows.Forms.Label();
            this.passwordLabel1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLabel1
            // 
            this.loginLabel1.AutoSize = true;
            this.loginLabel1.Location = new System.Drawing.Point(31, 20);
            this.loginLabel1.Name = "loginLabel1";
            this.loginLabel1.Size = new System.Drawing.Size(40, 15);
            this.loginLabel1.TabIndex = 0;
            this.loginLabel1.Text = "Login:";
            // 
            // passwordLabel1
            // 
            this.passwordLabel1.AutoSize = true;
            this.passwordLabel1.Location = new System.Drawing.Point(11, 70);
            this.passwordLabel1.Name = "passwordLabel1";
            this.passwordLabel1.Size = new System.Drawing.Size(60, 15);
            this.passwordLabel1.TabIndex = 1;
            this.passwordLabel1.Text = "Password:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(77, 17);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 23);
            this.loginTextBox.TabIndex = 2;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(77, 70);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 23);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // LoginPasswordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel1);
            this.Controls.Add(this.loginLabel1);
            this.Name = "LoginPasswordUserControl";
            this.Size = new System.Drawing.Size(235, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLabel1;
        private Label passwordLabel1;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
    }
}
