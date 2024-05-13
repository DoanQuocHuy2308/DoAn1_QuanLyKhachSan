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
    }
}
