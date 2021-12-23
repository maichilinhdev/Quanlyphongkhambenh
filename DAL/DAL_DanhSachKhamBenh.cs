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
    public class DAL_DanhSachKhamBenh : DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_DanhSachKhamBenh()
        {
            dt = GetThongTinTatCaDanhSach();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public DataTable GetThongTinTatCaDanhSach()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from DANHSACHKHAMBENH", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool CheckDanhSachTonTai(string maDS)
        {
            try
            {
                
                SqlDataAdapter da = new SqlDataAdapter("select MaDSKB from DANHSACHKHAMBENH where MaDSKB="+maDS, _cn);
                DataRow r = dt.Rows.Find(maDS);
                if (r != null)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        #region Them, xoa, sua co ban
        public bool ThemDanhSach(DTO_DanhSachKhamBenh pDSKB)
        {
            try
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from DANHSACHKHAMBENH", _cn);
                DataRow r = dt.NewRow();
                r["MaDSKB"] = pDSKB.MaDSKB;
                //Format date                
                r["NgayKhamBenh"] = pDSKB.NgayKhamBenh.ToShortDateString();
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

        public bool Delete(string pMaDSKB)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DANHSACHKHAMBENH", _cn);
                DataRow r = dt.Rows.Find(pMaDSKB);
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


        public bool Update(DTO_DanhSachKhamBenh pDSKB)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DANHSACHKHAMBENH", _cn);
                DataRow r = dt.Rows.Find(pDSKB.MaDSKB);
                if (r != null)
                {
                    r["MaDSKB"] = pDSKB.MaDSKB;
                    r["NgayKhamBenh"] = pDSKB.NgayKhamBenh;
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

        public DataTable LayDanhSachKhamBenh(string mdy)
        {
            try
            {
                string query = @"exec GetDanhSachKhamBenh @ngayKhamBenh='" + mdy + @"'";
                //query = @"exec GetDanhSachKhamBenh @ngayKhamBenh='5/6/2019'";

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

    }
}
