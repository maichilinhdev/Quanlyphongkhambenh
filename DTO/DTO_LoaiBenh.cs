using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_LoaiBenh
    {
        private string maLoaiBenh, tenLoaiBenh;

        public string MaLoaiBenh
        {
            get
            {
                return maLoaiBenh;
            }

            set
            {
                maLoaiBenh = value;
            }
        }

        public string TenLoaiBenh
        {
            get
            {
                return tenLoaiBenh;
            }

            set
            {
                tenLoaiBenh = value;
            }
        }

        public DTO_LoaiBenh(string pMaLoaiBenh, string pTenLoaiBenh)
        {
            maLoaiBenh = pMaLoaiBenh;
            tenLoaiBenh = pTenLoaiBenh;
        }

    }
}
