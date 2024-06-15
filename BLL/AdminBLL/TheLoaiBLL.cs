using DAL.AdminDAL;
using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AdminBLL
{
    public class TheLoaiBLL
    {
        private TheLoaiDAL TheLoaiDAL = new TheLoaiDAL();

        public List<TheLoai> LayDanhSachTheLoai()
        {
            return TheLoaiDAL.LayDanhSachTheLoai();
        }
    }
}
