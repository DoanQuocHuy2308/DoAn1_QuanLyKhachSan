using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_KhachSan
{
    public class DAL_TaiKhoan
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable HienThiDuLieuTaiKhoan()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select*from TaiKhoan";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public bool KTEmail(DTO_TaiKhoan tk)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM TaiKhoan WHERE Email_TaiKhoan = @Email_TaiKhoan";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin tài khoản: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void ADD(DTO_TaiKhoan tk)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert into TaiKhoan(Email_TaiKhoan,Pass_TaiKhoan,Role_TaiKhoan,Ban_TaiKhoan) Values (@Email_TaiKhoan,@Pass_TaiKhoan,@Role_TaiKhoan,@Ban_TaiKhoan)";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Pass_TaiKhoan", tk.Pass_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Role_TaiKhoan", tk.Role_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Ban_TaiKhoan", tk.Ban_TaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài khoản: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Update(DTO_TaiKhoan tk)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE TaiKhoan SET Email_TaiKhoan=@Email_TaiKhoan, Pass_TaiKhoan=@Pass_TaiKhoan,Role_TaiKhoan=@Role_TaiKhoan,Ban_TaiKhoan=@Ban_TaiKhoan WHERE ID_TaiKhoan = @ID_TaiKhoan ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_TaiKhoan", tk.ID_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Pass_TaiKhoan", tk.Pass_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Role_TaiKhoan", tk.Role_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Ban_TaiKhoan", tk.Ban_TaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin tài khoản: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Delete(DTO_TaiKhoan tk)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Delete TaiKhoan where ID_TaiKhoan=@ID_TaiKhoan";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_TaiKhoan", tk.ID_TaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin tài khoản: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiem(string search, DTO_TaiKhoan tk)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM TaiKhoan WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Email_TaiKhoan LIKE '%' + @Search + '%'";
            if (tk != null)
            {
                if (tk.ID_TaiKhoan > 0)
                    thucthi += " AND ID_TaiKhoan = @ID_TaiKhoan";
                if (!string.IsNullOrEmpty(tk.Email_TaiKhoan))
                    thucthi += " AND Email_TaiKhoan LIKE '%' + @Email_TaiKhoan + '%'";
                if (!string.IsNullOrEmpty(tk.Role_TaiKhoan))
                    thucthi += " AND Role_TaiKhoan = @Role_TaiKhoan ";
                if (!string.IsNullOrEmpty(tk.Ban_TaiKhoan.ToString()))
                    thucthi += " AND Ban_TaiKhoan =@Ban_TaiKhoan ";
            }
            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);
            if (tk != null)
            {
                cmd.Parameters.AddWithValue("@ID_TaiKhoan", tk.ID_TaiKhoan);
                cmd.Parameters.AddWithValue("@Emai_TaiKhoan", tk.Email_TaiKhoan);
                cmd.Parameters.AddWithValue("@Role_TaiKhoan", tk.Role_TaiKhoan);
                cmd.Parameters.AddWithValue("@Ban_TaiKhoan", tk.Ban_TaiKhoan);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
