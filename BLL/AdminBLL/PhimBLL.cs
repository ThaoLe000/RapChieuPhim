using DAL.AdminDAL;
using DTO.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.AdminBLL
{
    public class PhimBLL
    {
        private PhimDAL phimDAL = new PhimDAL();

        public List<Phim> LayDanhSachPhim()
        {
            return phimDAL.LayDanhSachPhim();
        }
        public Phim LayPhimTheoMa(int Id)
        {
            return phimDAL.LayPhimTheoMa(Id);
        }
        public bool ThemPhim(Phim phim)
        {
            return phimDAL.ThemPhim(phim);
        }
        public bool CapNhatPhim(Phim phim)
        {
            return phimDAL.CapNhatPhim(phim) ;
        }
        public bool XoaPhim(int Id)
        {
            return phimDAL.XoaPhim(Id);
        }
        public List<Phim> TimKiemPhim(string keyword) 
        {
            return phimDAL.TimKiemPhim(keyword);
        }
    }
}
