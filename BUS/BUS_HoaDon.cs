using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;


namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_hoaDon = new DAL_HoaDon();
        public bool Add(DTO_HoaDon pHoaDon)
        {
            return dal_hoaDon.Add(pHoaDon);
        }

        public bool Delete(string pMaHoaDon)
        {
            return dal_hoaDon.Delete(pMaHoaDon);
        }

        public bool Update(DTO_HoaDon pHoaDon)
        {
            return dal_hoaDon.Update(pHoaDon);
        }

        public DataTable GetThongTinTatCaHoaDon()
        {
            return dal_hoaDon.GetThongTinTatCaHoaDon();
        }

        public DataTable BaoCaoDoanhThu(int thang, int nam)
        {
            return dal_hoaDon.BaoCaoDoanhThu(thang, nam);
        }

        public string GetMaHoaDonNext(int congThem = 0)
        {
            string lastNumString = dal_hoaDon.GetMaHoaDonLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1 + congThem;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 8)// gom 8 so
            {
                nextNumString = "0" + nextNumString;
            }

            return "HD" + nextNumString;
        }

        public DataTable GetThongTinHoaDonFromPhieuKham(string maPK)
        {

            return dal_hoaDon.GetThongTinHoaDonFromPhieuKham(maPK);
        }

        public bool XoaHoaDonCoMaPK(string maPK)
        {
            return dal_hoaDon.XoaHoaDonCoMaPK(maPK);
        }
    }
}
