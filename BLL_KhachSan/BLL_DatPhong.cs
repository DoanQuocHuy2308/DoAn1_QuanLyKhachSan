using DAL_KhachSan;
using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_KhachSan
{
    public class BLL_DatPhong
    {
        DAL_DatPhong daldp = new DAL_DatPhong();
        public DataTable DuLieuDatPhong()
        {
            return daldp.HienThiDatPhong();
        }
        public DataTable KTPhongTrong(DTO_DatPhong dp)
        {
            return daldp.KTPhongTrong(dp);
        }
        public bool KTMaKH(DTO_DatPhong dp)
        {
            return daldp.KTTrungMaKH(dp);
        }
        public bool KTMaP(DTO_DatPhong dp)
        {
            return daldp.KTTrungMaP(dp);
        }

        public decimal LayGiaTriKhuyenMai(DTO_DatPhong dp)
        {
            return daldp.LayGiaTriKhuyenMai(dp);
        }

        public decimal LayGiaTienPhong(DTO_DatPhong dp)
        {
            return daldp.LayGiaTienPhong(dp);
        }

        public decimal TinhTongTienDatPhong(DTO_DatPhong dp)
        {
            decimal giaPhong = LayGiaTienPhong(dp);
            int soNgay = (int)(dp.Check_Out - dp.Check_In).TotalDays;
            decimal giamGia = 0;
            if (dp.ID_KhuyenMai >= 0)
            {
                giamGia = LayGiaTriKhuyenMai(dp);
            }
            dp.TongTien = ((giaPhong * soNgay) - (giamGia * (giaPhong * soNgay)) - dp.TienCoc);

            return dp.TongTien;
        }
        public void CheckIn(DTO_DatPhong dp)
        {
            try
            {
                daldp.Check_In(dp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đặt phòng: " + ex.Message);
            }
        }
        public void UPDATE(DTO_DatPhong dp)
        {
            try
            {
                daldp.Update(dp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin đặt phòng: " + ex.Message);
            }
        }
        public void CheckOut(DTO_DatPhong dp)
        {
            try
            {
                daldp.Check_Out(dp);
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin đặt phòng: " + ex.Message);
            }
        }
    }
}
