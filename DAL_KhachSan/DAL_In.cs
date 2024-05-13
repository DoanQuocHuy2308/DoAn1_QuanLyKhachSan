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
    public class DAL_In
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable InPhongDat(DTO_DatPhong dp)
        {
            dt = new DataTable();
            try
            {
                kn.moketnoi();
                using (cmd = new SqlCommand("InPhongDat", DAL_KetNoi.sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDatPhong", dp.ID_DatPhong);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị phòng đặt: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
        public DataTable InHoaDonDatPhong(DTO_DatPhong dp)
        {
            dt = new DataTable();
            try
            {
                kn.moketnoi();
                using (cmd = new SqlCommand("InDonDatPhong", DAL_KetNoi.sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDDatPhong", dp.ID_DatPhong);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị phòng đặt: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
        public DataTable InHoaDonDatDichVu(DTO_DatDichVu ddv)
        {
            dt = new DataTable();
            try
            {
                kn.moketnoi();
                using (cmd = new SqlCommand("InDonDatDichVu",DAL_KetNoi.sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDKhachHang", ddv.ID_KhachHang);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi hiển thị dịch vụ đặt: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
    }
}
