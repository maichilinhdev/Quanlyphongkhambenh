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
    public class BUS_LoaiDonVi
    {
        DAL_LoaiDonVi dal_loaiDonVi = new DAL_LoaiDonVi();
        public bool Add(DTO_LoaiDonVi pLoaiDonVi)
        {
            return dal_loaiDonVi.Add(pLoaiDonVi);
        }

        public bool Delete(string pMaLoaiDonVi)
        {
            return dal_loaiDonVi.Delete(pMaLoaiDonVi);
        }

        public bool Update(DTO_LoaiDonVi pLoaiDonVi)
        {
            return dal_loaiDonVi.Update(pLoaiDonVi);
        }

        public DataTable GetThongTinTatCaLoaiDonVi()
        {
            return dal_loaiDonVi.GetThongTinTatCaLoaiDonVi();
        }

        public string GetMaLoaiDonViNext()
        {
            string lastNumString = dal_loaiDonVi.GetMaLoaiDonViLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "DV" + nextNumString;
        }
    }
}
