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
    public class DAL_DatDichVu
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable HienThiDatDichVu()
        {
            dt = new DataTable();
            string thucthi = "SELECT*FROM DatDichVu";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public decimal LayRaGiaTien(DTO_DatDichVu ddv)
        {
            decimal giaTriDichVu = 0;
            kn.moketnoi();
            string thucthi = "select Gia_DichVu from DichVu where ID_DichVu = @ID_DichVu";
            using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@ID_DichVu", ddv.ID_DichVu);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    giaTriDichVu = Convert.ToDecimal(result);
                }
            }
            return giaTriDichVu;
        }
        public decimal LayGiaTriKhuyenMai(DTO_DatDichVu ddv)
        {
            decimal giaTri = 0;
            kn.moketnoi();
            string thucthi = "SELECT GiaTri FROM KhuyenMai WHERE ID_KhuyenMai = @ID_KhuyenMai";
            using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", ddv.ID_KhuyenMai);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    giaTri = Convert.ToDecimal(result);
                }
            }
            return giaTri;
        }
        public void ThemDonDatDichVu(DTO_DatDichVu ddv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "INSERT INTO DatDichVu (ID_NhanVien, ID_KhachHang, ID_DichVu, ID_KhuyenMai, SoLuong, NgayDat, TongTien, TrangThai, HinhThucThanhToan, KetQua) VALUES (@ID_NhanVien, @ID_KhachHang, @ID_DichVu, @ID_KhuyenMai, @SoLuong, @NgayDat, @TongTien, @TrangThai, @HinhThucThanhToan, @KetQua)";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_NhanVien", ddv.ID_NhanVien);
                    cmd.Parameters.AddWithValue("@ID_KhachHang", ddv.ID_KhachHang);
                    cmd.Parameters.AddWithValue("@ID_DichVu", ddv.ID_DichVu);
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", ddv.ID_KhuyenMai);
                    cmd.Parameters.AddWithValue("@SoLuong", ddv.SoLuong);
                    cmd.Parameters.AddWithValue("@NgayDat", ddv.NgayDat);
                    cmd.Parameters.AddWithValue("@TongTien", ddv.TongTien);
                    cmd.Parameters.AddWithValue("@TrangThai", ddv.TrangThai);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", ddv.HinhThucThanhToan);
                    cmd.Parameters.AddWithValue("@KetQua", ddv.KetQua);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đặt phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Update(DTO_DatDichVu ddv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE DatDichVu SET ID_NhanVien=@ID_NhanVien, ID_KhachHang=@ID_KhachHang, ID_DichVu=@ID_DichVu, ID_KhuyenMai=@ID_KhuyenMai, SoLuong=@SoLuong, NgayDat=@NgayDat, TongTien=@TongTien, TrangThai=@TrangThai, HinhThucThanhToan=@HinhThucThanhToan, KetQua=@KetQua WHERE ID_DatDichVu=@ID_DatDichVu";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DatDichVu", ddv.ID_DatDichVu);
                    cmd.Parameters.AddWithValue("@ID_NhanVien", ddv.ID_NhanVien);
                    cmd.Parameters.AddWithValue("@ID_KhachHang", ddv.ID_KhachHang);
                    cmd.Parameters.AddWithValue("@ID_DichVu", ddv.ID_DichVu);
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", ddv.ID_KhuyenMai);
                    cmd.Parameters.AddWithValue("@SoLuong", ddv.SoLuong);
                    cmd.Parameters.AddWithValue("@NgayDat", ddv.NgayDat);
                    cmd.Parameters.AddWithValue("@TongTien", ddv.TongTien);
                    cmd.Parameters.AddWithValue("@TrangThai", ddv.TrangThai);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", ddv.HinhThucThanhToan);
                    cmd.Parameters.AddWithValue("@KetQua", ddv.KetQua);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa đặt dịch vụ " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Delete(DTO_DatDichVu ddv)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "DELETE FROM DatDichVu WHERE ID_DatDichVu=@ID_DatDichVu";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DatDichVu", ddv.ID_DatDichVu);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa đặt dịch vụ: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiem(string search, DTO_DatDichVu ddv)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM DatDichVu WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND ID_DatDichVu = ID_DatDichVu";
            if (ddv != null)
            {
                if (ddv.ID_DatDichVu > 0)
                    thucthi += " AND ID_DatDichVu = @ID_DatDichVu";
                if (ddv.ID_NhanVien > 0)
                    thucthi += " AND ID_NhanVien = @ID_NhanVien";
                if (ddv.ID_KhachHang > 0)
                    thucthi += " AND ID_KhachHang = @ID_KhachHang";
                if (ddv.ID_DichVu > 0)
                    thucthi += " AND ID_DichVu = @ID_DichVu";
                if (!string.IsNullOrEmpty(ddv.ID_KhuyenMai))
                    thucthi += " AND ID_KhuyenMai = @ID_KhuyenMai";
                if (ddv.NgayDat != DateTime.MinValue)
                    thucthi += " AND NgayDat >= @NgayDat";
                if (ddv.SoLuong > 0)
                    thucthi += " AND SoLuong =@SoLuong";
                if (!string.IsNullOrEmpty(ddv.TrangThai))
                    thucthi += " AND TrangThai = @TrangThai";
                if (!string.IsNullOrEmpty(ddv.HinhThucThanhToan))
                    thucthi += " AND HinhThucThanhToan =@HinhThucThanhToan";
                if (!string.IsNullOrEmpty(ddv.KetQua))
                    thucthi += " AND KetQua = @KetQua";
                cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
                cmd.Parameters.AddWithValue("@Search", search);
            }
            if (ddv != null)
            {
                cmd.Parameters.AddWithValue("@ID_DatDichVu", ddv.ID_DatDichVu);
                cmd.Parameters.AddWithValue("@ID_NhanVien", ddv.ID_NhanVien);
                cmd.Parameters.AddWithValue("@ID_KhachHang", ddv.ID_KhachHang);
                cmd.Parameters.AddWithValue("@ID_DichVu", ddv.ID_DichVu);
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", ddv.ID_KhuyenMai);
                cmd.Parameters.AddWithValue("@SoLuong", ddv.SoLuong);
                cmd.Parameters.AddWithValue("@NgayDat", ddv.NgayDat);
                cmd.Parameters.AddWithValue("@TongTien", ddv.TongTien);
                cmd.Parameters.AddWithValue("@TrangThai", ddv.TrangThai);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", ddv.HinhThucThanhToan);
                cmd.Parameters.AddWithValue("@KetQua", ddv.KetQua);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
