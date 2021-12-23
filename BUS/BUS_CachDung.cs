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
    public class BUS_CachDung
    {
        DAL_CachDung dal_loaiCachDung = new DAL_CachDung();
        public bool Add(DTO_CachDung pLoaiCachDung)
        {
            return dal_loaiCachDung.Add(pLoaiCachDung);
        }

        public bool Delete(string pMaLoaiCachDung)
        {
            return dal_loaiCachDung.Delete(pMaLoaiCachDung);
        }

        public bool Update(DTO_CachDung pLoaiCachDung)
        {
            return dal_loaiCachDung.Update(pLoaiCachDung);
        }

        public DataTable GetThongTinTatCaCachDung()
        {
            return dal_loaiCachDung.GetThongTinTatCaCachDung();
        }

        public string GetMaLoaiCachDungNext()
        {
            string lastNumString = dal_loaiCachDung.GetMaLoaiCachDungLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "CD" + nextNumString;
        }
    }
}
