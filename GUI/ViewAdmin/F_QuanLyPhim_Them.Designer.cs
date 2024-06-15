namespace GUI.ViewAdmin
{
    partial class F_QuanLyPhim_Them
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TenPhim = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbb_TheLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_DaoDien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_QuocGia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_ThoiLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_Mota = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_GiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Huy = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them = new Guna.UI2.WinForms.Guna2Button();
            this.btn_PictureAdd = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxAdd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thêm phim mới";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 45);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên phim:";
            // 
            // txt_TenPhim
            // 
            this.txt_TenPhim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenPhim.DefaultText = "";
            this.txt_TenPhim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenPhim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenPhim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenPhim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenPhim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenPhim.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenPhim.ForeColor = System.Drawing.Color.Black;
            this.txt_TenPhim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenPhim.Location = new System.Drawing.Point(13, 106);
            this.txt_TenPhim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TenPhim.Name = "txt_TenPhim";
            this.txt_TenPhim.PasswordChar = '\0';
            this.txt_TenPhim.PlaceholderText = "Tên phim";
            this.txt_TenPhim.SelectedText = "";
            this.txt_TenPhim.Size = new System.Drawing.Size(393, 55);
            this.txt_TenPhim.TabIndex = 9;
            // 
            // cbb_TheLoai
            // 
            this.cbb_TheLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbb_TheLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_TheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TheLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_TheLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_TheLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_TheLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_TheLoai.ItemHeight = 30;
            this.cbb_TheLoai.Location = new System.Drawing.Point(548, 106);
            this.cbb_TheLoai.Name = "cbb_TheLoai";
            this.cbb_TheLoai.Size = new System.Drawing.Size(393, 36);
            this.cbb_TheLoai.TabIndex = 11;
            // 
            // txt_DaoDien
            // 
            this.txt_DaoDien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DaoDien.DefaultText = "";
            this.txt_DaoDien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DaoDien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DaoDien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DaoDien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DaoDien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DaoDien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DaoDien.ForeColor = System.Drawing.Color.Black;
            this.txt_DaoDien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DaoDien.Location = new System.Drawing.Point(13, 233);
            this.txt_DaoDien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DaoDien.Name = "txt_DaoDien";
            this.txt_DaoDien.PasswordChar = '\0';
            this.txt_DaoDien.PlaceholderText = "Đạo diễn";
            this.txt_DaoDien.SelectedText = "";
            this.txt_DaoDien.Size = new System.Drawing.Size(393, 55);
            this.txt_DaoDien.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(543, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thể loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Đạo diễn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(543, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quốc gia:";
            // 
            // cbb_QuocGia
            // 
            this.cbb_QuocGia.BackColor = System.Drawing.Color.Transparent;
            this.cbb_QuocGia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_QuocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_QuocGia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_QuocGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_QuocGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_QuocGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_QuocGia.ItemHeight = 30;
            this.cbb_QuocGia.Location = new System.Drawing.Point(548, 233);
            this.cbb_QuocGia.Name = "cbb_QuocGia";
            this.cbb_QuocGia.Size = new System.Drawing.Size(196, 36);
            this.cbb_QuocGia.TabIndex = 15;
            // 
            // txt_ThoiLuong
            // 
            this.txt_ThoiLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ThoiLuong.DefaultText = "";
            this.txt_ThoiLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ThoiLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ThoiLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThoiLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ThoiLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThoiLuong.ForeColor = System.Drawing.Color.Black;
            this.txt_ThoiLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ThoiLuong.Location = new System.Drawing.Point(804, 233);
            this.txt_ThoiLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ThoiLuong.Name = "txt_ThoiLuong";
            this.txt_ThoiLuong.PasswordChar = '\0';
            this.txt_ThoiLuong.PlaceholderText = "Thời lượng";
            this.txt_ThoiLuong.SelectedText = "";
            this.txt_ThoiLuong.Size = new System.Drawing.Size(204, 55);
            this.txt_ThoiLuong.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(799, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Thời lượng (Phút):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(799, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ngày phát hành:";
            // 
            // txt_DateTime
            // 
            this.txt_DateTime.BackColor = System.Drawing.Color.Transparent;
            this.txt_DateTime.Checked = true;
            this.txt_DateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_DateTime.CustomFormat = "dd-MM-yyyy";
            this.txt_DateTime.FillColor = System.Drawing.SystemColors.Window;
            this.txt_DateTime.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DateTime.ForeColor = System.Drawing.Color.Black;
            this.txt_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_DateTime.Location = new System.Drawing.Point(804, 343);
            this.txt_DateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_DateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_DateTime.Name = "txt_DateTime";
            this.txt_DateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_DateTime.Size = new System.Drawing.Size(204, 36);
            this.txt_DateTime.TabIndex = 28;
            this.txt_DateTime.UseTransparentBackground = true;
            this.txt_DateTime.Value = new System.DateTime(2024, 6, 13, 9, 24, 53, 311);
            // 
            // txt_Mota
            // 
            this.txt_Mota.BorderRadius = 10;
            this.txt_Mota.BorderThickness = 2;
            this.txt_Mota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Mota.DefaultText = "";
            this.txt_Mota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Mota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Mota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Mota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Mota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Mota.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mota.ForeColor = System.Drawing.Color.Black;
            this.txt_Mota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Mota.Location = new System.Drawing.Point(13, 344);
            this.txt_Mota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Mota.Multiline = true;
            this.txt_Mota.Name = "txt_Mota";
            this.txt_Mota.PasswordChar = '\0';
            this.txt_Mota.PlaceholderText = "Giới thiệu phim";
            this.txt_Mota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Mota.SelectedText = "";
            this.txt_Mota.Size = new System.Drawing.Size(343, 324);
            this.txt_Mota.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(14, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Mô tả:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(799, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 32;
            this.label9.Text = "Giá nhập:";
            // 
            // txt_GiaNhap
            // 
            this.txt_GiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_GiaNhap.DefaultText = "";
            this.txt_GiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_GiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_GiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_GiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GiaNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GiaNhap.ForeColor = System.Drawing.Color.Black;
            this.txt_GiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_GiaNhap.Location = new System.Drawing.Point(804, 440);
            this.txt_GiaNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_GiaNhap.Name = "txt_GiaNhap";
            this.txt_GiaNhap.PasswordChar = '\0';
            this.txt_GiaNhap.PlaceholderText = "Giá nhập";
            this.txt_GiaNhap.SelectedText = "";
            this.txt_GiaNhap.Size = new System.Drawing.Size(204, 55);
            this.txt_GiaNhap.TabIndex = 33;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BorderRadius = 10;
            this.btn_Huy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Huy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Huy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Huy.FillColor = System.Drawing.Color.Red;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(783, 621);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(97, 45);
            this.btn_Huy.TabIndex = 35;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BorderRadius = 10;
            this.btn_Them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(900, 621);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(128, 45);
            this.btn_Them.TabIndex = 36;
            this.btn_Them.Text = "Xác nhận";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_PictureAdd
            // 
            this.btn_PictureAdd.BorderRadius = 10;
            this.btn_PictureAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_PictureAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_PictureAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_PictureAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_PictureAdd.FillColor = System.Drawing.Color.Lime;
            this.btn_PictureAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_PictureAdd.ForeColor = System.Drawing.Color.White;
            this.btn_PictureAdd.Image = global::GUI.Properties.Resources.upload_16_icon;
            this.btn_PictureAdd.Location = new System.Drawing.Point(664, 633);
            this.btn_PictureAdd.Name = "btn_PictureAdd";
            this.btn_PictureAdd.Size = new System.Drawing.Size(54, 33);
            this.btn_PictureAdd.TabIndex = 34;
            this.btn_PictureAdd.Click += new System.EventHandler(this.btn_PictureAdd_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAdd.FillColor = System.Drawing.Color.Gray;
            this.pictureBoxAdd.ImageRotate = 0F;
            this.pictureBoxAdd.Location = new System.Drawing.Point(400, 343);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(258, 325);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdd.TabIndex = 31;
            this.pictureBoxAdd.TabStop = false;
            // 
            // F_QuanLyPhim_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1098, 695);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_PictureAdd);
            this.Controls.Add(this.txt_GiaNhap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBoxAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Mota);
            this.Controls.Add(this.txt_DateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ThoiLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbb_QuocGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DaoDien);
            this.Controls.Add(this.cbb_TheLoai);
            this.Controls.Add(this.txt_TenPhim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_QuanLyPhim_Them";
            this.Text = "F_QuanLyPhim_Them";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenPhim;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_TheLoai;
        private Guna.UI2.WinForms.Guna2TextBox txt_DaoDien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_QuocGia;
        private Guna.UI2.WinForms.Guna2TextBox txt_ThoiLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_DateTime;
        private Guna.UI2.WinForms.Guna2TextBox txt_Mota;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxAdd;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_GiaNhap;
        private Guna.UI2.WinForms.Guna2Button btn_PictureAdd;
        private Guna.UI2.WinForms.Guna2Button btn_Huy;
        private Guna.UI2.WinForms.Guna2Button btn_Them;
    }
}