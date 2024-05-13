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
            try
            {
                kn.moketnoi();
                using (cmd = new SqlCommand("HienThiDuLieuPhong", DAL_KetNoi.sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
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
        public DataTable TimKiemPhong(string search, int? idPhong, string tenPhong, int? idLoaiPhong)
        {
            dt = new DataTable();
            kn.moketnoi();
            cmd = new SqlCommand("TimKiemPhong", DAL_KetNoi.sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", search);
            cmd.Parameters.AddWithValue("@IDPhong", idPhong);
            cmd.Parameters.AddWithValue("@TenPhong", tenPhong);
            cmd.Parameters.AddWithValue("@IDLoaiPhong", idLoaiPhong);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
