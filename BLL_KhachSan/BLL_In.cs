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
    public class BLL_In
    {
        DAL_In dalin = new DAL_In();
        public DataTable InPhongDat(DTO_DatPhong dp)
        {
            return dalin.InPhongDat(dp);
        }
        public DataTable InDonDatPhong(DTO_DatPhong dp)
        {
            return dalin.InHoaDonDatPhong(dp);
        }
        public DataTable InHoaDonDichVu(DTO_DatDichVu ddv)
        {
            return dalin.InHoaDonDatDichVu(ddv);
        }
        public DataTable InThongKeDonDatPhong(DTO_DatPhong dp, DTO_Phong p, DTO_LoaiPhong lp)
        {
            return dalin.InThongKeDonDatPhong(dp, p, lp);   
        }
        public DataTable InThongKeDonDatDichVu(DTO_DatDichVu ddv, DTO_DichVu dv, DTO_LoaiDichVu ldv, DateTime ngayketthuc)
        {
            return dalin.InThongKeDonDatDichVu(ddv,dv,ldv,ngayketthuc);
        }
    }
}
