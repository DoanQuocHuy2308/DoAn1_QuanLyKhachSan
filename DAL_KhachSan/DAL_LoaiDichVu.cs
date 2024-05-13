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
    public class DAL_LoaiDichVu
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable Dulieuloaidichvu()
        {
            DataTable dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select*From LoaiDichVu";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public bool KTTrungTen(DTO_LoaiDichVu ldv)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM LoaiDichVu WHERE Ten_LoaiDichVu = @Ten_LoaiDichVu";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiDichVu", ldv.Ten_LoaiDichVu);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin loại dịch vụ: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void ThemLoaiDichVu(DTO_LoaiDichVu ldv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert into LoaiDichVu(Ten_LoaiDichVu) Values(@Ten_LoaiDichVu) ";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiDichVu", ldv.Ten_LoaiDichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm loại dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void UpdateLoaiDichVu(DTO_LoaiDichVu ldv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Update LoaiDichVu set Ten_LoaiDichVu=@Ten_LoaiDichVu where ID_LoaiDichVu=@ID_LoaiDichVu";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_LoaiDichVu", ldv.ID_LoaiDichVu);
                    cmd.Parameters.AddWithValue("@Ten_LoaiDichVu", ldv.Ten_LoaiDichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin loại dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public bool KTIDTonTai(DTO_LoaiDichVu ldv)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DichVu WHERE ID_LoaiDichVu = @ID_LoaiDichVu";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_LoaiDichVu", ldv.ID_LoaiDichVu);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin loại dịch vụ: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void DeleteLoaiDichVu(DTO_LoaiDichVu ldv)
        {
            try
            {
                KTIDTonTai(ldv);
                kn.moketnoi();
                string thucthi = "Delete LoaiDichVu where ID_LoaiDichVu=@ID_LoaiDichVu";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_LoaiDichVu", ldv.ID_LoaiDichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin loại dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiemLoaiDichVu(string search, DTO_LoaiDichVu ldv)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM LoaiDichVu WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Ten_LoaiDichVu LIKE '%' + @Search + '%'";
            if (ldv != null)
            {
                if (ldv.ID_LoaiDichVu > 0)
                    thucthi += " AND ID_LoaiDichVu = @ID_LoaiDichVu";
                if (!string.IsNullOrEmpty(ldv.Ten_LoaiDichVu))
                    thucthi += " AND Ten_LoaiDichVu LIKE '%' + @Ten_LoaiDichVu + '%'";
            }
            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);
            if (ldv != null)
            {
                cmd.Parameters.AddWithValue("@ID_LoaiDichVu", ldv.ID_LoaiDichVu);
                cmd.Parameters.AddWithValue("@Ten_LoaiDichVu", ldv.Ten_LoaiDichVu);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
