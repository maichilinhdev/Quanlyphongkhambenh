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
    public class BUS_DanhSachKhamBenh
    {
        DAL_DanhSachKhamBenh dal_danhSachKhamBenh = new DAL_DanhSachKhamBenh();

        public bool ThemDanhSach(DTO_DanhSachKhamBenh pDSKB)
        {
            return dal_danhSachKhamBenh.ThemDanhSach(pDSKB);
        }

        public bool Delete(string pMaDSKB)
        {
            return dal_danhSachKhamBenh.Delete(pMaDSKB);
        }

        public bool Update(DTO_DanhSachKhamBenh pDSKB)
        {
            return dal_danhSachKhamBenh.Update(pDSKB);
        }

        public DataTable GetThongTinTatCaDanhSach()
        {
            return dal_danhSachKhamBenh.GetThongTinTatCaDanhSach();
        }
        public bool CheckDanhSachTonTai(string maDS)
        {
            return dal_danhSachKhamBenh.CheckDanhSachTonTai(maDS);
        }

        public DataTable LayDanhSachKhamBenh(DateTime date)
        {
            string mdy = date.Month.ToString() + @"/" + date.Day.ToString() + @"/" + date.Year.ToString();
            return dal_danhSachKhamBenh.LayDanhSachKhamBenh(mdy);
        }
    }
}
