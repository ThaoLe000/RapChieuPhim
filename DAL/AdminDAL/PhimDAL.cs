using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdminDAL
{
    public class PhimDAL : DBConnection
    {
        public List<Phim> LayDanhSachPhim()
        {
            List<Phim> dsPhim = new List<Phim>();
            SqlCommand cmd = new SqlCommand("Select ID, TenPhim, TheLoai, NgayPhatHanh, QuocGia from Phim", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Phim phim = new Phim
                {
                    ID = (int)reader["ID"],
                    TenPhim = reader["TenPhim"].ToString(),
                    TheLoai = reader["TheLoai"].ToString(),
                    NgayPhatHanh = (DateTime)reader["NgayPhatHanh"],
                    QuocGia = reader["QuocGia"].ToString()
                    

                };
                dsPhim.Add(phim);
            }
            conn.Close();
            return dsPhim;
        }

        public Phim LayPhimTheoMa(int ID)
        {
            Phim phim = null;
            SqlCommand cmd = new SqlCommand("select * from Phim where ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", ID);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                phim = new Phim
                {
                    ID = (int)reader["ID"],
                    TenPhim = reader["TenPhim"].ToString(),
                    TheLoai = reader["TheLoai"].ToString(),
                    NgayPhatHanh = (DateTime)reader["NgayPhatHanh"],
                    DaoDien = reader["DaoDien"].ToString(),
                    QuocGia = reader["QuocGia"].ToString(),
                    ThoiLuong = (int)reader["ThoiLuong"],
                    GiaNhap = (int)reader["GiaNhap"],
                    MoTa = reader["MoTa"].ToString(),
                    Anh = reader["Anh"] as byte[]

                };
            }
            conn.Close();
            return phim;
        }

        public bool ThemPhim(Phim phim)
        {
            SqlCommand cmd = new SqlCommand("insert into Phim (TenPhim, TheLoai, NgayPhatHanh, DaoDien, QuocGia, ThoiLuong, GiaNhap, MoTa, Anh)" +
                " values (@TenPhim , @TheLoai, @NgayPhatHanh, @DaoDien, @QuocGia, @ThoiLuong, @GiaNhap, @MoTa, @Anh)", conn);
            cmd.Parameters.AddWithValue("@TenPhim", phim.TenPhim);
            cmd.Parameters.AddWithValue("@TheLoai", phim.TheLoai);
            cmd.Parameters.AddWithValue("@NgayPhatHanh", phim.NgayPhatHanh.Date);
            cmd.Parameters.AddWithValue("@DaoDien", phim.DaoDien);
            cmd.Parameters.AddWithValue("@QuocGia", phim.QuocGia);
            cmd.Parameters.AddWithValue("@ThoiLuong", phim.ThoiLuong);
            cmd.Parameters.AddWithValue("@GiaNhap", phim.GiaNhap);
            cmd.Parameters.AddWithValue("@MoTa", phim.MoTa);
            cmd.Parameters.AddWithValue("@Anh",phim.Anh);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public bool CapNhatPhim(Phim phim)
        {
            SqlCommand cmd = new SqlCommand("update Phim set TenPhim = @TenPhim, TheLoai = @TheLoai, NgayPhatHanh = @NgayPhatHanh," +
                " DaoDien = @DaoDien, QuocGia = @QuocGia, ThoiLuong = @ThoiLuong, GiaNhap = @GiaNhap, MoTa = @MoTa, Anh = @Anh  where ID = @ID", conn);
            cmd.Parameters.AddWithValue("@ID", phim.ID);
            cmd.Parameters.AddWithValue("@TenPhim", phim.TenPhim);
            cmd.Parameters.AddWithValue("@TheLoai", phim.TheLoai);
            cmd.Parameters.AddWithValue("@NgayPhatHanh", phim.NgayPhatHanh.Date);
            cmd.Parameters.AddWithValue("@DaoDien", phim.DaoDien);
            cmd.Parameters.AddWithValue("@QuocGia", phim.QuocGia);
            cmd.Parameters.AddWithValue("@ThoiLuong", phim.ThoiLuong);
            cmd.Parameters.AddWithValue("@GiaNhap", phim.GiaNhap);
            cmd.Parameters.AddWithValue("@MoTa", phim.MoTa);
            cmd.Parameters.AddWithValue("@Anh", phim.Anh);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public bool XoaPhim(int Id)
        {
            SqlCommand cmd = new SqlCommand("Delete from Phim where ID = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", Id);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }

        public List<Phim> TimKiemPhim(string keyword)
        {
            List<Phim> dsphim = new List<Phim>();
            SqlCommand cmd = new SqlCommand("select ID, TenPhim, TheLoai, " +
                "NgayPhatHanh, DaoDien from Phim where TenPhim like @keyword " +
                "or TheLoai like @keyword or QuocGia like @keyword",conn);
            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Phim phim = new Phim
                {
                    ID = (int)reader["ID"],
                    TenPhim = reader["TenPhim"].ToString(),
                    TheLoai = reader["TheLoai"].ToString(),
                    NgayPhatHanh = (DateTime)reader["NgayPhatHanh"],
                    DaoDien = reader["DaoDien"].ToString(),
                    QuocGia = reader["QuocGia"].ToString(),
                    ThoiLuong = (int)reader["ThoiLuong"],
                    GiaNhap = (int)reader["GiaNhap"],
                    MoTa = reader["MoTa"].ToString(),
                    Anh = reader["Anh"] as byte[]
                };
                dsphim.Add(phim);
            }
            conn.Close();
            return dsphim;
        }
    }
}
