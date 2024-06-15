namespace GUI
{
    partial class F_DangKy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_DangKy = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirmpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_backLogin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_account = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Gmail = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_backLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BorderRadius = 20;
            this.btn_DangKy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangKy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangKy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangKy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangKy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DangKy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.Black;
            this.btn_DangKy.Location = new System.Drawing.Point(150, 412);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(172, 50);
            this.btn_DangKy.TabIndex = 13;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Đăng ký tài khoản";
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.BorderRadius = 20;
            this.txt_confirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirmpassword.DefaultText = "";
            this.txt_confirmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confirmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmpassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmpassword.IconRight = global::GUI.Properties.Resources.xrilcb7p;
            this.txt_confirmpassword.Location = new System.Drawing.Point(96, 357);
            this.txt_confirmpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.PasswordChar = '●';
            this.txt_confirmpassword.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_confirmpassword.PlaceholderText = "Nhập lại mật khẩu";
            this.txt_confirmpassword.SelectedText = "";
            this.txt_confirmpassword.Size = new System.Drawing.Size(284, 48);
            this.txt_confirmpassword.TabIndex = 3;
            this.txt_confirmpassword.UseSystemPasswordChar = true;
            this.txt_confirmpassword.IconRightClick += new System.EventHandler(this.icon_cfpass_Clicked);
            // 
            // btn_backLogin
            // 
            this.btn_backLogin.Image = global::GUI.Properties.Resources.arrow_back_circle_icon;
            this.btn_backLogin.ImageRotate = 0F;
            this.btn_backLogin.Location = new System.Drawing.Point(0, -2);
            this.btn_backLogin.Name = "btn_backLogin";
            this.btn_backLogin.Size = new System.Drawing.Size(48, 48);
            this.btn_backLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_backLogin.TabIndex = 20;
            this.btn_backLogin.TabStop = false;
            this.btn_backLogin.Click += new System.EventHandler(this.btn_backLogin_Click);
            // 
            // txt_username
            // 
            this.txt_username.BorderRadius = 20;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.IconLeft = global::GUI.Properties.Resources.Users_Name_icon;
            this.txt_username.Location = new System.Drawing.Point(96, 133);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_username.PlaceholderText = "Họ và tên";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(284, 48);
            this.txt_username.TabIndex = 19;
            // 
            // txt_password
            // 
            this.txt_password.BorderRadius = 20;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.IconLeft = global::GUI.Properties.Resources.Security_Password_2_icon;
            this.txt_password.IconRight = global::GUI.Properties.Resources.xrilcb7p1;
            this.txt_password.Location = new System.Drawing.Point(96, 301);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_password.PlaceholderText = "Nhập mật khẩu";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(284, 48);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.IconRightClick += new System.EventHandler(this.Icon_pass_right_Clicked);
            // 
            // txt_account
            // 
            this.txt_account.BorderRadius = 20;
            this.txt_account.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_account.DefaultText = "";
            this.txt_account.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_account.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_account.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_account.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_account.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_account.IconLeft = global::GUI.Properties.Resources.account_box_icon;
            this.txt_account.Location = new System.Drawing.Point(96, 245);
            this.txt_account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_account.Name = "txt_account";
            this.txt_account.PasswordChar = '\0';
            this.txt_account.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_account.PlaceholderText = "Nhập tài khoản";
            this.txt_account.SelectedText = "";
            this.txt_account.Size = new System.Drawing.Size(284, 48);
            this.txt_account.TabIndex = 1;
            // 
            // txt_Gmail
            // 
            this.txt_Gmail.BorderRadius = 20;
            this.txt_Gmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Gmail.DefaultText = "";
            this.txt_Gmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Gmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Gmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Gmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Gmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Gmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Gmail.IconLeft = global::GUI.Properties.Resources.gmail_icon;
            this.txt_Gmail.Location = new System.Drawing.Point(96, 189);
            this.txt_Gmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Gmail.Name = "txt_Gmail";
            this.txt_Gmail.PasswordChar = '\0';
            this.txt_Gmail.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_Gmail.PlaceholderText = " Nhập Gmail";
            this.txt_Gmail.SelectedText = "";
            this.txt_Gmail.Size = new System.Drawing.Size(284, 48);
            this.txt_Gmail.TabIndex = 0;
            // 
            // F_DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(464, 474);
            this.Controls.Add(this.btn_backLogin);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_confirmpassword);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.txt_Gmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_DangKy";
            this.Text = "F_DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.btn_backLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_Gmail;
        private Guna.UI2.WinForms.Guna2TextBox txt_account;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_confirmpassword;
        private Guna.UI2.WinForms.Guna2Button btn_DangKy;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2PictureBox btn_backLogin;
    }
}