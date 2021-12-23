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
    public class DAL_PhieuKham: DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_PhieuKham()
        {
            dt = GetThongTinTatCaPhieuKham();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public DataTable GetThongTinTatCaPhieuKham()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUKHAM", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetTatCaMaPK(string maPKGoiY)
        {
            
            try
            {
                string query = @"select top 5 MaPK from PHIEUKHAM where MaPK like '"+maPKGoiY+@"' + '%'";
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

        public string GetMaPKLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaPK FROM PHIEUKHAM ORDER BY MaPK DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "PK0000000";
            }
        }

        #region Them, xoa, sua co ban
        public bool ThemPhieuKham(DTO_PhieuKham pPhieuKham)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUKHAM", _cn);
                DataRow r = dt.NewRow();
                r["MaPK"] = pPhieuKham.MaPK;
                r["MaCTDSKB"] = pPhieuKham.MaCTDSKB;
                r["TrieuChung"] = pPhieuKham.TrieuChung;
                r["MaLoaiBenh"] = pPhieuKham.MaLoaiBenh;
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

        public bool Delete(string pMaPK)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUKHAM", _cn);
                DataRow r = dt.Rows.Find(pMaPK);
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


        public bool Update(DTO_PhieuKham pPhieuKham)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUKHAM", _cn);
                DataRow r = dt.Rows.Find(pPhieuKham.MaPK);
                if (r != null)
                {
                    r["MaPK"] = pPhieuKham.MaPK;
                    r["MaCTDSKB"] = pPhieuKham.MaCTDSKB;
                    r["TrieuChung"] = pPhieuKham.TrieuChung;
                    r["MaLoaiBenh"] = pPhieuKham.MaLoaiBenh;
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


    }
}
