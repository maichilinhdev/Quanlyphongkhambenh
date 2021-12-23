using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_LoaiDonVi
    {
        private string maLoaiDonVi, tenLoaiDonVi;

        public string MaLoaiDonVi
        {
            get
            {
                return maLoaiDonVi;
            }

            set
            {
                maLoaiDonVi = value;
            }
        }

        public string TenLoaiDonVi
        {
            get
            {
                return tenLoaiDonVi;
            }

            set
            {
                tenLoaiDonVi = value;
            }
        }

        public DTO_LoaiDonVi(string pMaLoaiDonVi, string pTenLoaiDonVi)
        {
            maLoaiDonVi = pMaLoaiDonVi;
            tenLoaiDonVi = pTenLoaiDonVi;
        }
    }
}
