using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdminDAL
{
    public class TheLoaiDAL :DBConnection
    {
        public List<TheLoai> LayDanhSachTheLoai()
        {
            List<TheLoai> dsTheLoai = new List<TheLoai>();
            SqlCommand cmd = new SqlCommand("Select * from TheLoai", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TheLoai theLoai = new TheLoai
                {
                    TheLoaiID = (int)reader["TheLoaiID"],
                    TenTheLoai = reader["TenTheLoai"].ToString()
                };
                dsTheLoai.Add(theLoai);
            }
            conn.Close();
            return dsTheLoai;
        }
    }
}
