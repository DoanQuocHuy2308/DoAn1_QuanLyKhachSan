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
    public class BLL_ThongKe
    {
        DAL_ThongKe tk = new DAL_ThongKe();
        public DataTable TenPhong()
        {
            return tk.TenPhong();
        }
        public DataTable TenLoaiPhong()
        {
            return tk.TenLoaiPhong();
        }
        public DataTable DuLieuDonDatPhong()
        {
            return tk.DuLieuDonDatPhong();
        }
        public DataTable ThongKeDonDatPhong(DTO_DatPhong dp,DTO_Phong p,DTO_LoaiPhong lp)
        {
            return tk.ThongKeDonDatPhong(dp, p, lp);
        }
        public DataTable TenDichVu()
        {
            return tk.TenDichVu();
        }
        public DataTable TenLoaiDichVu()
        {
            return tk.TenLoaiDichVu();
        }
        public DataTable DuLieuDonDatDichVu()
        {
            return tk.DuLieuDonDatDichVu();
        }
        public DataTable ThongKeDonDatDichVu(DTO_DatDichVu ddv, DTO_DichVu dv, DTO_LoaiDichVu ldv, DateTime ngayketthuc)
        {
            return tk.ThongKeDonDatDichVu(ddv, dv, ldv,ngayketthuc);
        }
    }
}
