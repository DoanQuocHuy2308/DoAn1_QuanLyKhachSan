using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KhachSan
{
    public class DTO_DatPhong
    {
        public int ID_DatPhong { get; set; }
        public int ID_NhanVien { get; set; }
        public int ID_KhachHang { get; set; }
        public int ID_Phong { get; set; }
        public string ID_KhuyenMai { get; set; }
        public DateTime Check_In { get; set; }
        public DateTime Check_Out { get; set; }
        public decimal TienCoc { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string KetQua { get; set; }
    }
}
