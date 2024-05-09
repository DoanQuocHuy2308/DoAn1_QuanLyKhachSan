using DAL_KhachSan;
using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_KhachSan
{
    public class BLL_DangNhap
    {
        private DAL_DangNhap dn = new DAL_DangNhap();
        public DTO_TaiKhoan DangNhap(string Email_TaiKhoan, string Pass_TaiKhoan, string Role_TaiKhoan)
        {
            DTO_TaiKhoan tk = dn.DangNhapTaiKhoan(Email_TaiKhoan, Pass_TaiKhoan, Role_TaiKhoan);
            if(tk != null )
            {
                if (tk.Ban_TaiKhoan == 1)
                {
                    return tk;
                }
                return tk;
            }
            return null;
        }
    }
}
