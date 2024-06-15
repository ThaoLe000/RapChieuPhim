using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TaiKhoanDAL: DBConnection
    {
        public int ThemTaiKhoan(TaiKhoan tk)
        {
            SqlCommand cmd = new SqlCommand("insert into TaiKhoan (Account, Password) output inserted.ID values (@Account , @Password)", conn);
            cmd.Parameters.AddWithValue("@Account", tk.Account);
            cmd.Parameters.AddWithValue("@Password", tk.Password);

            conn.Open();
            int result = (int)cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
        public bool KiemTraTaiKhoanTonTai(string Account)
        {            
            SqlCommand cmd = new SqlCommand("select count(*) from TaiKhoan where Account = @Account", conn);
            cmd.Parameters.AddWithValue("@Account", Account);

            conn.Open();
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            return count >0;
        }
    }
}
