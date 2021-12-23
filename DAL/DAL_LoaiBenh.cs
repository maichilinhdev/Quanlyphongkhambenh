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
    public class DAL_LoaiBenh:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_LoaiBenh()
        {
            dt = GetThongTinTatCaLoaiBenh();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin

        public DataTable GetThongTinTatCaLoaiBenh()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIBENH", _cn);
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
        public bool Add(DTO_LoaiBenh pLoaiBenh)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIBENH", _cn);
                DataRow r = dt.NewRow();
                r["MaLoaiBenh"] = pLoaiBenh.MaLoaiBenh;
                r["TenLoaiBenh"] = pLoaiBenh.TenLoaiBenh;
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

        public bool Delete(string pMaLoaiBenh)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIBENH", _cn);
                DataRow r = dt.Rows.Find(pMaLoaiBenh);
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


        public bool Update(DTO_LoaiBenh pLoaiBenh)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LOAIBENH", _cn);
                DataRow r = dt.Rows.Find(pLoaiBenh.MaLoaiBenh);
                if (r != null)
                {
                    r["MaLoaiBenh"] = pLoaiBenh.MaLoaiBenh;
                    r["TenLoaiBenh"] = pLoaiBenh.TenLoaiBenh;
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

        public string GetMaLoaiBenhLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaLoaiBenh FROM LOAIBENH ORDER BY MaLoaiBenh DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "LB00";
            }
        }
    }
}
