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
    public class BLL_LoaiPhong
    {
        DAL_LoaiPhong lp = new DAL_LoaiPhong();
        public DataTable HienThiDuLieuIDLoaiPhong()
        {
            return lp.dulieuidloaiphong();
        }
        public DataTable HienThiDuLieuLoaiPhong()
        {
            return lp.Dulieuloaiphong();
        }
        public bool KTTrungTen(DTO_LoaiPhong dto_lp)
        {
            return lp.KTTrungTen(dto_lp);
        }
        public void ThemLoaiPhong(DTO_LoaiPhong dto_lp)
        {
            lp.ThemLoaiPhong(dto_lp);
        }
        public void Update(DTO_LoaiPhong dto_lp)
        {
            lp.UpdateLoaiPhong(dto_lp);
        }
        public bool KTIDTonTai(DTO_LoaiPhong dto_lp)
        {
            try
            {
               return lp.KTIDTonTai(dto_lp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin loại phòng: " + ex.Message);
            }
        }
        public void Delete(DTO_LoaiPhong dto_lp)
        {
            try
            {
                if (KTIDTonTai(dto_lp))
                {
                    throw new Exception("Không thể xóa loại phòng vì còn tồn tại khóa ngoại liên quan.");
                }

                lp.DeleteLoaiPhong(dto_lp);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin loại phòng: " + ex.Message);
            }
        }
        public DataTable TimKiemLoaiPhong(string search, DTO_LoaiPhong dto_lp)
        {
            return lp.TimKiemLoaiPhong(search, dto_lp);
        }
    }
}
