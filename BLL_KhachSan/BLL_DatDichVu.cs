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
    public class BLL_DatDichVu
    {
        DAL_DatDichVu dalddv = new DAL_DatDichVu();
        public DataTable DuLieuDatDichVu()
        {
            return dalddv.HienThiDatDichVu();
        }
        public void ThemDonDichVu(DTO_DatDichVu ddv)
        {
            try
            {
                dalddv.ThemDonDatDichVu(ddv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi đặt dịch vụ: " + ex.Message);
            }
        }
        public decimal LayGiaTienDichVu(DTO_DatDichVu ddv)
        {
            return dalddv.LayRaGiaTien(ddv);
        }
        public decimal LayGiaTriKhuyenMai(DTO_DatDichVu ddv)
        {
            return dalddv.LayGiaTriKhuyenMai(ddv);
        }
        public decimal TinhTongTienDatDichVu(DTO_DatDichVu ddv)
        {
            decimal giaDichVu = LayGiaTienDichVu(ddv);
            decimal giamGia = 0;
            if (!string.IsNullOrEmpty(ddv.TrangThai))
            {
                giamGia = LayGiaTriKhuyenMai(ddv);
            }
            ddv.TongTien = (giaDichVu * ddv.SoLuong) - (giamGia * (giaDichVu * ddv.SoLuong));

            return ddv.TongTien;
        }
        public void UPDATE(DTO_DatDichVu ddv)
        {
            try
            {
                dalddv.Update(ddv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin đặt dịch vụ: " + ex.Message);
            }
        }
        public void DELETE(DTO_DatDichVu ddv)
        {
            try
            {
                dalddv.Delete(ddv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin đặt dịch vụ: " + ex.Message);
            }
        }
        public DataTable TimKiem(string search, DTO_DatDichVu ddv)
        {
            return dalddv.TimKiem(search, ddv);
        }
    }
}
