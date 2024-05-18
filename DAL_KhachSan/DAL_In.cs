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
        public DataTable InThongKeDonDatPhong(DTO_DatPhong dp, DTO_Phong p, DTO_LoaiPhong lp)
        {
            dt = new DataTable();
            kn.moketnoi();

            using (cmd = new SqlCommand("ThongKeDonDatPhong", DAL_KetNoi.sqlcon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (dp.Check_In != DateTime.MinValue && dp.Check_Out != DateTime.MinValue && dp.Check_In < dp.Check_Out)
                {
                    cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                    cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Check_In", DBNull.Value);
                    cmd.Parameters.AddWithValue("@Check_Out", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(p.Ten_Phong))
                {
                    cmd.Parameters.AddWithValue("@Ten_Phong", p.Ten_Phong);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Ten_Phong", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(lp.Ten_LoaiPhong))
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiPhong", lp.Ten_LoaiPhong);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiPhong", DBNull.Value);
                }
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
        public DataTable InThongKeDonDatDichVu(DTO_DatDichVu ddv, DTO_DichVu dv, DTO_LoaiDichVu ldv, DateTime ngayketthuc)
        {
            dt = new DataTable();
            kn.moketnoi();

            using (cmd = new SqlCommand("ThongKeDonDatDichVu", DAL_KetNoi.sqlcon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (ddv.NgayDat != DateTime.MinValue && ngayketthuc != DateTime.MinValue && ddv.NgayDat < ngayketthuc)
                {
                    cmd.Parameters.AddWithValue("@NgayBatDau", ddv.NgayDat);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@NgayBatDau", DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(dv.Ten_DichVu))
                {
                    cmd.Parameters.AddWithValue("@Ten_DichVu", dv.Ten_DichVu);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Ten_DichVu", DBNull.Value);
                }

                if (!string.IsNullOrEmpty(ldv.Ten_LoaiDichVu))
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiDichVu", ldv.Ten_LoaiDichVu);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Ten_LoaiDichVu", DBNull.Value);
                }
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
