using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnection
    {
        //Class DBConnection chuwas Connection
        static string str = @"Data Source=DESKTOP-DL0O1RF;Initial Catalog=CinemaManager; Integrated Security=True";
        protected SqlConnection conn = new SqlConnection(str);
    }
}
