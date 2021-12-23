using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_LoaiThuoc:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_LoaiThuoc()
        {
            dt = GetThongTinTatCaLoaiThuoc();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin
         
        public DataTable GetThongTinTatCaLoaiThuoc()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAITHUOC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable TimKiemThuoc(string maThuoc, string tenThuoc, string tenLoaiDonVi,string cachDung, string donGia)
        {
            try
            {
                string query = @"exec TimKiemThuoc @maLoaiThuoc = '"+maThuoc
                               + @"', @tenLoaiThuoc = N'" + tenThuoc
                               + @"', @tenLoaiDonVi = N'" + tenLoaiDonVi 
                               + @"', @tenLoaiCachDung = N'" + cachDung 
                               + @"', @donGia = '" + donGia + @"'";
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
            
        }

        public DataTable GetThongTinCanShowVeThuoc()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("exec GetThongTinVeThuoc", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetMaLoaiThuocFromTen(string tenThuoc)
        {
            string query = @"select MaLoaiThuoc from LOAITHUOC where TenLoaiThuoc = '"+tenThuoc+"'";
            SqlDataAdapter da = new SqlDataAdapter(query, _cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0].ItemArray[0].ToString();
        }

        #endregion

        #region Them Xoa Sua
        public bool Add(DTO_LoaiThuoc pLoaiThuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAITHUOC", _cn);
                DataRow r = dt.NewRow();
                r["MaLoaiThuoc"] = pLoaiThuoc.MaLoaiThuoc;
                r["TenLoaiThuoc"] = pLoaiThuoc.TenLoaiThuoc;
                r["MaLoaiDonVi"] = pLoaiThuoc.MaLoaiDonVi;
                r["MaLoaiCachDung"] = pLoaiThuoc.MaLoaiCachDung;
                r["DonGia"] = pLoaiThuoc.DonGia;
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

        public bool Delete(string pMaLoaiThuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAITHUOC", _cn);
                DataRow r = dt.Rows.Find(pMaLoaiThuoc);
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


        public bool Update(DTO_LoaiThuoc pLoaiThuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAITHUOC", _cn);
                DataRow r = dt.Rows.Find(pLoaiThuoc.MaLoaiThuoc);
                if (r != null)
                {
                    r["MaLoaiThuoc"] = pLoaiThuoc.MaLoaiThuoc;
                    r["TenLoaiThuoc"] = pLoaiThuoc.TenLoaiThuoc;
                    r["MaLoaiDonVi"] = pLoaiThuoc.MaLoaiDonVi;
                    r["MaLoaiCachDung"] = pLoaiThuoc.MaLoaiCachDung;
                    r["DonGia"] = pLoaiThuoc.DonGia;
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
        #endregion

        public string GetMaLoaiThuocLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiThuoc FROM LOAITHUOC where MaLoaiThuoc like 'LT%' ORDER BY MaLoaiThuoc DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "LT00";
            }
            
        }
    }
}
