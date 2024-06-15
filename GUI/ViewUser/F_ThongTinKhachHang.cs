using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ViewUser
{
    public partial class F_ThongTinKhachHang : Form
    {
        private int userID;
        public F_ThongTinKhachHang(int userId)
        {
            InitializeComponent();
            this.userID = userId;
        }
    }
}
