using DAL_KhachSan;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_KhachSan;

namespace BLL_KhachSan
{
    public class BLL_CaiDat
    {
        DAL_CaiDat cd=  new DAL_CaiDat();
        public DataTable HienEmail(DTO_TaiKhoan tk)
        {
            return cd.HienEmail(tk);
        }
        public DataTable HienCMND(DTO_NhanVien nv)
        {
            return cd.HienCMND(nv);
        }
        public void CapNhatTaiKhoan(DTO_TaiKhoan dto_tk)
        {
            try
            {
                cd.CapNhatTaiKhoan(dto_tk);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin tài khoản: " + ex.Message);
            }
        }
        public void CapNhatNhanVien(DTO_NhanVien nv)
        {
            try
            {
                cd.CapNhatNhanVien(nv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
            }
        }
    }
}
