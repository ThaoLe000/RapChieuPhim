using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.AdminDAL
{
    public class QuocGiaDAL :DBConnection
    {
        public List<QuocGia> LayDanhSachQuocGia()
        {
            List<QuocGia> dsQuocGia = new List<QuocGia>();
            SqlCommand cmd = new SqlCommand("Select * from QuocGia", conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                QuocGia quocGia = new QuocGia
                {
                    QuocGiaID = (int)reader["QuocGiaID"],
                    TenQuocGia = reader["TenQuocGia"].ToString()
                };
                dsQuocGia.Add(quocGia);
            }
            conn.Close();
            return dsQuocGia;
        }
    }
}
