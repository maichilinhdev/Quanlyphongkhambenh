using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class DTO_BenhNhan //CHU Y la PUBLIC class
    {
        #region Khai bao properties
        //************
        //propfull -> tab -> tab để tự động tạo code
        // hoac go private string maBenhNhan roi ctrl . enter;
        //************

        private string maBenhNhan;
        private string hoTen;
        private string gioiTinh;
        private int namSinh;
        private string diaChi;
        private string soDienThoai;
        private string cmnd;

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

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public int NamSinh
        {
            get
            {
                return namSinh;
            }

            set
            {
                namSinh = value;
            }
        }
       
        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string CMND
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        #endregion

        #region Ham Khoi Tao
        public DTO_BenhNhan()
        {
            this.maBenhNhan = "";
            this.hoTen = "";
            this.gioiTinh = "";
            this.namSinh = 0;
            this.diaChi = "";
            this.soDienThoai = "";
            this.cmnd = "";
        }
        public DTO_BenhNhan(string pMaBenhNhan,string pHoTen, string pGioiTinh,int pNamSinh, string pDiaChi,string pSoDienThoai,string pCMND)
        {
            this.maBenhNhan = pMaBenhNhan;
            this.hoTen = pHoTen;
            this.gioiTinh = pGioiTinh;
            this.namSinh = pNamSinh;
            this.diaChi = pDiaChi;
            this.soDienThoai = pSoDienThoai;
            this.cmnd = pCMND;
        }
        #endregion

    }
}
