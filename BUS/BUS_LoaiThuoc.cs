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
    public class BUS_LoaiThuoc
    {
        DAL_LoaiThuoc dal_loaiThuoc = new DAL_LoaiThuoc();
        public bool Add(DTO_LoaiThuoc pLoaiThuoc)
        {
            return dal_loaiThuoc.Add(pLoaiThuoc);
        }

        public bool Delete(string pMaLoaiThuoc)
        {
            return dal_loaiThuoc.Delete(pMaLoaiThuoc);
        }

        public bool Update(DTO_LoaiThuoc pLoaiThuoc)
        {
            return dal_loaiThuoc.Update(pLoaiThuoc);
        }

        public DataTable GetThongTinTatCaLoaiThuoc()
        {
            return dal_loaiThuoc.GetThongTinTatCaLoaiThuoc();
        }

        public DataTable TimKiemThuoc(string maThuoc, string tenThuoc, string tenLoaiDonVi, string cachDung, string donGia)
        {
            return dal_loaiThuoc.TimKiemThuoc(maThuoc,tenThuoc,tenLoaiDonVi,cachDung,donGia);
        }

        public DataTable GetThongTinCanShowVeThuoc()
        {
            return dal_loaiThuoc.GetThongTinCanShowVeThuoc();
        }

        public string GetMaLoaiThuocNext()
        {
            string lastNumString = dal_loaiThuoc.GetMaLoaiThuocLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "LT" + nextNumString;
        }

        public string GetMaLoaiThuocFromTen(string tenThuoc)
        {
            return dal_loaiThuoc.GetMaLoaiThuocFromTen(tenThuoc);
        }
    }
}
