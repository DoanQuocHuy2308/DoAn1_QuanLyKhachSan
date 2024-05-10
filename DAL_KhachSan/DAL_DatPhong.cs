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
    public class DAL_DatPhong
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable HienThiDatPhong()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT*FROM DatPhong";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable KTPhongTrong(DTO_DatPhong dp)
        {
            dt = new DataTable();
            try
            {
                kn.moketnoi();
                cmd = new SqlCommand("KTPhongTrong", DAL_KetNoi.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                using (da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
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
        public bool KTTrungMaKH(DTO_DatPhong dp)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DatPhong WHERE ID_KhachHang = @ID_KhachHang And Check_In <= @Check_Out AND Check_Out >= @Check_In";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhachHang", dp.ID_KhachHang);
                    cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                    cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin đặt phòng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public bool KTTrungMaP(DTO_DatPhong dp)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DatPhong WHERE ID_Phong = @ID_Phong And Check_In <= @Check_Out AND Check_Out >= @Check_In";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_Phong", dp.ID_Phong);
                    cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                    cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin đặt phòng: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public decimal LayGiaTriKhuyenMai(DTO_DatPhong dp)
        {
            decimal giaTri = 0;
            kn.moketnoi();
            string thucthi = "SELECT GiaTri FROM KhuyenMai WHERE ID_KhuyenMai = @ID_KhuyenMai";
            using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", dp.ID_KhuyenMai);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    giaTri = Convert.ToDecimal(result);
                }
            }
            return giaTri;
        }
        public decimal LayGiaTienPhong(DTO_DatPhong dp)
        {
            decimal giaTriPhong = 0;
            kn.moketnoi();
            string thucthi = "select Gia_Phong from Phong as p inner join LoaiPhong as lp on lp.ID_LoaiPhong= p.ID_LoaiPhong where ID_Phong = @ID_Phong";
            using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
            {
                cmd.Parameters.AddWithValue("@ID_Phong", dp.ID_Phong);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    giaTriPhong = Convert.ToDecimal(result);
                }
            }
            return giaTriPhong;
        }
        public void Check_In(DTO_DatPhong dp)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "INSERT INTO DatPhong (ID_NhanVien, ID_KhachHang, ID_Phong, ID_KhuyenMai, Check_In, Check_Out, TienCoc, TongTien, TrangThai, HinhThucThanhToan, KetQua) VALUES (@ID_NhanVien, @ID_KhachHang, @ID_Phong, @ID_KhuyenMai, @Check_In, @Check_Out, @TienCoc, @TongTien, @TrangThai, @HinhThucThanhToan, @KetQua)";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_NhanVien", dp.ID_NhanVien);
                    cmd.Parameters.AddWithValue("@ID_KhachHang", dp.ID_KhachHang);
                    cmd.Parameters.AddWithValue("@ID_Phong", dp.ID_Phong);
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", dp.ID_KhuyenMai);
                    cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                    cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                    cmd.Parameters.AddWithValue("@TienCoc", dp.TienCoc);
                    cmd.Parameters.AddWithValue("@TongTien", dp.TongTien);
                    cmd.Parameters.AddWithValue("@TrangThai", dp.TrangThai);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", dp.HinhThucThanhToan);
                    cmd.Parameters.AddWithValue("@KetQua", dp.KetQua);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đặt phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Update(DTO_DatPhong dp)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "UPDATE DatPhong SET ID_NhanVien=@ID_NhanVien, ID_KhachHang=@ID_KhachHang, ID_Phong=@ID_Phong, ID_KhuyenMai=@ID_KhuyenMai, Check_In=@Check_In, Check_Out=@Check_Out, TienCoc=@TienCoc, TongTien=@TongTien, TrangThai=@TrangThai, HinhThucThanhToan=@HinhThucThanhToan, KetQua=@KetQua WHERE ID_DatPhong=@ID_DatPhong";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DatPhong", dp.ID_DatPhong);
                    cmd.Parameters.AddWithValue("@ID_NhanVien", dp.ID_NhanVien);
                    cmd.Parameters.AddWithValue("@ID_KhachHang", dp.ID_KhachHang);
                    cmd.Parameters.AddWithValue("@ID_Phong", dp.ID_Phong);
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", dp.ID_KhuyenMai);
                    cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                    cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                    cmd.Parameters.AddWithValue("@TienCoc", dp.TienCoc);
                    cmd.Parameters.AddWithValue("@TongTien", dp.TongTien);
                    cmd.Parameters.AddWithValue("@TrangThai", dp.TrangThai);
                    cmd.Parameters.AddWithValue("@HinhThucThanhToan", dp.HinhThucThanhToan);
                    cmd.Parameters.AddWithValue("@KetQua", dp.KetQua);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa đặt phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public void Check_Out(DTO_DatPhong dp)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "DELETE FROM DatPhong WHERE ID_DatPhong=@ID_DatPhong";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_DatPhong", dp.ID_DatPhong);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa đặt phòng: " + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }
        public DataTable TimKiem(string search, DTO_DatPhong dp)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM DatPhong WHERE 1=1";
            if (!string.IsNullOrEmpty(search))
                thucthi += " AND ID_DatPhong = ID_DatPhong";
            if (dp != null)
            {
                if (dp.ID_DatPhong > 0)
                    thucthi += " AND ID_DatPhong = @ID_DatPhong";
                if (dp.ID_NhanVien > 0)
                    thucthi += " AND ID_NhanVien = @ID_NhanVien";
                if (dp.ID_KhachHang > 0)
                    thucthi += " AND ID_KhachHang = @ID_KhachHang";
                if (dp.ID_Phong > 0)
                    thucthi += " AND ID_Phong = @ID_Phong";
                if (!string.IsNullOrEmpty(dp.ID_KhuyenMai))
                    thucthi += " AND ID_KhuyenMai = @ID_KhuyenMai";
                if (dp.Check_In != DateTime.MinValue || dp.Check_Out != DateTime.MinValue)
                    thucthi += " AND Check_In >= @Check_In AND Check_Out <= @Check_Out";
                if (dp.TienCoc > 0)
                    thucthi += " AND TienCoc =@TienCoc";
                if (!string.IsNullOrEmpty(dp.TrangThai))
                    thucthi += " AND TrangThai = @TrangThai";
                if (!string.IsNullOrEmpty(dp.HinhThucThanhToan))
                    thucthi += " AND HinhThucThanhToan =@HinhThucThanhToan";
                if (!string.IsNullOrEmpty(dp.KetQua))
                    thucthi += " AND KetQua = @KetQua";
                cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
                cmd.Parameters.AddWithValue("@Search", search);
            }
            if (dp != null)
            {
                cmd.Parameters.AddWithValue("@ID_DatPhong", dp.ID_DatPhong);
                cmd.Parameters.AddWithValue("@ID_NhanVien", dp.ID_NhanVien);
                cmd.Parameters.AddWithValue("@ID_KhachHang", dp.ID_KhachHang);
                cmd.Parameters.AddWithValue("@ID_Phong", dp.ID_Phong);
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", dp.ID_KhuyenMai);
                cmd.Parameters.AddWithValue("@Check_In", dp.Check_In);
                cmd.Parameters.AddWithValue("@Check_Out", dp.Check_Out);
                cmd.Parameters.AddWithValue("@TienCoc", dp.TienCoc);
                cmd.Parameters.AddWithValue("@TrangThai", dp.TrangThai);
                cmd.Parameters.AddWithValue("@HinhThucThanhToan", dp.HinhThucThanhToan);
                cmd.Parameters.AddWithValue("@KetQua", dp.KetQua);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
