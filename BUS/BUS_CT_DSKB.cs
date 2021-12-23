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
    public class BUS_CT_DSKB
    {
        DAL_CT_DSKB dal_ctdskb = new DAL_CT_DSKB();
        public bool ThemBenhNhanVaoDanhSach(DTO_CT_DSKB pCTDSKB)
        {
            return dal_ctdskb.ThemCTDSKB(pCTDSKB);
        }

        public bool Delete(string pMaCTDSKB)
        {
            return dal_ctdskb.Delete(pMaCTDSKB);
        }

        public bool Update(DTO_CT_DSKB pCTDSKB)
        {
            return dal_ctdskb.Update(pCTDSKB);
        }

        public DataTable GetThongTinTatCaCT_DSKB()
        {
            return dal_ctdskb.GetThongTinTatCaCT_DSKB();
        }

        public string GetNextMaCTDSKB()
        {
            string lastNumString = dal_ctdskb.GetLastMaCTDSKB();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 7)// 7 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "CT" + nextNumString;
        }

        public DataTable GetThongTinBenhNhanKhamBenh(string maPK, string maBenhNhan, string tenBenhNhan, string ngayKham, string cmnd,string sdt)
        {
            return dal_ctdskb.GetThongTinBenhNhanKhamBenh(maPK, maBenhNhan, tenBenhNhan, ngayKham, cmnd, sdt);
        }

        public bool KiemTraBenhNhanCoTrongDanhSach(string maDS, string mabenhNhan)
        {
            return dal_ctdskb.KiemTraBenhNhanCoTrongDanhSach(maDS, mabenhNhan);
        }

        public string GetMaCTDSKB(string maDSKB, string maBenhNhan)
        {
            return dal_ctdskb.GetMaCTDSKB(maDSKB, maBenhNhan);
        }
    }
}
