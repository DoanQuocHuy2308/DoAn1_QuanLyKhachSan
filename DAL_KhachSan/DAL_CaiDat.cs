using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_KhachSan;

namespace DAL_KhachSan
{
    public class DAL_CaiDat
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable HienEmail(DTO_TaiKhoan tk)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM TaiKhoan WHERE Email_TaiKhoan = @Email_TaiKhoan";
            using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable HienCMND(DTO_NhanVien nv)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select ID_NhanVien,Ten_NhanVien,CMND_NhanVien,GioiTinh_NhanVien,SDT_NhanVien,Email_NhanVien,DiaChi_NhanVien,Role_NhanVien from NhanVien Where CMND_NhanVien=@CMND_NhanVien";
            using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@CMND_NhanVien", nv.CMND_NhanVien);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }
        public void CapNhatTaiKhoan(DTO_TaiKhoan tk)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE TaiKhoan SET Email_TaiKhoan=@Email_TaiKhoan, Pass_TaiKhoan=@Pass_TaiKhoan WHERE ID_TaiKhoan = @ID_TaiKhoan ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_TaiKhoan", tk.ID_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Email_TaiKhoan", tk.Email_TaiKhoan);
                    cmd.Parameters.AddWithValue("@Pass_TaiKhoan", tk.Pass_TaiKhoan);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin tài khoản đăng nhập: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void CapNhatNhanVien(DTO_NhanVien nv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE NhanVien SET Ten_NhanVien = @Ten_NhanVien,CMND_NhanVien=@CMND_NhanVien,SDT_NhanVien=@SDT_NhanVien,GioiTinh_NhanVien=@GioiTinh_NhanVien,Email_NhanVien=@Email_NhanVien,DiaChi_NhanVien=@DiaChi_NhanVien , Role_NhanVien=@Role_NhanVien WHERE ID_NhanVien = @ID_NhanVien ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_NhanVien", nv.ID_NhanVien);
                    cmd.Parameters.AddWithValue("@Ten_NhanVien", nv.Ten_NhanVien);
                    cmd.Parameters.AddWithValue("@CMND_NhanVien", nv.CMND_NhanVien);
                    cmd.Parameters.AddWithValue("@SDT_NhanVien", nv.SDT_NhanVien);
                    cmd.Parameters.AddWithValue("@GioiTinh_NhanVien", nv.GioiTinh_NhanVien);
                    cmd.Parameters.AddWithValue("@Email_NhanVien", nv.Email_NhanVien);
                    cmd.Parameters.AddWithValue("@DiaChi_NhanVien", nv.DiaChi_NhanVien);
                    cmd.Parameters.AddWithValue("@Role_NhanVien", nv.Role_NhanVien);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin nhân viên: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
    }
}
