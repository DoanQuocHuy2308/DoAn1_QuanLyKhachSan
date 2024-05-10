using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KhachSan
{
    public class DTO_DatDichVu
    {
        public int ID_DatDichVu { get; set; }
        public int ID_NhanVien { get; set; }
        public int ID_KhachHang { get; set; }
        public int ID_DichVu { get; set; }
        public string ID_KhuyenMai { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayDat { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string KetQua { get; set; }
    }
}
