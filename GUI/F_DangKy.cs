using BLL;
using DTO;
using DTO.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class F_DangKy : Form
    {
        public F_DangKy()
        {
            InitializeComponent();
        }
        private void CheckNull()
        {
            if (txt_account.Text == "")
            {
                txt_account.PlaceholderText = "Vui lòng nhập tên đăng nhập!";
                txt_account.PlaceholderForeColor = Color.Red;
            }
            if (txt_password.Text == "")
            {
                txt_password.PlaceholderText = "Vui lòng nhập mật khẩu!";
                txt_password.PlaceholderForeColor = Color.Red;
            }
            if (txt_Gmail.Text == "")
            {
                txt_Gmail.PlaceholderText = "Vui lòng nhập địa chỉ Gmail!";
                txt_Gmail.PlaceholderForeColor = Color.Red;
            }
            if (txt_confirmpassword.Text == "")
            {
                txt_confirmpassword.PlaceholderText = "Vui lòng điền lại mật khẩu!";
                txt_confirmpassword.PlaceholderForeColor = Color.Red;
            }
        }
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            KhachHang khachhang = new KhachHang 
            {
                Gmail = txt_Gmail.Text,
                Username = txt_account.Text
            };
            TaiKhoan taikhoan = new TaiKhoan
            {
                Account = txt_account.Text,
                Password = txt_password.Text,
            };
            DangKyBLL dangKyBLL = new DangKyBLL();
            string result = dangKyBLL.DangKy(taikhoan, khachhang);

            MessageBox.Show(result);
          
        }

        private void btn_backLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Icon_pass_right_Clicked(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '\0';
            //Kiểm tra pass có đang hide?
            if (txt_password.UseSystemPasswordChar)
            {
                //Hiển thị pass
                txt_password.UseSystemPasswordChar = false;
                //Đổi icon
                txt_password.IconRight = Properties.Resources.icon_eye_off;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                txt_password.IconRight = Properties.Resources.xrilcb7p;
            }
        }

        private void icon_cfpass_Clicked(object sender, EventArgs e)
        {
            txt_confirmpassword.PasswordChar = '\0';
            //Kiểm tra pass có đang hide?
            if (txt_confirmpassword.UseSystemPasswordChar)
            {
                //Hiển thị pass
                txt_confirmpassword.UseSystemPasswordChar = false;
                //Đổi icon
                txt_confirmpassword.IconRight = Properties.Resources.icon_eye_off;
            }
            else
            {
                txt_confirmpassword.UseSystemPasswordChar = true;
                txt_confirmpassword.IconRight = Properties.Resources.xrilcb7p;
            }
        }
    }
}
