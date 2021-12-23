using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_LoaiThuoc
    {
        private string maLoaiThuoc, tenLoaiThuoc, maLoaiDonVi, maLoaiCachDung;
        private int donGia;

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

        public string TenLoaiThuoc
        {
            get
            {
                return tenLoaiThuoc;
            }

            set
            {
                tenLoaiThuoc = value;
            }
        }

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

        public int DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public DTO_LoaiThuoc(string pMaLoaiThuoc, string pTenLoaiThuoc, string pMaLoaiDonVi, string pMaLoaiCachDung, int pDonGia)
        {
            maLoaiThuoc = pMaLoaiThuoc;
            tenLoaiThuoc = pTenLoaiThuoc;
            maLoaiDonVi = pMaLoaiDonVi;
            maLoaiCachDung = pMaLoaiCachDung;
            donGia = pDonGia;
        }


    }
}
