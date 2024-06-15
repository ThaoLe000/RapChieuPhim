using BLL.AdminBLL;
using DTO.Admin;
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
    public partial class F_QuanLyPhim : Form
    {
        private PhimBLL phimBLL = new PhimBLL();
        public F_QuanLyPhim()
        {
            InitializeComponent();
            LoadDataToDataGridView();
        }

        private void LoadDataToDataGridView()
        {
            List<Phim> dsphim = phimBLL.LayDanhSachPhim();
            HienThiDanhSachPhim(dsphim);
        }

        private void HienThiDanhSachPhim(List<Phim> dsphim)
        {
           
            dgv_Phim.Rows.Clear();

            foreach (Phim phim in dsphim)
            {
                DataGridViewRow dgvRow = new DataGridViewRow();
                dgvRow.CreateCells(dgv_Phim);

                dgvRow.Cells[0].Value = phim.ID;
                dgvRow.Cells[1].Value = phim.TenPhim;
                dgvRow.Cells[2].Value = phim.TheLoai;
                dgvRow.Cells[3].Value = phim.NgayPhatHanh.ToShortDateString();
                dgvRow.Cells[4].Value = phim.QuocGia;

                dgvRow.Cells[5].Value = "Sửa"; // Cột "Update"
                dgvRow.Cells[6].Value = "Xóa"; // Cột "Delete"

                dgv_Phim.Rows.Add(dgvRow);
            }
        }

        private void btn_TimKiem_Changed(object sender, EventArgs e)
        {
            string keyword = txt_TimKiem.Text;
            List<Phim> dsphim = phimBLL.TimKiemPhim(keyword);
            HienThiDanhSachPhim(dsphim);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            F_QuanLyPhim_Them form = new F_QuanLyPhim_Them();
            form.ShowDialog();
            LoadDataToDataGridView();
        }

        private void dgv_Phim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Phim.Rows[e.RowIndex];

                if (dgv_Phim.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                {
                    int maPhim = (int)row.Cells["ID"].Value;

                    if (dgv_Phim.Columns[e.ColumnIndex].Name == "Sua")
                    {
                        int phimID = (int)dgv_Phim.Rows[e.RowIndex].Cells["ID"].Value;
                        F_QuanLyPhim_Sua form = new F_QuanLyPhim_Sua(phimID);
                        form.ShowDialog();
                        LoadDataToDataGridView();

                    } else if (dgv_Phim.Columns[e.ColumnIndex].Name == "Xoa")
                    {
                        DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phim", "Xác nhận xóa", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            bool xoaPhim = phimBLL.XoaPhim(maPhim);

                            if (xoaPhim)
                            {
                                MessageBox.Show("Xóa phim thành công");
                                LoadDataToDataGridView();
                            }
                            else
                            {
                                MessageBox.Show("Xóa phim thất bại");
                            }
                        }
                    }
                }

            }
        }


    }
}

