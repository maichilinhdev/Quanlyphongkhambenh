using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_ThamSo
    {
        private string maThamSo;
        private string tenThamSo;
        private int triGiaThamSo;

        public string MaThamSo
        {
            get
            {
                return maThamSo;
            }

            set
            {
                maThamSo = value;
            }
        }

        public string TenThamSo
        {
            get
            {
                return tenThamSo;
            }

            set
            {
                tenThamSo = value;
            }
        }

        public int TriGiaThamSo
        {
            get
            {
                return triGiaThamSo;
            }

            set
            {
                triGiaThamSo = value;
            }
        }

        public DTO_ThamSo(string pMaThamSo, string pTenThamSo, int pTriGiaThamSo)
        {
            maThamSo = pMaThamSo;
            tenThamSo = pTenThamSo;
            triGiaThamSo = pTriGiaThamSo;
        }
    }
}
