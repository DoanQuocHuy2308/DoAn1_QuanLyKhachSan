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
    public class BLL_KhuyenMai
    {
        DAL_KhuyenMai dalkm = new DAL_KhuyenMai();
        public DataTable DuLieuKhuyenMai()
        {
            return dalkm.DuLieuKhuyenMai();
        }

        public void Add(DTO_KhuyenMai km)
        {
            try
            {
                dalkm.Add(km);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm khuyến mại: " + ex.Message);
            }
        }

        public void Update(DTO_KhuyenMai km)
        {
            try
            {
                dalkm.Update(km);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa thông tin khuyến mại: " + ex.Message);
            }
        }
        public bool KTIDTonTaiDP(DTO_KhuyenMai km)
        {
            try
            {
                return dalkm.KTIDTonTaiDP(km);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin khuyến mại: " + ex.Message);
            }
        }
        public bool KTIDTonTaiDDV(DTO_KhuyenMai km)
        {
            try
            {
                return dalkm.KTIDTonTaiDDV(km);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra thông tin khuyến mại: " + ex.Message);
            }
        }
        public void Delete(DTO_KhuyenMai km)
        {
            try
            {
                dalkm.Delete(km);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thông tin khuyến mại: " + ex.Message);
            }
        }
        public DataTable TimKiem(string search, DTO_KhuyenMai km)
        {
            return dalkm.TimKiemKhuyenMai(search, km);
        }
    }
}
