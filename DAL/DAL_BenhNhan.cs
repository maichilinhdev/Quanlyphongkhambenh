using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAL
{
    public class DAL_BenhNhan: DAL_DBConnect //CHU Y la PUBLIC class
    {
        //class giup xu ly tren table BENHNHAN trong SQL
        //Can ke thua lai DAL_DBConnect de co connection

        DataTable dt = new DataTable();
        public DAL_BenhNhan()
        {
            dt = GetThongTinTatCaBenhNhan();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin
        public DataTable GetThongTinTatCaBenhNhan()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", _cn);
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
        public bool ThemBenhNhan(DTO_BenhNhan pBenhNhan)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", _cn);
                DataRow r = dt.NewRow();
                r["MaBenhNhan"] = pBenhNhan.MaBenhNhan;
                r["HoTen"] = pBenhNhan.HoTen;
                r["GioiTinh"] = pBenhNhan.GioiTinh;
                r["NamSinh"] = pBenhNhan.NamSinh;
                r["DiaChi"] = pBenhNhan.DiaChi;
                r["SoDienThoai"] = pBenhNhan.SoDienThoai;
                r["CMND"] = pBenhNhan.CMND;
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

        public DataTable TimBenhNhan(string maBN, string hoTen, string cmnd, string gioiTinh, string namSinh, string sdt, string diaChi)
        {
            try
            {
                string query = "exec TimBenhNhan @maBN='"+maBN
                                + "', @hoTen=N'" + hoTen 
                                + "', @cmnd='" + cmnd 
                                + "', @gioiTinh=N'" + gioiTinh 
                                + "', @namSinh='" + namSinh 
                                + "', @sdt='" + sdt 
                                + "', @diaChi=N'" + diaChi + "'";
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

        public string GetTenFromMaBenhNhan(string pMaBenhNhan)
        {
            try
            {
                string query = @"select HoTen from BENHNHAN where MaBenhNhan='" + pMaBenhNhan + "'";
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

        public bool Delete(string pMaBenhNhan)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", _cn);
                DataRow r = dt.Rows.Find(pMaBenhNhan);
                if(r!=null)
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

      
        public bool Update(DTO_BenhNhan pBenhNhan)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", _cn);
                DataRow r = dt.Rows.Find(pBenhNhan.MaBenhNhan);
                if(r!=null)
                {
                    r["MaBenhNhan"] = pBenhNhan.MaBenhNhan;
                    r["HoTen"] = pBenhNhan.HoTen;
                    r["GioiTinh"] = pBenhNhan.GioiTinh;
                    r["NamSinh"] = pBenhNhan.NamSinh;
                    r["DiaChi"] = pBenhNhan.DiaChi;
                    r["SoDienThoai"] = pBenhNhan.SoDienThoai;
                    r["CMND"] = pBenhNhan.CMND;
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

        public string GetMaBenhNhanLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaBenhNhan FROM BENHNHAN ORDER BY MaBenhNhan DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();

            }
            catch
            {
                return "BN0000000";
            }
        }






        #region TestLoadTenLen
        public DataTable Get_Ten()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from BENHNHAN", _cn);
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




    }
}
