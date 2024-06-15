using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ViewAdmin
{
    public partial class F_Main_Admin : Form
    {
        private int userID;
        public F_Main_Admin(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        private Form currentFormChild;
        private void openFormChild(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); //Đóng form hiện tại trước khi mở form mới 
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Body_Panel.Controls.Add(childForm);
            Body_Panel.Tag = childForm;
            childForm.AutoScroll = true;
            childForm.AutoSize = false;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Phim_Click(object sender, EventArgs e)
        {
            openFormChild(new F_QuanLyPhim());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            openFormChild(new F_QuanLyNhanVien());
        }

        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            openFormChild(new F_Voucher());
        }

        private void btn_SuCo_Click(object sender, EventArgs e)
        {
            openFormChild(new F_SuCo());
        }

        private void btn_ThongTin_Click(object sender, EventArgs e)
        {
            openFormChild(new F_ThongTinAdmin(userID));
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            F_DangNhap form = new F_DangNhap();
            form.Show();
            this.Close();
        }
    }
}
