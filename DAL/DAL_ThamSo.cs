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
    public class DAL_ThamSo:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_ThamSo()
        {
            dt = GetThongTinTatCaThamSo();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin

        public DataTable GetThongTinTatCaThamSo()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from THAMSO", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public int GetGiaTriThamSo(string tenThamSo)
        {
            try
            {
                string query = "SELECT TriGiaThamSo FROM THAMSO where TenThamSo='"+tenThamSo+"'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return Int32.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            catch
            {
                return -1;
            }
        }

        public string GetMaThamSoLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaThamSo FROM THAMSO ORDER BY MaThamSo DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "TS00";
            }
        }
        #endregion

        #region Them Xoa Sua
        public bool Add(DTO_ThamSo pThamSo)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from THAMSO", _cn);
                DataRow r = dt.NewRow();
                r["MaThamSo"] = pThamSo.MaThamSo;
                r["TenThamSo"] = pThamSo.TenThamSo;
                r["TriGiaThamSo"] = pThamSo.TriGiaThamSo;
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

       

        public bool Delete(string pMaThamSo)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from THAMSO", _cn);
                DataRow r = dt.Rows.Find(pMaThamSo);
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


        public bool Update(DTO_ThamSo pThamSo)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from THAMSO", _cn);
                DataRow r = dt.Rows.Find(pThamSo.MaThamSo);
                if (r != null)
                {
                    r["MaThamSo"] = pThamSo.MaThamSo;
                    r["TenThamSo"] = pThamSo.TenThamSo;
                    r["TriGiaThamSo"] = pThamSo.TriGiaThamSo;
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
