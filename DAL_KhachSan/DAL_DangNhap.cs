using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DTO_KhachSan;

namespace DAL_KhachSan
{
    public class DAL_DangNhap
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        SqlDataReader dr;
        public DTO_TaiKhoan DangNhapTaiKhoan(string Email_TaiKhoan, string Pass_TaiKhoan, string Role_TaiKhoan)
        {
            kn.moketnoi();
            string thucthi = "Select*from TaiKhoan where Email_TaiKhoan = @Email_TaiKhoan and Pass_TaiKhoan=@Pass_TaiKhoan and Role_TaiKhoan=@Role_TaiKhoan";
            SqlCommand cmd= new SqlCommand(thucthi,DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Email_TaiKhoan", Email_TaiKhoan);
            cmd.Parameters.AddWithValue("@Pass_TaiKhoan", Pass_TaiKhoan);
            cmd.Parameters.AddWithValue("@Role_TaiKhoan",Role_TaiKhoan);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                DTO_TaiKhoan taiKhoan = new DTO_TaiKhoan
                {
                    ID_TaiKhoan = Convert.ToInt32(dr["ID_TaiKhoan"]),
                    Email_TaiKhoan = dr["Email_TaiKhoan"].ToString(),
                    Pass_TaiKhoan = dr["Pass_TaiKhoan"].ToString(),
                    Role_TaiKhoan = dr["Role_TaiKhoan"].ToString(),
                    Ban_TaiKhoan = Convert.ToInt32(dr["Ban_TaiKhoan"])
                };
                return taiKhoan;

            }
            return null;
        }
    }
}
