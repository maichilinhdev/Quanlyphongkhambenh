using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_CachDung
    {
        string maLoaiCachDung, tenLoaiCachDung;

        public string MaLoaiCachDung
        {
            get
            {
                return maLoaiCachDung;
            }

            set
            {
                maLoaiCachDung = value;
            }
        }

        public string TenLoaiCachDung
        {
            get
            {
                return tenLoaiCachDung;
            }

            set
            {
                tenLoaiCachDung = value;
            }
        }

        public DTO_CachDung(string pMaLoaiCachDung, string pTenLoaiCachDung)
        {
            maLoaiCachDung = pMaLoaiCachDung;
            tenLoaiCachDung = pTenLoaiCachDung;
        }


    }
}
