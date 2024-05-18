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
    public class DAL_KhuyenMai
    {
        DAL_KetNoi kn = new DAL_KetNoi();
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        public DataTable DuLieuKhuyenMai()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "Select * from KhuyenMai";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public DataTable KiemTraKhuyenMai()
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM KhuyenMai WHERE GETDATE() BETWEEN NgayBatDau AND NgayKetThuc";
            da = new SqlDataAdapter(thucthi, DAL_KetNoi.sqlcon);
            da.Fill(dt);
            return dt;
        }
        public void Add(DTO_KhuyenMai km)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "INSERT INTO KhuyenMai(ID_KhuyenMai,Ten_KhuyenMai,GiaTri,MoTa,NgayBatDau,NgayKetThuc) Values (@Ten_KhuyenMai,@GiaTri,@MoTa,@NgayBatDau,@NgayKetThuc)";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", km.ID_KhuyenMai);
                    cmd.Parameters.AddWithValue("@Ten_KhuyenMai", km.Ten_KhuyenMai);
                    cmd.Parameters.AddWithValue("@GiaTri", km.GiaTri);
                    cmd.Parameters.AddWithValue("@MoTa", km.MoTa);
                    cmd.Parameters.AddWithValue("@NgayBatDau", km.NgayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", km.NgayKetThuc);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi khi thêm khuyến mại" + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
        public void Update(DTO_KhuyenMai km)
        {
            try
            {
                kn.moketnoi();
                string thucthi = " UPDATE KhuyenMai SET Ten_KhuyenMai=@Ten_KhuyenMai,GiaTri=@GiaTri,MoTa=@MoTa,NgayBatDau=@NgayBatDau,NgayKetThuc=@NgayKetThuc WHERE ID_KhuyenMai = @ID_KhuyenMai";
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", km.ID_KhuyenMai);
                    cmd.Parameters.AddWithValue("@Ten_KhuyenMai", km.Ten_KhuyenMai);
                    cmd.Parameters.AddWithValue("@GiaTri", km.GiaTri);
                    cmd.Parameters.AddWithValue("@MoTa", km.MoTa);
                    cmd.Parameters.AddWithValue("@NgayBatDau", km.NgayBatDau);
                    cmd.Parameters.AddWithValue("@NgayKetThuc", km.NgayKetThuc);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("lỗi khi sửa thông tin khuyến mại" + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
        }
        public bool KTIDTonTaiDP(DTO_KhuyenMai km)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DatPhong WHERE ID_KhuyenMai = @ID_KhuyenMai";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", km.ID_KhuyenMai);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin Khuyến Mại: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public bool KTIDTonTaiDDV(DTO_KhuyenMai km)
        {
            bool kt = false;
            try
            {
                kn.moketnoi();
                string thucthi = "SELECT COUNT(*) FROM DatDichVu WHERE ID_KhuyenMai = @ID_KhuyenMai";
                int count;
                using (cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", km.ID_KhuyenMai);
                    count = (int)cmd.ExecuteScalar();
                }
                kt = count > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin Khuyến Mại: " + ex.Message);
            }
            finally
            {
                kn.dongketnoi();
            }
            return kt;
        }
        public void Delete(DTO_KhuyenMai km)
        {
            try
            {
                kn.moketnoi();
                string thucthi = "DELETE FROM KhuyenMai Where ID_KhuyenMai=@ID_KhuyenMai";
                using(cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon))
                {
                    cmd.Parameters.AddWithValue("@ID_KhuyenMai", km.ID_KhuyenMai);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("lỗi khi xóa thông tin khuyến mại" + ex.Message);
            }
            finally { kn.dongketnoi(); }
        }

        public DataTable TimKiemKhuyenMai(string search, DTO_KhuyenMai km)
        {
            dt = new DataTable();
            kn.moketnoi();
            string thucthi = "SELECT * FROM KhuyenMai WHERE 1=1";

            if (!string.IsNullOrEmpty(search))
                thucthi += " AND Ten_KhuyenMai LIKE '%' + @Search + '%'";

            if (km != null)
            {
                if (!string.IsNullOrEmpty(km.ID_KhuyenMai))
                    thucthi += " AND ID_KhuyenMai = @ID_KhuyenMai";

                if (!string.IsNullOrEmpty(km.Ten_KhuyenMai))
                    thucthi += " AND Ten_KhuyenMai LIKE '%' + @Ten_KhuyenMai + '%'";

                if (!string.IsNullOrEmpty(km.MoTa))
                    thucthi += " AND MoTa LIKE '%' + @MoTa + '%'";

                if (km.NgayBatDau != DateTime.Now && km.NgayKetThuc != DateTime.Now)
                    thucthi += " AND NgayBatDau >= @NgayBatDau AND NgayKetThuc <= @NgayKetThuc";

                if (km.GiaTri > 0)
                    thucthi += " AND GiaTri >= @GiaTri ";

            }
            cmd = new SqlCommand(thucthi, DAL_KetNoi.sqlcon);
            cmd.Parameters.AddWithValue("@Search", search);
            if (km != null)
            {
                cmd.Parameters.AddWithValue("@ID_KhuyenMai", km.ID_KhuyenMai);
                cmd.Parameters.AddWithValue("@Ten_KhuyenMai", km.Ten_KhuyenMai);
                cmd.Parameters.AddWithValue("@GiaTri", km.GiaTri);
                cmd.Parameters.AddWithValue("@MoTa", km.MoTa);
                cmd.Parameters.AddWithValue("@NgayBatDau", km.NgayBatDau);
                cmd.Parameters.AddWithValue("@NgayKetThuc", km.NgayKetThuc);
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
