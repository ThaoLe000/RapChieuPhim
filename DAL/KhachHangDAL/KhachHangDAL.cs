using DTO.KhachHang;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.KhachHangDAL
{
    public class KhachHangDAL: DBConnection
    {
        public bool ThemKhachHang( KhachHang kh)
        {
            SqlCommand cmd = new SqlCommand("insert into KhachHang( KhachHangID, UserName, Gmail) values (@Id , @Username, @Gmail)", conn);
            cmd.Parameters.AddWithValue("@Id", kh.Id);
            cmd.Parameters.AddWithValue("@Username", kh.Username);
            cmd.Parameters.AddWithValue("@Gmail", kh.Gmail);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }
    }
}
