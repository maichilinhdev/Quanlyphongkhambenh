using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DAL_CachDung:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_CachDung()
        {
            dt = GetThongTinTatCaCachDung();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin

        public DataTable GetThongTinTatCaCachDung()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from CACHDUNG", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }


        #endregion

        #region Them Xoa Sua
        public bool Add(DTO_CachDung pLoaiCachDung)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CACHDUNG", _cn);
                DataRow r = dt.NewRow();
                r["MaLoaiCachDung"] = pLoaiCachDung.MaLoaiCachDung;
                r["TenLoaiCachDung"] = pLoaiCachDung.TenLoaiCachDung;
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

        public bool Delete(string pMaLoaiCachDung)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CACHDUNG", _cn);
                DataRow r = dt.Rows.Find(pMaLoaiCachDung);
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


        public bool Update(DTO_CachDung pLoaiCachDung)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CACHDUNG", _cn);
                DataRow r = dt.Rows.Find(pLoaiCachDung.MaLoaiCachDung);
                if (r != null)
                {
                    r["MaLoaiCachDung"] = pLoaiCachDung.MaLoaiCachDung;
                    r["TenLoaiCachDung"] = pLoaiCachDung.TenLoaiCachDung;
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

        public string GetMaLoaiCachDungLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiCachDung FROM CACHDUNG ORDER BY MaLoaiCachDung DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
                
            }
            catch
            {
                return "CD00";
            }
        }
    }
}
