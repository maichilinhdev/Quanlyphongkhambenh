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
    public class BUS_PhieuKham
    {
        DAL_PhieuKham dal_phieuKham = new DAL_PhieuKham();

        public bool ThemPhieuKham(DTO_PhieuKham pPhieuKham)
        {
            return dal_phieuKham.ThemPhieuKham(pPhieuKham);
        }

        public bool Delete(string pMaPhieuKham)
        {
            return dal_phieuKham.Delete(pMaPhieuKham);
        }

        public bool Update(DTO_PhieuKham pPhieuKham)
        {
            return dal_phieuKham.Update(pPhieuKham);
        }

        public DataTable GetTatCaMaPK(string maPKGoiY)
        {
            return dal_phieuKham.GetTatCaMaPK(maPKGoiY);
        }

        public DataTable GetThongTinTatCaPhieuKham()
        {
            return dal_phieuKham.GetThongTinTatCaPhieuKham();
        }

        public string GetNextMaPK()
        {
            string lastNumString = dal_phieuKham.GetMaPKLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 7)// 7 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "PK" + nextNumString;
        }
    }
}
