namespace GUI
{
    partial class F_DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DangNhap));
            this.Panel_Left = new Guna.UI2.WinForms.Guna2Panel();
            this.BodyPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_matkhau = new System.Windows.Forms.LinkLabel();
            this.btn_DangKy = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_account = new Guna.UI2.WinForms.Guna2TextBox();
            this.Banner = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Panel_Left.SuspendLayout();
            this.BodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.Controls.Add(this.Banner);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(395, 511);
            this.Panel_Left.TabIndex = 5;
            // 
            // BodyPanel
            // 
            this.BodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BodyPanel.Controls.Add(this.lb_matkhau);
            this.BodyPanel.Controls.Add(this.btn_DangKy);
            this.BodyPanel.Controls.Add(this.label3);
            this.BodyPanel.Controls.Add(this.btn_DangNhap);
            this.BodyPanel.Controls.Add(this.txt_password);
            this.BodyPanel.Controls.Add(this.txt_account);
            this.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BodyPanel.FillColor = System.Drawing.Color.Transparent;
            this.BodyPanel.Location = new System.Drawing.Point(395, 0);
            this.BodyPanel.Name = "BodyPanel";
            this.BodyPanel.Size = new System.Drawing.Size(477, 511);
            this.BodyPanel.TabIndex = 6;
            // 
            // lb_matkhau
            // 
            this.lb_matkhau.AutoSize = true;
            this.lb_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matkhau.LinkArea = new System.Windows.Forms.LinkArea(0, 15);
            this.lb_matkhau.LinkColor = System.Drawing.Color.Black;
            this.lb_matkhau.Location = new System.Drawing.Point(242, 345);
            this.lb_matkhau.Name = "lb_matkhau";
            this.lb_matkhau.Size = new System.Drawing.Size(133, 24);
            this.lb_matkhau.TabIndex = 15;
            this.lb_matkhau.TabStop = true;
            this.lb_matkhau.Text = "Quên mật khẩu?";
            this.lb_matkhau.UseCompatibleTextRendering = true;
            this.lb_matkhau.Click += new System.EventHandler(this.QuenMatKhau_Click);
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
            this.btn_DangKy.Location = new System.Drawing.Point(265, 409);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(172, 50);
            this.btn_DangKy.TabIndex = 12;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "ĐĂNG NHẬP";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.BorderRadius = 20;
            this.btn_DangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_DangNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_DangNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(47, 409);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(172, 50);
            this.btn_DangNhap.TabIndex = 9;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.txt_password.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_password.IconLeft")));
            this.txt_password.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_password.IconRight = ((System.Drawing.Image)(resources.GetObject("txt_password.IconRight")));
            this.txt_password.IconRightSize = new System.Drawing.Size(30, 30);
            this.txt_password.Location = new System.Drawing.Point(91, 283);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_password.PlaceholderText = "Mật khẩu";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(284, 48);
            this.txt_password.TabIndex = 8;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.IconRightClick += new System.EventHandler(this.Icon_password_right);
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
            this.txt_account.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_account.IconLeft")));
            this.txt_account.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txt_account.Location = new System.Drawing.Point(91, 210);
            this.txt_account.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_account.Name = "txt_account";
            this.txt_account.PasswordChar = '\0';
            this.txt_account.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_account.PlaceholderText = "Tài khoản";
            this.txt_account.SelectedText = "";
            this.txt_account.Size = new System.Drawing.Size(284, 48);
            this.txt_account.TabIndex = 7;
            // 
            // Banner
            // 
            this.Banner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Banner.Image = global::GUI.Properties.Resources._7;
            this.Banner.ImageRotate = 0F;
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(395, 511);
            this.Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Banner.TabIndex = 0;
            this.Banner.TabStop = false;
            // 
            // F_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 511);
            this.Controls.Add(this.BodyPanel);
            this.Controls.Add(this.Panel_Left);
            this.Name = "F_DangNhap";
            this.Text = "F_DangNhap";
            this.Panel_Left.ResumeLayout(false);
            this.BodyPanel.ResumeLayout(false);
            this.BodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel_Left;
        private Guna.UI2.WinForms.Guna2Panel BodyPanel;
        private Guna.UI2.WinForms.Guna2Button btn_DangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_account;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_DangKy;
        private System.Windows.Forms.LinkLabel lb_matkhau;
        private Guna.UI2.WinForms.Guna2PictureBox Banner;

        private System.Windows.Forms.Timer Timer;
    }
}