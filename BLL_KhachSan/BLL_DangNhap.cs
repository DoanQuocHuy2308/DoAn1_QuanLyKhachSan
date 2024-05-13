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
    public class BLL_DangNhap
    {
        private DAL_DangNhap dn = new DAL_DangNhap();
        public DTO_TaiKhoan DangNhap(DTO_TaiKhoan tk)
        {
            tk = dn.DangNhapTaiKhoan(tk);
            if (tk != null)
            {
                if (tk.Ban_TaiKhoan == 1)
                {
                    return tk;
                }
                return tk;
            }
            return null;
        }

        public string LayTenNhanVien(string email)
        {
            return dn.LayTenNhanVien(email);
        }
    }
}
