using DTO_KhachSan;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_KhachSan
{
    public class DAL_LoaiPhong
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable dulieuidloaiphong()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select ID_LoaiPhong From LoaiPhong";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable Dulieuloaiphong()
        {
            DataTable dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select*From LoaiPhong";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public bool KTTrungTen(DTO_LoaiPhong lp)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM LoaiPhong WHERE Ten_LoaiPhong = @Ten_LoaiPhong";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiPhong", lp.Ten_LoaiPhong);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin loại Phòng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void ThemLoaiPhong(DTO_LoaiPhong lp)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert Into LoaiPhong(Ten_LoaiPhong,SucChua,Gia_Phong) Values (@Ten_LoaiPhong,@SucChua,@Gia_Phong)";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiPhong", lp.Ten_LoaiPhong);
                    cmd.Parameters.AddWithValue("@SucChua", lp.SucChua);
                    cmd.Parameters.AddWithValue("@Gia_Phong", lp.Gia_Phong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm loại phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void UpdateLoaiPhong(DTO_LoaiPhong lp)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Update LoaiPhong set Ten_LoaiPhong=@Ten_LoaiPhong , SucChua=@SucChua,Gia_Phong=@Gia_Phong where ID_LoaiPhong=@ID_LoaiPhong";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_LoaiPhong", lp.ID_LoaiPhong);
                    cmd.Parameters.AddWithValue("@Ten_LoaiPhong", lp.Ten_LoaiPhong);
                    cmd.Parameters.AddWithValue("@SucChua", lp.SucChua);
                    cmd.Parameters.AddWithValue("@Gia_Phong", lp.Gia_Phong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin loại phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public bool KTIDTonTai(DTO_LoaiPhong lp)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM Phong WHERE ID_LoaiPhong = @ID_LoaiPhong";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_LoaiPhong", lp.ID_LoaiPhong);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin loại phòng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt; 
        }

        public void DeleteLoaiPhong(DTO_LoaiPhong lp)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Delete LoaiPhong where ID_LoaiPhong=@ID_LoaiPhong";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_LoaiPhong", lp.ID_LoaiPhong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin loại phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiemLoaiPhong(string search, DTO_LoaiPhong lp)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM LoaiPhong WHERE 1=1";

            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Ten_LoaiPhong LIKE '%' + @Search + '%'";

            if (lp != null)
            {
                if (lp.ID_LoaiPhong > 0)
                    thucthi += " AND ID_LoaiPhong = @ID_LoaiPhong";
                if (!string.IsNullOrEmpty(lp.Ten_LoaiPhong))
                    thucthi += " AND Ten_LoaiPhong LIKE '%' + @Ten_LoaiPhong + '%'";
                if (lp.SucChua > 0)
                    thucthi += " AND SucChua >= @SucChua";
                if (lp.Gia_Phong > 0)
                    thucthi += " AND Gia_Phong >= @Gia_Phong";
            }

            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);

            if (lp != null)
            {
                cmd.Parameters.AddWithValue("@ID_LoaiPhong", lp.ID_LoaiPhong);
                cmd.Parameters.AddWithValue("@Ten_LoaiPhong", lp.Ten_LoaiPhong);
                cmd.Parameters.AddWithValue("@SucChua", lp.SucChua);
                cmd.Parameters.AddWithValue("@Gia_Phong", lp.Gia_Phong);
            }

            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}

