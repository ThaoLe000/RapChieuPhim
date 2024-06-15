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
    public partial class F_QuanLyPhim_Sua : Form
    {
        private PhimBLL phimBLL = new PhimBLL();
        private TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        private QuocGiaBLL QuocGiaBLL = new QuocGiaBLL();
        private int phimID;

        public F_QuanLyPhim_Sua(int id)
        {
            InitializeComponent();
            phimID = id;
            LoadTheLoai();
            LoadQuocGia();
            LoadThongTinPhim();

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
        private void LoadThongTinPhim()
        {
            Phim phim = phimBLL.LayPhimTheoMa(phimID);
            if (phim != null) 
            {
                txt_TenPhim.Text = phim.TenPhim;
                cbb_TheLoai.SelectedValue = phim.TheLoai;
                txt_DateTime.Value = phim.NgayPhatHanh;
                txt_DaoDien.Text = phim.DaoDien;
                txt_ThoiLuong.Text = phim.ThoiLuong.ToString();
                txt_GiaNhap.Text = phim.GiaNhap.ToString();
                cbb_QuocGia.SelectedValue = phim.QuocGia;
                txt_Mota.Text = phim.MoTa;

                if(phim.Anh != null)
                {
                    using (MemoryStream ms = new MemoryStream(phim.Anh)) 
                    { 
                        pictureBoxAdd.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        

        private void F_QuanLyPhim_Sua_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txt_ThoiLuong.Text, out int thoiLuong) &&
                int.TryParse(txt_GiaNhap.Text, out int giaNhap))
            {
                Phim phim = new Phim
                {
                    ID = phimID,
                    TenPhim = txt_TenPhim.Text,
                    TheLoai = cbb_TheLoai.SelectedValue.ToString(),
                    NgayPhatHanh = txt_DateTime.Value,
                    DaoDien = txt_DaoDien.Text,
                    ThoiLuong = thoiLuong,
                    GiaNhap = giaNhap,
                    QuocGia = cbb_QuocGia.SelectedValue.ToString(),
                    MoTa = txt_Mota.Text,
                    Anh = LayAnhTuPictureBox(pictureBoxAdd)
                };

                bool suaPhim = phimBLL.CapNhatPhim(phim);
                if(suaPhim)
                {
                    MessageBox.Show("Cập nhật phim thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra:Không thể cập nhật phim");
                }
            }
        }
        private byte[] LayAnhTuPictureBox(PictureBox pictureBox)
        {
            if(pictureBox.Image != null)
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    pictureBox.Image.Save(ms, pictureBoxAdd.Image.RawFormat);
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAdd.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
