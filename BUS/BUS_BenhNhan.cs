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
    public class BUS_BenhNhan //CHU Y la PUBLIC class
    {
        DAL_BenhNhan dal_benhNhan = new DAL_BenhNhan();
        public bool ThemBenhNhan(DTO_BenhNhan pBenhNhan)
        {
            return dal_benhNhan.ThemBenhNhan(pBenhNhan);
        }

        public bool Delete(string pMaBenhNhan)
        {
            return dal_benhNhan.Delete(pMaBenhNhan);
        }

        public bool Update(DTO_BenhNhan pBenhNhan)
        {
            return dal_benhNhan.Update(pBenhNhan);
        }

        public DataTable GetThongTinTatCaBenhNhan()
        {
            return dal_benhNhan.GetThongTinTatCaBenhNhan();
        }

        public string GetMaBenhNhanNext()
        {
            string lastNumString= dal_benhNhan.GetMaBenhNhanLast();
            string lastNumStringRemove=lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum+1;
            string nextNumString = nextNum.ToString();
            while(nextNumString.Length<7)
            {
                nextNumString = "0" + nextNumString;
            }

            return "BN"+nextNumString;
        }

        public string GetTenFromMaBenhNhan(string pMaBenhNhan)
        {
            return dal_benhNhan.GetTenFromMaBenhNhan(pMaBenhNhan);
        }

        #region TestLoadTenLen
        public DataTable Get_Ten()
        {
            return dal_benhNhan.Get_Ten();
        }

        public DataTable TimBenhNhan(string maBN, string hoTen, string cmnd, string gioiTinh, string namSinh, string sdt, string diaChi)
        {
            return dal_benhNhan.TimBenhNhan(maBN, hoTen, cmnd, gioiTinh, namSinh, sdt, diaChi);


        }
        #endregion
    }
}
