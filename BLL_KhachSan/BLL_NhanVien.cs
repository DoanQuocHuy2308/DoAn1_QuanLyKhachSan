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
    public class BLL_NhanVien
    {
        DAL_NhanVien dal_nv = new DAL_NhanVien();
        public DataTable HienThiDuLieuNhanVien()
        {
            return dal_nv.DuLieuNhanvien();
        }
        public bool KTEmail(DTO_NhanVien nv)
        {
            try
            {
                return dal_nv.KTEmail(nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra email nhân viên tồn tại: " + ex.Message);
            }
        }
        public void ThemNhanVien(DTO_NhanVien nv)
        {
            try
            {
                dal_nv.ADD(nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public void CapNhatNhanVien(DTO_NhanVien nv)
        {
            try
            {
                dal_nv.Update(nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
            }
        }

        public bool KiemTraIDTonTai(DTO_NhanVien nv)
        {
            try
            {
                return dal_nv.KTIDTonTai(nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra ID nhân viên tồn tại: " + ex.Message);
            }
        }

        public void XoaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                dal_nv.Delete(nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin nhân viên: " + ex.Message);
            }
        }

        public DataTable TimKiemNhanVien(string search, DTO_NhanVien nv)
        {
            try
            {
                return dal_nv.TimKiem(search, nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm thông tin nhân viên: " + ex.Message);
            }
        }
    }
}
