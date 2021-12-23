﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_HoaDon
    {
        private string maHoaDon, maPK;
        private int tienKham, tienThuoc;

        public string MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
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

        public int TienKham
        {
            get
            {
                return tienKham;
            }

            set
            {
                tienKham = value;
            }
        }

        public int TienThuoc
        {
            get
            {
                return tienThuoc;
            }

            set
            {
                tienThuoc = value;
            }
        }

        public DTO_HoaDon(string pMaHoaDon, string pMaPK, int pTienKham, int pTienThuoc)
        {
            maHoaDon = pMaHoaDon;
            maPK = pMaPK;
            tienKham = pTienKham;
            tienThuoc = pTienThuoc;
        }

    }
}
