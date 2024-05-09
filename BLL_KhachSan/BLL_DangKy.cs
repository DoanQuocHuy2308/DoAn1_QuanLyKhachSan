using DAL_KhachSan;
using DTO_KhachSan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_KhachSan
{
    public class BLL_DangKy
    {
        private DAL_DangKy dk = new DAL_DangKy();

        public bool KiemTraEmailTonTai(DTO_TaiKhoan tk)
        {
            return dk.KiemTraEmailTonTai(tk);
        }
        public void DangKyTaiKhoan(DTO_TaiKhoan tk)
        {
            dk.DangKyTaiKhoan(tk);
        }
    }
}
