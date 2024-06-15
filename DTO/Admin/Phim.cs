using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Admin
{
    public class Phim
    {
        public int ID {  get; set; }
        public string TenPhim { get; set; }
        public string TheLoai { get; set;}
        public DateTime NgayPhatHanh { get; set;}
        public string DaoDien { get; set;}
        public string QuocGia { get;set;}
        public int ThoiLuong { get;set;}
        public int GiaNhap {  get; set;}
        public string MoTa {  get; set;}
        public byte[] Anh {  get; set;}
    }
}
