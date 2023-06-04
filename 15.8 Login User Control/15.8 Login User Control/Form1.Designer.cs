namespace _15._8_Login_User_Control

{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPasswordUserControl1 = new _15._8_Login_User_Control.LoginPasswordUserControl();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_userLogin = new System.Windows.Forms.Label();
            this.lbl_userPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginPasswordUserControl1
            // 
            this.loginPasswordUserControl1.Location = new System.Drawing.Point(12, 12);
            this.loginPasswordUserControl1.Name = "loginPasswordUserControl1";
            this.loginPasswordUserControl1.Size = new System.Drawing.Size(193, 111);
            this.loginPasswordUserControl1.TabIndex = 0;
            this.loginPasswordUserControl1.Load += new System.EventHandler(this.loginPasswordUserControl1_Load);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(72, 172);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 23);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Users Credentials ";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_userLogin
            // 
            this.lbl_userLogin.AutoSize = true;
            this.lbl_userLogin.Location = new System.Drawing.Point(98, 209);
            this.lbl_userLogin.Name = "lbl_userLogin";
            this.lbl_userLogin.Size = new System.Drawing.Size(40, 15);
            this.lbl_userLogin.TabIndex = 2;
            this.lbl_userLogin.Text = "Login:";
            // 
            // lbl_userPassword
            // 
            this.lbl_userPassword.AutoSize = true;
            this.lbl_userPassword.Location = new System.Drawing.Point(98, 255);
            this.lbl_userPassword.Name = "lbl_userPassword";
            this.lbl_userPassword.Size = new System.Drawing.Size(60, 15);
            this.lbl_userPassword.TabIndex = 3;
            this.lbl_userPassword.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 311);
            this.Controls.Add(this.lbl_userPassword);
            this.Controls.Add(this.lbl_userLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.loginPasswordUserControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginPasswordUserControl loginPasswordUserControl1;
        private Button btn_Login;
        private Label lbl_userLogin;
        private Label lbl_userPassword;
    }
}