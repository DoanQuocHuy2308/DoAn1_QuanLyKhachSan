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
    public class BLL_Phong
    {
        private DAL_Phong p = new DAL_Phong();

        public DataTable HienThiDuLieuPhong()
        {
            return p.LayDuLieuPhong();
        }
        public bool KTTrungTen(DTO_Phong dto_p)
        {
            return p.KTTrungTen(dto_p);
        }
        public void ThemPhong(DTO_Phong dto_p)
        {
            p.ThemPhong(dto_p);
        }
        public void Update(DTO_Phong dto_P)
        {
            p.UpdatePhong(dto_P);
        }
        public bool KTIDTonTai(DTO_Phong dto_p)
        {
            try
            {
                return p.KTIDTonTai(dto_p);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin phòng: " + ex.Message);
            }
        }
        public void Delete(DTO_Phong dto_P)
        {
            try
            {
                if (KTIDTonTai(dto_P))
                {
                    throw new Exception("Không thể xóa phòng vì còn tồn tại khóa ngoại liên quan.");
                }
                p.DeletePhong(dto_P);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin phòng: " + ex.Message);
            }
        }
        public DataTable TimKiemPhong(string search, DTO_Phong dto_P)
        {
            try
            {
                return p.TimKiem(search, dto_P);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tìm kiếm thông tin phòng: " + ex.Message);
            }
        }
    }
}

