using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_DonThuoc
    {
        private string maDT, maPK, maLoaiThuoc;
        private int soLuong;

        public string MaDT
        {
            get
            {
                return maDT;
            }

            set
            {
                maDT = value;
            }
        }

        public string MaLoaiThuoc
        {
            get
            {
                return maLoaiThuoc;
            }

            set
            {
                maLoaiThuoc = value;
            }
        }

        public string MaPK
        {
            get
            {
                return maPK;
            }

            set
            {
                maPK = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public DTO_DonThuoc(string pMaDT,string pMaPK, string pMaLoaiThuoc, int pSoLuong)
        {
            maDT = pMaDT;
            maPK = pMaPK;
            maLoaiThuoc = pMaLoaiThuoc;
            soLuong = pSoLuong;
        }


    }
}
