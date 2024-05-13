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
    public class BLL_DichVu
    {
        private DAL_DichVu dv = new DAL_DichVu();
        public DataTable HienThiDuLieuDichVu()
        {
            return dv.LayDuLieuDichVu();
        }
        public DataTable HienThiDuLieuLoaiDichVu()
        {
            return dv.dulieuidloaidichvu();
        }
        public bool KTTrungTen(DTO_DichVu dto_dv)
        {
            return dv.KTTrungTen(dto_dv);
        }
        public void ADD(DTO_DichVu dto_dv)
        {
            dv.ThemDichVu(dto_dv);
        }
        public void UPDATE(DTO_DichVu dto_dv)
        {
            dv.UpdateDichVu(dto_dv);
        }
        public bool KTIDTonTai(DTO_DichVu dto_dv)
        {
            try
            {
                return dv.KTIDTonTai(dto_dv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin dịch vụ: " + ex.Message);
            }
        }
        public void Delete(DTO_DichVu dto_dv)
        {
            try
            {
                if (KTIDTonTai(dto_dv))
                {
                    throw new Exception("Không thể xóa dịch vụ vì còn tồn tại khóa ngoại liên quan.");
                }
                dv.DeleteDichVu(dto_dv);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin dịch vụ: " + ex.Message);
            }
        }
        public DataTable TimKiemDichVu(string search, DTO_DichVu dto_dv)
        {
            return dv.TimKiemDichVu(search, dto_dv);
        }
    }
}
