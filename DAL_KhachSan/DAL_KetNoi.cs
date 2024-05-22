using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAL_KhachSan
{
    public class DAL_KetNoi
    {
        string chuoikn = "Data Source=DESKTOP-IO5D2MK\\DOANQUOCHUY;Initial Catalog=QuanLyKhachSan;Integrated Security=True;Encrypt=False";
        public static SqlConnection sqlcon;
        public void moketnoi()
        {
            sqlcon = new SqlConnection(chuoikn);
            if(sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
        }
        public void dongketnoi()
        {
            sqlcon = new SqlConnection(chuoikn);
            if( sqlcon.State == ConnectionState.Open)
            {
                sqlcon.Close();
            }
        }
    }
}
