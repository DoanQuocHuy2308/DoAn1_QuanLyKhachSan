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
    public class DAL_NhanVien
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable DuLieuNhanvien()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select ID_NhanVien,Ten_NhanVien,CMND_NhanVien,GioiTinh_NhanVien,SDT_NhanVien,Email_NhanVien,DiaChi_NhanVien,Role_NhanVien from NhanVien";
            da = new SqlDataAdapter(thucthi,DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public bool KTEmail(DTO_NhanVien nv)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM NhanVien WHERE Email_NhanVien = @Email_NhanVien";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Email_NhanVien", nv.Email_NhanVien);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }

        public void ADD(DTO_NhanVien nv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert into NhanVien(Ten_NhanVien,CMND_NhanVien,SDT_NhanVien,GioiTinh_NhanVien,Email_NhanVien,DiaChi_NhanVien,Role_NhanVien) Values (@Ten_NhanVien,@CMND_NhanVien,@SDT_NhanVien,@GioiTinh_NhanVien,@Email_NhanVien,@DiaChi_NhanVien,@Role_NhanVien) ";
                using(cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
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
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Update(DTO_NhanVien nv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE NhanVien SET Ten_NhanVien = @Ten_NhanVien,CMND_NhanVien=@CMND_NhanVien,SDT_NhanVien=@SDT_NhanVien,GioiTinh_NhanVien=@GioiTinh_NhanVien,Email_NhanVien=@Email_NhanVien,DiaChi_NhanVien=@DiaChi_NhanVien , Role_NhanVien=@Role_NhanVien WHERE ID_NhanVien = @ID_NhanVien ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_NhanVien",nv.ID_NhanVien);
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
        public bool KTIDTonTai(DTO_NhanVien nv)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM HoaDon WHERE ID_NhanVien = @ID_NhanVien";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_NhanVien", nv.ID_NhanVien);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin nhân viên: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void Delete(DTO_NhanVien nv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Delete NhanVien where ID_NhanVien=@ID_NhanVien";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_NhanVien", nv.ID_NhanVien);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin nhân viên: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiem(string search, DTO_NhanVien nv)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM NhanVien WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Ten_NhanVien LIKE '%' + @Search + '%'";
            if (nv != null)
            {
                if (nv.ID_NhanVien > 0)
                    thucthi += " AND ID_NhanVien = @ID_NhanVien";
                if (!string.IsNullOrEmpty(nv.Ten_NhanVien))
                    thucthi += " AND Ten_NhanVien LIKE '%' + @Ten_NhanVien + '%'";
                if (!string.IsNullOrEmpty(nv.SDT_NhanVien))
                    thucthi += " AND SDT_NhanVien = @SDT_NhanVien ";
                if (!string.IsNullOrEmpty(nv.CMND_NhanVien))
                    thucthi += " AND CMND_NhanVien = @CMND_NhanVien ";
                if (!string.IsNullOrEmpty(nv.GioiTinh_NhanVien))
                    thucthi += " AND GioiTinh_NhanVien = @GioiTinh_NhanVien";
                if (!string.IsNullOrEmpty(nv.Email_NhanVien))
                    thucthi += " AND Email_NhanVien LIKE '%' + @Email_NhanVien + '%'";
                if (!string.IsNullOrEmpty(nv.DiaChi_NhanVien))
                    thucthi += " AND DiaChi_NhanVien LIKE '%' + @DiaChi_NhanVien + '%'";
                if (!string.IsNullOrEmpty(nv.Role_NhanVien))
                    thucthi += " AND Role_NhanVien LIKE '%' + @Role_NhanVien + '%'";
            }
            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);
            if (nv != null)
            {
                cmd.Parameters.AddWithValue("@ID_NhanVien", nv.ID_NhanVien);
                cmd.Parameters.AddWithValue("@Ten_NhanVien", nv.Ten_NhanVien);
                cmd.Parameters.AddWithValue("@CMND_NhanVien", nv.CMND_NhanVien);
                cmd.Parameters.AddWithValue("@SDT_NhanVien", nv.SDT_NhanVien);
                cmd.Parameters.AddWithValue("@GioiTinh_NhanVien", nv.GioiTinh_NhanVien);
                cmd.Parameters.AddWithValue("@Email_NhanVien", nv.Email_NhanVien);
                cmd.Parameters.AddWithValue("@DiaChi_NhanVien", nv.DiaChi_NhanVien);
                cmd.Parameters.AddWithValue("@Role_NhanVien", nv.Role_NhanVien);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
