using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_KhachSan
{
     public class DAL_Phong
    {
        private DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable LayDuLieuPhong()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "select ID_Phong,Ten_Phong,lp.ID_LoaiPhong,Ten_LoaiPhong,SucChua,Gia_Phong from Phong as p " +
                "inner join LoaiPhong as lp on lp.ID_LoaiPhong= p.ID_LoaiPhong";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public bool KTTrungTen(DTO_Phong p)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM Phong WHERE Ten_Phong = @Ten_Phong";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_Phong", p.Ten_Phong);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin Phòng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void ThemPhong(DTO_Phong p)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert Into Phong(Ten_Phong,ID_LoaiPhong) Values (@Ten_Phong,@ID_LoaiPhong)";
                using(cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_Phong", p.Ten_Phong);
                    cmd.Parameters.AddWithValue("ID_LoaiPhong", p.ID_LoaiPhong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi thêm phòng: "+ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void UpdatePhong(DTO_Phong p)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Update Phong set Ten_Phong=@Ten_Phong,ID_LoaiPhong=@ID_LoaiPhong where ID_Phong=@ID_Phong";
                using(cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_Phong", p.ID_Phong);
                    cmd.Parameters.AddWithValue("@Ten_Phong", p.Ten_Phong);
                    cmd.Parameters.AddWithValue("@ID_LoaiPhong", p.ID_LoaiPhong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin phòng: " + ex.Message);
            }
            finally { kn.dongketnoi();}
        }
        public bool KTIDTonTai(DTO_Phong p)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DatPhong WHERE ID_Phong = @ID_Phong";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_Phong", p.ID_Phong);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin phòng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void DeletePhong(DTO_Phong p)
        {
            try
            {
                KTIDTonTai(p);
                kn.moketnoi();
                string thucthi = "Delete Phong where ID_Phong=@ID_Phong";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_Phong", p.ID_Phong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiem(string search, DTO_Phong p)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM Phong WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Ten_Phong LIKE '%' + @Search + '%'";
            if (p != null)
            {
                if (p.ID_Phong > 0)
                    thucthi += " AND ID_Phong = @ID_Phong";
                if (!string.IsNullOrEmpty(p.Ten_Phong))
                    thucthi += " AND Ten_Phong LIKE '%' + @Ten_Phong + '%'";
                if (p.ID_LoaiPhong > 0)
                    thucthi += " AND ID_LoaiPhong = @ID_LoaiPhong ";
            }
            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);
            if (p != null)
            {
                cmd.Parameters.AddWithValue("@ID_Phong", p.ID_Phong);
                cmd.Parameters.AddWithValue("@Ten_Phong", p.Ten_Phong);
                cmd.Parameters.AddWithValue("@ID_LoaiPhong", p.ID_LoaiPhong);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
