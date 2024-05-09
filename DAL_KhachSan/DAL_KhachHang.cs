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
    public class DAL_KhachHang
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable DuLieuKhachHang()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select * from KhachHang";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public bool KTCMND(DTO_KhachHang kh)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM KhachHang WHERE CMND_KhachHang = @CMND_KhachHang";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@CMND_KhachHang", kh.CMND_KhachHang);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin khách hàng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void ADD(DTO_KhachHang kh)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert into KhachHang(Ten_KhachHang,Tuoi_KhachHang,CMND_KhachHang,GioiTinh_KhachHang,Email_KhachHang,SDT_KhachHang,DiaChi_KhachHang) Values (@Ten_KhachHang,@Tuoi_KhachHang,@CMND_KhachHang,@GioiTinh_KhachHang,@Email_KhachHang,@SDT_KhachHang,@DiaChi_KhachHang) ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_KhachHang", kh.Ten_KhachHang);
                    cmd.Parameters.AddWithValue("@Tuoi_KhachHang", kh.Tuoi_KhachHang);
                    cmd.Parameters.AddWithValue("@CMND_KhachHang", kh.CMND_KhachHang);
                    cmd.Parameters.AddWithValue("@GioiTinh_KhachHang", kh.GioiTinh_KhachHang);
                    cmd.Parameters.AddWithValue("@Email_KhachHang", kh.Email_KhachHang);
                    cmd.Parameters.AddWithValue("@SDT_KhachHang", kh.SDT_KhachHang);
                    cmd.Parameters.AddWithValue("@DiaChi_KhachHang", kh.DiaChi_KhachHang);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khách hàng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Update(DTO_KhachHang kh)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE KhachHang SET Ten_KhachHang=@Ten_KhachHang,Tuoi_KhachHang=@Tuoi_KhachHang,CMND_KhachHang=@CMND_KhachHang,GioiTinh_KhachHang=@GioiTinh_KhachHang,Email_KhachHang=@Email_KhachHang,SDT_KhachHang=@SDT_KhachHang,DiaChi_KhachHang=@DiaChi_KhachHang WHERE ID_KhachHang = @ID_KhachHang ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhachHang", kh.ID_KhachHang);
                    cmd.Parameters.AddWithValue("@Ten_KhachHang", kh.Ten_KhachHang);
                    cmd.Parameters.AddWithValue("@Tuoi_KhachHang", kh.Tuoi_KhachHang);
                    cmd.Parameters.AddWithValue("@CMND_KhachHang", kh.CMND_KhachHang);
                    cmd.Parameters.AddWithValue("@GioiTinh_KhachHang", kh.GioiTinh_KhachHang);
                    cmd.Parameters.AddWithValue("@Email_KhachHang", kh.Email_KhachHang);
                    cmd.Parameters.AddWithValue("@SDT_KhachHang", kh.SDT_KhachHang);
                    cmd.Parameters.AddWithValue("@DiaChi_KhachHang", kh.DiaChi_KhachHang);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin khách hàng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Delete(DTO_KhachHang kh)
        {
            try
            {
                kn.moketnoi();
                using (cmd = new SqlCommand("DeleteKhachHang", DAL_KetNoi.sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_KhachHang", kh.ID_KhachHang);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tài khoản và nhân viên: " + ex.Message);
            }
        }
        public DataTable TimKiem(string search, DTO_KhachHang kh)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM KhachHang WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Ten_KhachHang LIKE '%' + @Search + '%'";
            if (kh != null)
            {
                if (kh.ID_KhachHang > 0)
                    thucthi += " AND ID_KhachHang = @ID_KhachHang";
                if (!string.IsNullOrEmpty(kh.Ten_KhachHang))
                    thucthi += " AND Ten_KhachHang LIKE '%' + @Ten_KhachHang + '%'";
                if (kh.Tuoi_KhachHang >0)
                    thucthi += " AND Tuoi_KhachHang = @Tuoi_KhachHang ";
                if (!string.IsNullOrEmpty(kh.CMND_KhachHang))
                    thucthi += " AND CMND_KhachHang = @CMND_KhachHang ";
                if (!string.IsNullOrEmpty(kh.GioiTinh_KhachHang))
                    thucthi += " AND GioiTinh_KhachHang = @GioiTinh_KhachHang";
                if (!string.IsNullOrEmpty(kh.Email_KhachHang))
                    thucthi += " AND Email_KhachHang LIKE '%' + @Email_KhachHang + '%'";
                if (!string.IsNullOrEmpty(kh.SDT_KhachHang))
                    thucthi += " AND SDT_KhachHang = @SDT_KhachHang";
                if (!string.IsNullOrEmpty(kh.DiaChi_KhachHang))
                    thucthi += " AND DiaChi_KhachHang LIKE '%' + @DiaChi_KhachHang + '%'";
            }
            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);
            if (kh != null)
            {
                cmd.Parameters.AddWithValue("@ID_KhachHang", kh.ID_KhachHang);
                cmd.Parameters.AddWithValue("@Ten_KhachHang", kh.Ten_KhachHang);
                cmd.Parameters.AddWithValue("@Tuoi_KhachHang", kh.Tuoi_KhachHang);
                cmd.Parameters.AddWithValue("@CMND_KhachHang", kh.CMND_KhachHang);
                cmd.Parameters.AddWithValue("@GioiTinh_KhachHang", kh.GioiTinh_KhachHang);
                cmd.Parameters.AddWithValue("@Email_KhachHang", kh.Email_KhachHang);
                cmd.Parameters.AddWithValue("@SDT_KhachHang", kh.SDT_KhachHang);
                cmd.Parameters.AddWithValue("@DiaChi_KhachHang", kh.DiaChi_KhachHang);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
