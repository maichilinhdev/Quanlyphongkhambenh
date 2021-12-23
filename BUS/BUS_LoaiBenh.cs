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
    public class BUS_LoaiBenh
    {
        DAL_LoaiBenh dal_loaiBenh = new DAL_LoaiBenh();
        public bool Add(DTO_LoaiBenh pLoaiBenh)
        {
            return dal_loaiBenh.Add(pLoaiBenh);
        }

        public bool Delete(string pMaLoaiBenh)
        {
            return dal_loaiBenh.Delete(pMaLoaiBenh);
        }

        public bool Update(DTO_LoaiBenh pLoaiBenh)
        {
            return dal_loaiBenh.Update(pLoaiBenh);
        }

        public DataTable GetThongTinTatCaLoaiBenh()
        {
            return dal_loaiBenh.GetThongTinTatCaLoaiBenh();
        }

        public string GetMaLoaiBenhNext()
        {
            string lastNumString = dal_loaiBenh.GetMaLoaiBenhLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// gom 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "LB" + nextNumString;
        }
    }
}
