using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using DTO;

namespace DAL
{
    public class DangNhapDAL: DBConnection
    {
        public bool AuthenticateUser(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("select count(1) from TaiKhoan where Account = @Username and Password = @Password", conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue ("@password", password);
            conn.Open();

            int result = (int)cmd.ExecuteScalar();
            conn.Close();
            return result > 0;
            
            
        }
        public int GetUserID(string username)
        {
            SqlCommand cmd = new SqlCommand("Select ID from TaiKhoan where Account = @Username", conn);
            cmd.Parameters.AddWithValue("@Username", username);
            conn.Open();
            int id = (int)cmd.ExecuteScalar();
            conn.Close();
            return id;
        }
        
        public string GetUsersRolesByID(int userId) 
        {
            SqlCommand cmd = new SqlCommand("SELECT 'Admin' AS Role FROM Admin WHERE AdminID = @UserID " +
                                                   "UNION " +
                                                   "SELECT 'NhanVien' AS Role FROM NhanVien WHERE NhanVienID = @UserID " +
                                                   "UNION " +
                                                   "SELECT 'KhachHang' AS Role FROM KhachHang WHERE KhachHangID = @UserID", conn);
            cmd.Parameters.AddWithValue("@UserID", userId);
            conn.Open();
            string role = (string)cmd.ExecuteScalar();
            conn.Close();
            return role;
            

        }

        
    }
    
}
