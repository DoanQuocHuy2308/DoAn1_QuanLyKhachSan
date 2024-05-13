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
        public DTO_TaiKhoan DangNhapTaiKhoan(DTO_TaiKhoan tk)
        {
            kn.moketnoi();
                string thucthi = "SELECT * FROM TaiKhoan WHERE Email_TaiKhoan = @Email_TaiKhoan AND Pass_TaiKhoan = @Pass_TaiKhoan AND Role_TaiKhoan = @Role_TaiKhoan";
                using (SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Pass_TaiKhoan", tk.Pass_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Role_TaiKhoan", tk.Role_TaiKhoan);
                using (dr = cmd.ExecuteReader())
                {
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
                }
            }
            return null;
        }

        public string LayTenNhanVien(string email)
        {
            kn.moketnoi();

            string tenNhanVien = "";
            string thucthi = "SELECT Ten_NhanVien FROM NhanVien INNER JOIN TaiKhoan ON Email_NhanVien = Email_TaiKhoan WHERE Email_TaiKhoan = @Email_TaiKhoan";
            using (SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@Email_TaiKhoan", email);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tenNhanVien = result.ToString();
                }
            }
            return tenNhanVien;
        }
    }
}
