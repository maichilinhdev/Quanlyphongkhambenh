using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;


namespace BUS
{
    public class BUS_DonThuoc
    {
        DAL_DonThuoc dal_donThuoc = new DAL_DonThuoc();
        public bool Add(DTO_DonThuoc pDonThuoc)
        {
            return dal_donThuoc.Add(pDonThuoc);
        }

        public bool Delete(string pMaDonThuoc)
        {
            return dal_donThuoc.Delete(pMaDonThuoc);
        }

        public bool Update(DTO_DonThuoc pDonThuoc)
        {
            return dal_donThuoc.Update(pDonThuoc);
        }

        public DataTable GetThongTinTatCaDonThuoc()
        {
            return dal_donThuoc.GetThongTinTatCaDonThuoc();
        }
        

        public string GetMaDonThuocNext(int congThem=0)
        {
            string lastNumString = dal_donThuoc.GetMaDonThuocLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1+congThem;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 8)// gom 8 so
            {
                nextNumString = "0" + nextNumString;
            }

            return "DT" + nextNumString;
        }

        public DataTable GetThongTinDonThuocFromPhieuKham(string maPK)
        {
            return dal_donThuoc.GetThongTinDonThuocFromPhieuKham(maPK);
        }

        public DataTable GetThongTinTienThuocFromPhieuKham(string maPK)
        {
            return dal_donThuoc.GetThongTinTienThuocFromPhieuKham(maPK);
        }
        public DataTable GetBangThongKeSuDungThuoc(int thang, int nam)
        {
            return dal_donThuoc.GetBangThongKeSuDungThuoc(thang, nam);
        }

        public bool XoaDonThuocCoMaPK(string maPK)
        {
            return dal_donThuoc.XoaDonThuocCoMaPK(maPK);
        }
    }
}
