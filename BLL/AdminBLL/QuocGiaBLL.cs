using DAL.AdminDAL;
using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AdminBLL
{
    public class QuocGiaBLL
    {
        private QuocGiaDAL QuocGiaDAL = new QuocGiaDAL();

        public List<QuocGia> LayDanhSachQuocGia()
        {
            return QuocGiaDAL.LayDanhSachQuocGia();
        }
    }
}
