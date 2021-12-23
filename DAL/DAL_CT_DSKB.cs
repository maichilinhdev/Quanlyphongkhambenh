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
    public class DAL_CT_DSKB:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_CT_DSKB()
        {
            dt = GetThongTinTatCaCT_DSKB();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        public DataTable GetThongTinTatCaCT_DSKB()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CT_DSKB", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetLastMaCTDSKB()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaCTDSKB FROM CT_DSKB ORDER BY MaCTDSKB DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch {
                return "CT0000000";
            }
        }

        //public string GetMaPKLast()
        //{
        //    SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaPK FROM CT_DSKB ORDER BY MaPK DESC", _cn);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt.Rows[0].ItemArray[0].ToString();
        //}

        #region Them, xoa, sua co ban
        public bool ThemCTDSKB(DTO_CT_DSKB pCTDSKB)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CT_DSKB", _cn);
                DataRow r = dt.NewRow();//dt.NewRow();
                r["MaCTDSKB"] = pCTDSKB.MaCTDSKB;
                r["MaDSKB"] = pCTDSKB.MaDSKB;
                r["MaBenhNhan"] = pCTDSKB.MaBenhNhan;

                dt.Rows.Add(r);

                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch
            {
                dt = GetThongTinTatCaCT_DSKB();
                dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
                return false;
            }
        }

        public DataTable GetThongTinBenhNhanKhamBenh(string maPK, string maBenhNhan, string tenBenhNhan, string ngayKham, string cmnd, string sdt)
        {
            try
            {
                string query = @"exec TraCuuDanhSachBenhNhanKhamBenh @maPK='"+maPK
                                + "',@maBenhNhan='" + maBenhNhan
                                + "', @tenBenhNhan=N'" + tenBenhNhan
                                + "', @MaDSKB_NgayKham='" + ngayKham
                                + "', @cmnd='" + cmnd
                                + "', @sdt='" + sdt
                                + "'";
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

        public string GetMaCTDSKB(string maDSKB, string maBenhNhan)
        {
            try
            {
                string query = @"exec KiemTraBenhNhanCoTrongDanhSach @maBenhNhan='" + maBenhNhan
                                + @"', @maDSKB='" + maDSKB + @"'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0] != null)
                {
                    return dt.Rows[0].ItemArray[0].ToString();
                }
                else
                    return "";
            }
            catch
            {
                return "";
            }
        }

        public bool Delete(string pMaCTDSKB)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CT_DSKB", _cn);
                DataRow r = dt.Rows.Find(pMaCTDSKB);
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


        public bool Update(DTO_CT_DSKB pCTDSKB)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from CT_DSKB", _cn);
                DataRow r = dt.Rows.Find(pCTDSKB.MaCTDSKB);
                if (r != null)
                {
                    r["MaCTDSKB"] = pCTDSKB.MaCTDSKB;
                    r["MaDSKB"] = pCTDSKB.MaDSKB;
                    r["MaBenhNhan"] = pCTDSKB.MaBenhNhan;
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

        public bool KiemTraBenhNhanCoTrongDanhSach(string maDS,string maBenhNhan)
        {
            try
            {
                string query = @"exec KiemTraBenhNhanCoTrongDanhSach @maBenhNhan='"+ maBenhNhan 
                                + @"', @maDSKB='" + maDS + @"'";
                SqlDataAdapter da = new SqlDataAdapter(query, _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0]!= null)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
