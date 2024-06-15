using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        
        public TaiKhoan(int id, string account, string password)
        {
            this.Id = id;
            this.Account = account;
            this.Password = password;
        }
        public TaiKhoan() { }
    }
}
