using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.ViewAdmin;
using GUI.ViewStaff;
using GUI.ViewUser;


namespace GUI
{   
    
    
    public partial class F_DangNhap : Form
    {
        private DangNhapBLL accountBLL = new DangNhapBLL();
        //Taọ event Timer
        private Timer time;
        //Tạo story ảnh
        private int currentImageIndex = 0;
        //Lưu trữ danh sách các hình ảnh cần thay đổi
        private Image[] images;

     
        public F_DangNhap()
        {
            InitializeComponent();

            images = new Image[]
            {
                Properties.Resources._1,
                Properties.Resources._3,
                Properties.Resources._41,
                Properties.Resources._32,
                Properties.Resources._51,
                Properties.Resources._5,
                Properties.Resources._7,
            };
            //Sự kiện gọi Timer_tick
            time = new Timer();
            time.Interval = 3000;
            time.Tick += new EventHandler(Timer_Tick);
            time.Start();
        }


        private void CheckNull()
        {
            if(txt_account.Text == "")
            {
                txt_account.PlaceholderText = "Vui lòng nhập tên đăng nhập!";
                txt_account.PlaceholderForeColor = Color.Red;
            }
            if(txt_password.Text == "")
            {
                txt_password.PlaceholderText = "Vui lòng nhập mật khẩu!";
                txt_password.PlaceholderForeColor = Color.Red;
            }
        }
        private void Icon_password_right(object sender, EventArgs e)
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            //Sự kiện thay đổi ảnh
            Banner.Image = images[currentImageIndex];
            //Chuyển đến ảnh đầu tiên khi chạy đến ảnh cuối
            currentImageIndex = (currentImageIndex + 1) % images.Length;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
                TaiKhoan tk = new TaiKhoan();
                tk.Account = txt_account.Text;
                tk.Password = txt_password.Text;
                //Kiểm tra xem có bị null không
            if(txt_account.Text == "" || txt_password.Text == "")
                {
                CheckNull();
                }
            else
            {
                bool isAuthenticated = accountBLL.AuthenticateUser(tk.Account, tk.Password);
                if (isAuthenticated) 
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Lấy ID của người dùng
                    int userID = accountBLL.GetUserID(tk.Account);
                    //Xác định chức vụ của người dùng
                    string role = accountBLL.GetUserRolesByID(userID);
                    // Điều hướng tới các trang khác nhau
                    switch (role)
                    {
                        case "Admin":
                            //Điều hướng tới trang Admin
                            F_Main_Admin formAD = new F_Main_Admin(userID);
                            formAD.Show();
                            this.Hide();
                            break;
                        case "NhanVien":
                            //Điều hướng tới trang Nhân Viên
                            F_ThongTinNhanVien formNV = new F_ThongTinNhanVien(userID);
                            formNV.Show();
                            this.Hide();
                            break;
                        case "KhachHang":
                            F_ThongTinKhachHang formKH = new F_ThongTinKhachHang(userID);
                            formKH.Show();
                            this.Hide();
                            break;
                        default:
                            //Trường hợp các chức vụ khác
                            MessageBox.Show("Không xác định được quyền truy cập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc Tài Khoản không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
        }
        private Form currentFormChild;
        private void openFormChild(Form childForm) 
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close(); //Đóng form hiện tại trước khi mở form mới 
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            BodyPanel.Controls.Add(childForm);
            BodyPanel.Tag = childForm;
            childForm.AutoScroll = true;
            childForm.AutoSize = false;
            childForm.BringToFront();
            childForm.Show();
        }

        private void QuenMatKhau_Click(object sender, EventArgs e)
        {
            openFormChild(new F_QuenMatKhau());
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            openFormChild(new F_DangKy());
        }
    }
}
