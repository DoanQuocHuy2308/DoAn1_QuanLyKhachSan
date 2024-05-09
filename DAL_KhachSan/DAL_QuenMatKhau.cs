using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_KhachSan
{
    public class DAL_QuenMatKhau
    {
        private DAL_KetNoi kn = new DAL_KetNoi();
        public bool KiemTraEmailTonTai(string email)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM TaiKhoan WHERE Email_TaiKhoan = @Email";
                using (SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
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
        public string KiemTraRole(string email)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT Role_TaiKhoan FROM TaiKhoan WHERE Email_TaiKhoan = @Email";
                using (SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["Role_TaiKhoan"].ToString();
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin vai trò: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }

        public void ThayDoiMatKhau(DTO_TaiKhoan dTO_TaiKhoan)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE TaiKhoan SET Pass_TaiKhoan=@Pass_TaiKhoan Where Email_TaiKhoan=@Email_TaiKhoan";
                using(SqlCommand cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Pass_TaiKhoan", dTO_TaiKhoan.Pass_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", dTO_TaiKhoan.Email_TaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thay đổi mật khẩu tài khoản: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
    }
}
