using BLL.AdminBLL;
using DTO.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ViewAdmin
{
    public partial class F_QuanLyPhim_Them : Form
    {
        private PhimBLL phimBLL = new PhimBLL();
        private TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        private QuocGiaBLL QuocGiaBLL = new QuocGiaBLL();
        public F_QuanLyPhim_Them()
        {
            InitializeComponent();
            LoadTheLoai();
            LoadQuocGia();
        }
        private void LoadTheLoai()
        {
            List<TheLoai> theLoaiList = theLoaiBLL.LayDanhSachTheLoai();
            cbb_TheLoai.DisplayMember = "TenTheLoai";
            cbb_TheLoai.ValueMember = "TenTheLoai";
            cbb_TheLoai.DataSource = theLoaiList;
            
        }
        private void LoadQuocGia()
        {
            List<QuocGia> quocGiaList = QuocGiaBLL.LayDanhSachQuocGia();
            cbb_QuocGia.DataSource = quocGiaList;
            cbb_QuocGia.DisplayMember = "TenQuocGia";
            cbb_QuocGia.ValueMember = "TenQuocGia";
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txt_ThoiLuong.Text, out int thoiLuong) &&
                int.TryParse(txt_GiaNhap.Text, out int giaNhap))
            {

                Phim phim = new Phim
                {
                    TenPhim = txt_TenPhim.Text,
                    TheLoai = cbb_TheLoai.Text,
                    NgayPhatHanh = txt_DateTime.Value,
                    DaoDien = txt_DaoDien.Text,
                    ThoiLuong = thoiLuong,
                    GiaNhap = giaNhap,
                    QuocGia = cbb_QuocGia.Text,
                    MoTa = txt_Mota.Text,
                    Anh = LayAnhTuPictureBox(pictureBoxAdd)
                };

                //Gọi BLL để thêm phim
                bool themPhim = phimBLL.ThemPhim(phim);

                if (themPhim)
                {
                    MessageBox.Show("Thêm phim thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra: Không thể thêm phim");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập gái trị thời gian và giá nhập hợp lệ");
            }
        }
        private byte[] LayAnhTuPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_PictureAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Chọn ảnh",
                Filter = "Image Files| *.jpg; *.jpeg; *.png; *.bmp"
            };
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAdd.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
