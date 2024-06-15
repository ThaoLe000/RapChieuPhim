using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using DAL;
using DTO;


namespace BLL
{
    public class DangNhapBLL
    {
        private DangNhapDAL userDAL = new DangNhapDAL();

        public bool AuthenticateUser(string username, string password)
        {
            return userDAL.AuthenticateUser(username, password);
        }

        public int GetUserID (string username)
        {
            return userDAL.GetUserID(username);
        }
        public string GetUserRolesByID(int userId)
        {
            return userDAL.GetUsersRolesByID(userId);
        }
        

    }
}
