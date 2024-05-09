using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_KhachSan
{
    public class DAL_DangKy
    {
        private DAL_KetNoi kn = new DAL_KetNoi();

        public bool KiemTraEmailTonTai(DTO_TaiKhoan tk)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM TaiKhoan WHERE Email_TaiKhoan = @Email";
                using (SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email", tk.Email_TaiKhoan); 
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra email tồn tại: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
        public void DangKyTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "INSERT INTO TaiKhoan (Email_TaiKhoan, Pass_TaiKhoan, Role_TaiKhoan) VALUES (@Email_TaiKhoan, @Pass_TaiKhoan, @Role_TaiKhoan)";
                using (SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Pass_TaiKhoan", tk.Pass_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Role_TaiKhoan", tk.Role_TaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đăng ký tài khoản: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
    }
}
