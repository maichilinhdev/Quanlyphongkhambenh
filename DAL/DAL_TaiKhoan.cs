using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan:DAL_DBConnect

    {

        DataTable dt = new DataTable();
        public DAL_TaiKhoan()
        {
            try
            {
                dt = GetThongTinTatCaTaiKhoan();
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Kết nối CSDL thất bại!");
                
            }
            
        }

        public DataTable GetThongTinTatCaTaiKhoan()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetTenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                string query = @"select TenHienThi from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }

        }

        public string GetChucVuFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                string query = @"select ChucVu from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }

        }
        public string GetMatKhauFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                string query = @"select MatKhau from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }
        }

        public string GetQuyenFromTenTaiKhoan(string pTenTaiKhoan)
        {
            try
            {
                string query = @"select Quyen from TAIKHOAN where TenTaiKhoan='" + pTenTaiKhoan + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "";
            }
        }
        /// Thêm - Xóa - Phân quyền
        // Thêm
        public bool ThemTaiKhoan(DTO_TaiKhoan TaiKhoan)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN", _cn);
                DataRow r = dt.NewRow();
                r["TenTaiKhoan"] = TaiKhoan.TenTaiKhoan;
                r["TenHienThi"] = TaiKhoan.TenHienThi;
                r["ChucVu"] = TaiKhoan.ChucVu;
                r["Quyen"] = TaiKhoan.Quyen;
                r["MatKhau"] = TaiKhoan.MatKhau;        
                dt.Rows.Add(r);

                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }
        // Update

        public bool Update(DTO_TaiKhoan pTaiKhoan)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN", _cn);
                DataRow r = dt.Rows.Find(pTaiKhoan.TenTaiKhoan);
                if (r != null)
                {
                    r["TenTaiKhoan"] = pTaiKhoan.TenTaiKhoan;
                    r["TenHienThi"] = pTaiKhoan.TenHienThi;
                    r["ChucVu"] = pTaiKhoan.ChucVu;
                    r["Quyen"] = pTaiKhoan.Quyen;
                    r["MatKhau"] = pTaiKhoan.MatKhau;
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch
            {
                return false;

            }
        }
        // Xóa
        public bool Delete(string pTaiKhoan)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN", _cn);
                DataRow r = dt.Rows.Find(pTaiKhoan);
                if (r != null)
                {
                    r.Delete();
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
