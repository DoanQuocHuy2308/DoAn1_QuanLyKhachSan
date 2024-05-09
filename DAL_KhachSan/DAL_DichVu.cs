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
    public class DAL_DichVu
    {
        private DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable LayDuLieuDichVu()
        {
            dt = new DataTable();
            try
            {
                kn.moketnoi();
                using (cmd = new SqlCommand("HienThiDuLieuDichVu", DAL_KetNoi.sqlcon))
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
        public DataTable dulieuidloaidichvu()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select ID_LoaiDichVu From LoaiDichVu";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public void ThemDichVu(DTO_DichVu dv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Insert into DichVu(Ten_DichVu,ID_LoaiDichVu,Gia_DichVu) Values(@Ten_DichVu,@ID_LoaiDichVu,@Gia_DichVu) ";
                using(cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@Ten_DichVu", dv.Ten_DichVu);
                    cmd.Parameters.AddWithValue("@ID_LoaiDichVu", dv.ID_LoaiDichVu);
                    cmd.Parameters.AddWithValue("@Gia_DichVu", dv.Gia_DichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void UpdateDichVu(DTO_DichVu dv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "Update DichVu set Ten_DichVu=@Ten_DichVu,ID_LoaiDichVu=@ID_LoaiDichVu, Gia_DichVu= @Gia_DichVu where ID_DichVu=@ID_DichVu";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DichVu", dv.ID_DichVu);
                    cmd.Parameters.AddWithValue("@Ten_DichVu", dv.Ten_DichVu);
                    cmd.Parameters.AddWithValue("@ID_LoaiDichVu", dv.ID_LoaiDichVu);
                    cmd.Parameters.AddWithValue("@Gia_DichVu", dv.Gia_DichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public bool KTIDTonTai(DTO_DichVu dv)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DatDichVu WHERE ID_DichVu = @ID_DichVu";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DichVu", dv.ID_DichVu);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin dịch vụ: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void DeleteDichVu(DTO_DichVu dv)
        {
            try
            {
                KTIDTonTai(dv);
                kn.moketnoi();
                string thucthi = "Delete DichVu where ID_DichVu=@ID_DichVu";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DichVu", dv.ID_DichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiemDichVu(string search, int? idDichVu, string tenDichVu, int? idLoaiDichVu, decimal? GiaDichVu)
        {
            dt = new DataTable();
            kn.moketnoi();
            cmd = new SqlCommand("TimKiemDichVu", DAL_KetNoi.sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Search", search);
            cmd.Parameters.AddWithValue("@IDDichVu", idDichVu);
            cmd.Parameters.AddWithValue("@TenDichVu", tenDichVu);
            cmd.Parameters.AddWithValue("@IDLoaiDichVu", idLoaiDichVu);
            cmd.Parameters.AddWithValue("@GiaDichVu",GiaDichVu);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
