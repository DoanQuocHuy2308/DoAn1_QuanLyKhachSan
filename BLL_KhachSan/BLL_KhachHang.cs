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
    public class BLL_KhachHang
    {
        DAL_KhachHang dalkh = new DAL_KhachHang();
        public DataTable HienThiKhachHang()
        {
            return dalkh.DuLieuKhachHang();
        }
        public bool KTCMND(DTO_KhachHang kh)
        {
            return dalkh.KTCMND(kh);
        }
        public void ADD(DTO_KhachHang kh)
        {
            try
            {
                dalkh.ADD(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm Khách Hàng " + ex.Message);
            }
        }

        public void Update(DTO_KhachHang kh)
        {
            try
            {
                dalkh.Update(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin Khách Hàng: " + ex.Message);
            }
        }
        public void Delete(DTO_KhachHang kh)
        {
            try
            {
                dalkh.Delete(kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin khách hàng: " + ex.Message);
            }
        }
        public DataTable TimKiemKhachHang(string search, DTO_KhachHang kh)
        {
            try
            {
                return dalkh.TimKiem(search, kh);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm thông tin khách hàng: " + ex.Message);
            }
        }
    }
}
