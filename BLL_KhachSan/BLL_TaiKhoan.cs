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
    public class BLL_TaiKhoan
    {
        DAL_TaiKhoan tk = new DAL_TaiKhoan();
        public DataTable HienThiTaiKhoan()
        {
            return tk.HienThiDuLieuTaiKhoan();
        }
        public bool KTEmail(DTO_TaiKhoan dto_tk)
        {
            try
            {
                return tk.KTEmail(dto_tk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra email nhân viên tồn tại: " + ex.Message);
            }
        }
        public void ADD(DTO_TaiKhoan dto_tk)
        {
            try
            {
                tk.ADD(dto_tk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài khoản: " + ex.Message);
            }
        }
        public void Update(DTO_TaiKhoan dto_tk)
        {
            try
            {
                tk.Update(dto_tk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin tài khoản: " + ex.Message);
            }
        } 
        public void Delete(DTO_TaiKhoan dto_tk)
        {
            try
            {
                tk.Delete(dto_tk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tài khoản và nhân viên: " + ex.Message);
            }
        }
        public DataTable TimKiemTaiKhoan(string search, DTO_TaiKhoan dto_tk)
        {
            try
            {
                return tk.TimKiem(search, dto_tk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm tài khoản: " + ex.Message);
            }
        }
    }
}
