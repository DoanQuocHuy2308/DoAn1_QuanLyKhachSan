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
    public class BLL_LoaiDichVu
    {
        DAL_LoaiDichVu ldv = new DAL_LoaiDichVu();
        public DataTable HienThiDuLieuLoaiDichVu()
        {
            return ldv.Dulieuloaidichvu();
        }
        public void ADD(DTO_LoaiDichVu dto_ldv)
        {
            ldv.ThemLoaiDichVu(dto_ldv);
        }
        public void Update(DTO_LoaiDichVu dto_ldv)
        {
            ldv.UpdateLoaiDichVu(dto_ldv);
        }
        public bool KTIDTonTai(DTO_LoaiDichVu dto_ldv)
        {
            try
            {
                return ldv.KTIDTonTai(dto_ldv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin loại dịch vụ: " + ex.Message);
            }
        }
        public void Delete(DTO_LoaiDichVu dto_ldv)
        {
            try
            {
                if (KTIDTonTai(dto_ldv))
                {
                    throw new Exception("Không thể xóa loại dịch vụ vì còn tồn tại khóa ngoại liên quan.");
                }

                ldv.DeleteLoaiDichVu(dto_ldv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin loại dịch vụ: " + ex.Message);
            }
        }
        public DataTable TimKiemLoaiDichVu(string search, DTO_LoaiDichVu dto_ldv)
        {
            return ldv.TimKiemLoaiDichVu(search, dto_ldv);
        }
    }
}
