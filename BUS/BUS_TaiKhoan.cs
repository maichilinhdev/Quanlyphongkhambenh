using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Security.Cryptography;


namespace BUS
{
   public class BUS_TaiKhoan
    {
        DAL_TaiKhoan DAL_TaiKhoan = new DAL_TaiKhoan();
        public bool ThemTaiKhoan(DTO_TaiKhoan pTaiKhoan)
        {
            return DAL_TaiKhoan.ThemTaiKhoan(pTaiKhoan);
        }

        public bool Delete(string pTenTaiKhoan)
        {
            return DAL_TaiKhoan.Delete(pTenTaiKhoan);
        }

        public bool Update(DTO_TaiKhoan pTaiKhoan)
        {
            return DAL_TaiKhoan.Update(pTaiKhoan);
        }

        public DataTable GetThongTinTatCaTaiKhoan()
        {
            return DAL_TaiKhoan.GetThongTinTatCaTaiKhoan();
        }

        public string GetTenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return DAL_TaiKhoan.GetTenFromTenTaiKhoan(pTenTaiKhoan);
        }
        public string GetChucVuFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return DAL_TaiKhoan.GetChucVuFromTenTaiKhoan(pTenTaiKhoan);
        }
        public string GetMatKhauFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return DAL_TaiKhoan.GetMatKhauFromTenTaiKhoan(pTenTaiKhoan);
        }

        public string GetQuyenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            return DAL_TaiKhoan.GetQuyenFromTenTaiKhoan(pTenTaiKhoan);
        }
    }

    public static class Hash256
    {
        public static string Hash256Data(string data)
        {
            // Create a SHA256   

            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
