using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DAL_LoaiDonVi:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_LoaiDonVi()
        {
            dt = GetThongTinTatCaLoaiDonVi();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin

        public DataTable GetThongTinTatCaLoaiDonVi()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIDONVI", _cn);
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
        public bool Add(DTO_LoaiDonVi pLoaiDonVi)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIDONVI", _cn);
                DataRow r = dt.NewRow();
                r["MaLoaiDonVi"] = pLoaiDonVi.MaLoaiDonVi;
                r["TenLoaiDonVi"] = pLoaiDonVi.TenLoaiDonVi;
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

        public bool Delete(string pMaLoaiDonVi)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIDONVI", _cn);
                DataRow r = dt.Rows.Find(pMaLoaiDonVi);
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


        public bool Update(DTO_LoaiDonVi pLoaiDonVi)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIDONVI", _cn);
                DataRow r = dt.Rows.Find(pLoaiDonVi.MaLoaiDonVi);
                if (r != null)
                {
                    r["MaLoaiDonVi"] = pLoaiDonVi.MaLoaiDonVi;
                    r["TenLoaiDonVi"] = pLoaiDonVi.TenLoaiDonVi;
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

        public string GetMaLoaiDonViLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiDonVi FROM LOAIDONVI ORDER BY MaLoaiDonVi DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "DV00";
            }
        }
    }
}
