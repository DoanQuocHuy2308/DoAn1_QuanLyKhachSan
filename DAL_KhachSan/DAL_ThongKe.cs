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
    public class DAL_ThongKe
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable TenPhong()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select Ten_Phong From Phong";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable TenLoaiPhong()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select Ten_LoaiPhong From LoaiPhong";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable DuLieuDonDatPhong()
        {
            DataTable dt = new DataTable();
            kn.moketnoi();

            string thucthi = "SELECT dp.ID_DatPhong, p.Ten_Phong, lp.Ten_LoaiPhong, kh.Ten_KhachHang, " +
                             "kh.SDT_KhachHang, dp.Check_In, dp.Check_Out, dp.TienCoc, km.Ten_KhuyenMai, dp.TongTien " +
                             "FROM DatPhong dp " +
                             "JOIN Phong p ON dp.ID_Phong = p.ID_Phong " +
                             "JOIN LoaiPhong lp ON p.ID_LoaiPhong = lp.ID_LoaiPhong " +
                             "JOIN KhachHang kh ON dp.ID_KhachHang = kh.ID_KhachHang " +
                             "LEFT JOIN KhuyenMai km ON dp.ID_KhuyenMai = km.ID_KhuyenMai;";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable ThongKeDonDatPhong(DTO_DatPhong dp, DTO_Phong p, DTO_LoaiPhong lp)
        {
            DataTable dt = new DataTable();
            kn.moketnoi();

            using (cmd = new SqlCommand("ThongKeDonDatPhong", DAL_KetNoi.sqlcon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (dp.Check_In != DateTime.MinValue && dp.Check_Out != DateTime.MinValue)
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
        public DataTable TenDichVu()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select Ten_DichVu From DichVu";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable TenLoaiDichVu()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select Ten_LoaiDichVu From LoaiDichVu";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable DuLieuDonDatDichVu()
        {
            dt = new DataTable();
            kn.moketnoi();

            string thucthi = "SELECT ddv.ID_DatDichVu, kh.Ten_KhachHang, kh.SDT_KhachHang, ddv.NgayDat, dv.Ten_DichVu, ldv.Ten_LoaiDichVu, " +
                             "ddv.SoLuong, km.Ten_KhuyenMai, ddv.TongTien " +
                             "FROM DatDichVu ddv " +
                             "JOIN DichVu dv ON dv.ID_DichVu = ddv.ID_DichVu " +
                             "JOIN LoaiDichVu ldv ON ldv.ID_LoaiDichVu = dv.ID_LoaiDichVu " +
                             "JOIN KhachHang kh ON ddv.ID_KhachHang = kh.ID_KhachHang " +
                             "LEFT JOIN KhuyenMai km ON ddv.ID_KhuyenMai = km.ID_KhuyenMai;";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable ThongKeDonDatDichVu(DTO_DatDichVu ddv, DTO_DichVu dv, DTO_LoaiDichVu ldv, DateTime ngayketthuc)
        {
            DataTable dt = new DataTable();
            kn.moketnoi();

            using (cmd = new SqlCommand("ThongKeDonDatDichVu", DAL_KetNoi.sqlcon))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (ddv.NgayDat != DateTime.MinValue && ngayketthuc != DateTime.MinValue)
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
