using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.KhachHangDAL;
using DTO.KhachHang;

namespace BLL
{
    public class DangKyBLL
    {
        private TaiKhoanDAL taikhoanDAL = new TaiKhoanDAL();
        private KhachHangDAL khachhangDAL = new KhachHangDAL();

        public string DangKy(TaiKhoan taikhoan, KhachHang khachhang)
        {
            //Kiểm tra xem tên tài khoản đã tồn tại hay chưa
            if (taikhoanDAL.KiemTraTaiKhoanTonTai(taikhoan.Account))
            {
                return "Tài khoản tồn tại";
            }
            int id = taikhoanDAL.ThemTaiKhoan(taikhoan);
            if(id >0)
            {
                khachhang.Id = id;
                bool khachHangResult = khachhangDAL.ThemKhachHang(khachhang);
                if(khachHangResult)
                {
                    return "Đăng ký thành công";
                }
                else
                {
                    return "Đăng ký thất bại";
                }
            }
            return "Đăng ký thất bại";
        }

    }
}
