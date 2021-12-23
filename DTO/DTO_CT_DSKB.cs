using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_CT_DSKB
    {
        private string maCTDSKB;
        private string maDSKB;
        private string maBenhNhan;

        public string MaCTDSKB
        {
            get
            {
                return maCTDSKB;
            }

            set
            {
                maCTDSKB = value;
            }
        }

        public string MaDSKB
        {
            get
            {
                return maDSKB;
            }

            set
            {
                maDSKB = value;
            }
        }

        public string MaBenhNhan
        {
            get
            {
                return maBenhNhan;
            }

            set
            {
                maBenhNhan = value;
            }
        }

        public DTO_CT_DSKB(string pMaCTDSKB,string pMaDSKB, string pMaBenhNhan)
        {
            maCTDSKB = pMaCTDSKB;
            maDSKB = pMaDSKB;
            maBenhNhan = pMaBenhNhan;
        }

    }
}
