namespace GUI.ViewAdmin
{
    partial class F_Main_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main_Admin));
            this.Left_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_ThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Thoat = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SuCo = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Voucher = new Guna.UI2.WinForms.Guna2Button();
            this.btn_NhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Phim = new Guna.UI2.WinForms.Guna2Button();
            this.Avatar_Cinema = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Body_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Left_Panel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar_Cinema)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.Controls.Add(this.guna2Panel2);
            this.Left_Panel.Controls.Add(this.Avatar_Cinema);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(200, 717);
            this.Left_Panel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btn_ThongTin);
            this.guna2Panel2.Controls.Add(this.btn_Thoat);
            this.guna2Panel2.Controls.Add(this.btn_SuCo);
            this.guna2Panel2.Controls.Add(this.btn_Voucher);
            this.guna2Panel2.Controls.Add(this.btn_NhanVien);
            this.guna2Panel2.Controls.Add(this.btn_Phim);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 177);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(200, 540);
            this.guna2Panel2.TabIndex = 2;
            // 
            // btn_ThongTin
            // 
            this.btn_ThongTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongTin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ThongTin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_ThongTin.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongTin.ForeColor = System.Drawing.Color.Black;
            this.btn_ThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThongTin.Image")));
            this.btn_ThongTin.Location = new System.Drawing.Point(0, 450);
            this.btn_ThongTin.Name = "btn_ThongTin";
            this.btn_ThongTin.Size = new System.Drawing.Size(200, 45);
            this.btn_ThongTin.TabIndex = 5;
            this.btn_ThongTin.Text = "Thông tin cá nhân";
            this.btn_ThongTin.Click += new System.EventHandler(this.btn_ThongTin_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Thoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Black;
            this.btn_Thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_Thoat.Image")));
            this.btn_Thoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Thoat.Location = new System.Drawing.Point(0, 495);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(200, 45);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Đăng xuất";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_SuCo
            // 
            this.btn_SuCo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuCo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_SuCo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_SuCo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_SuCo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SuCo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_SuCo.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuCo.ForeColor = System.Drawing.Color.Black;
            this.btn_SuCo.Image = ((System.Drawing.Image)(resources.GetObject("btn_SuCo.Image")));
            this.btn_SuCo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_SuCo.Location = new System.Drawing.Point(0, 135);
            this.btn_SuCo.Name = "btn_SuCo";
            this.btn_SuCo.Size = new System.Drawing.Size(200, 45);
            this.btn_SuCo.TabIndex = 3;
            this.btn_SuCo.Text = "Sự cố";
            this.btn_SuCo.Click += new System.EventHandler(this.btn_SuCo_Click);
            // 
            // btn_Voucher
            // 
            this.btn_Voucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Voucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Voucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Voucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Voucher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Voucher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Voucher.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voucher.ForeColor = System.Drawing.Color.Black;
            this.btn_Voucher.Image = ((System.Drawing.Image)(resources.GetObject("btn_Voucher.Image")));
            this.btn_Voucher.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Voucher.Location = new System.Drawing.Point(0, 90);
            this.btn_Voucher.Name = "btn_Voucher";
            this.btn_Voucher.Size = new System.Drawing.Size(200, 45);
            this.btn_Voucher.TabIndex = 2;
            this.btn_Voucher.Text = "Voucher";
            this.btn_Voucher.Click += new System.EventHandler(this.btn_Voucher_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_NhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_NhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.Black;
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.Location = new System.Drawing.Point(0, 45);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(200, 45);
            this.btn_NhanVien.TabIndex = 1;
            this.btn_NhanVien.Text = "Quản lý nhân viên";
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_Phim
            // 
            this.btn_Phim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Phim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Phim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Phim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Phim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Phim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Phim.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phim.ForeColor = System.Drawing.Color.Black;
            this.btn_Phim.Image = ((System.Drawing.Image)(resources.GetObject("btn_Phim.Image")));
            this.btn_Phim.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Phim.Location = new System.Drawing.Point(0, 0);
            this.btn_Phim.Name = "btn_Phim";
            this.btn_Phim.Size = new System.Drawing.Size(200, 45);
            this.btn_Phim.TabIndex = 0;
            this.btn_Phim.Text = "Quản lý phim";
            this.btn_Phim.Click += new System.EventHandler(this.btn_Phim_Click);
            // 
            // Avatar_Cinema
            // 
            this.Avatar_Cinema.Dock = System.Windows.Forms.DockStyle.Top;
            this.Avatar_Cinema.ErrorImage = null;
            this.Avatar_Cinema.Image = ((System.Drawing.Image)(resources.GetObject("Avatar_Cinema.Image")));
            this.Avatar_Cinema.ImageRotate = 0F;
            this.Avatar_Cinema.Location = new System.Drawing.Point(0, 0);
            this.Avatar_Cinema.Name = "Avatar_Cinema";
            this.Avatar_Cinema.Size = new System.Drawing.Size(200, 177);
            this.Avatar_Cinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar_Cinema.TabIndex = 1;
            this.Avatar_Cinema.TabStop = false;
            // 
            // Body_Panel
            // 
            this.Body_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body_Panel.Location = new System.Drawing.Point(200, 0);
            this.Body_Panel.Name = "Body_Panel";
            this.Body_Panel.Size = new System.Drawing.Size(1207, 717);
            this.Body_Panel.TabIndex = 1;
            // 
            // F_Main_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 717);
            this.Controls.Add(this.Body_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Name = "F_Main_Admin";
            this.Text = "F_Main_Admin";
            this.Left_Panel.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar_Cinema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Left_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox Avatar_Cinema;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btn_ThongTin;
        private Guna.UI2.WinForms.Guna2Button btn_Thoat;
        private Guna.UI2.WinForms.Guna2Button btn_SuCo;
        private Guna.UI2.WinForms.Guna2Button btn_Voucher;
        private Guna.UI2.WinForms.Guna2Button btn_NhanVien;
        private Guna.UI2.WinForms.Guna2Button btn_Phim;
        private Guna.UI2.WinForms.Guna2Panel Body_Panel;
    }
}