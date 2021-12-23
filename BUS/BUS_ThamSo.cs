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
    public class BUS_ThamSo
    {
        DAL_ThamSo dal_thamSo = new DAL_ThamSo();

        public bool Add(DTO_ThamSo pThamSo)
        {
            return dal_thamSo.Add(pThamSo);
        }

        public bool Delete(string pMaThamSo)
        {
            return dal_thamSo.Delete(pMaThamSo);
        }

        public bool Update(DTO_ThamSo pThamSo)
        {
            return dal_thamSo.Update(pThamSo);
        }
        
        public DataTable GetThongTinTatCaThamSo()
        {
            return dal_thamSo.GetThongTinTatCaThamSo();
        }

        public string GetNextMaThamSo()
        {
            string lastNumString = dal_thamSo.GetMaThamSoLast();
            string lastNumStringRemove = lastNumString.Remove(0, 2); //Lay phan so ra
            int lastNum = Int32.Parse(lastNumStringRemove);
            int nextNum = lastNum + 1;
            string nextNumString = nextNum.ToString();
            while (nextNumString.Length < 2)// 2 chu so
            {
                nextNumString = "0" + nextNumString;
            }

            return "TS" + nextNumString;
        }

        public int GetGiaTriThamSo(string tenThamSo)
        {
            return dal_thamSo.GetGiaTriThamSo(tenThamSo);
        }
    }
}
