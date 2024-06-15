using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ViewAdmin
{
    public partial class F_ThongTinAdmin : Form
    {
        private int userID;

        public F_ThongTinAdmin(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }
        

        

        private void icon_Picture_Click(object sender, EventArgs e)
        {

        }
    }
}
