using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_KhachSan
{
    public class DTO_KhuyenMai
    {
        public int ID_KhuyenMai { get; set; }
        public string Ten_KhuyenMai { get; set; }
        public decimal GiaTri { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
    }
}
