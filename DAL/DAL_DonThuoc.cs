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
    public class DAL_DonThuoc:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_DonThuoc()
        {
            dt = GetThongTinTatCaDonThuoc();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin

        public DataTable GetThongTinTatCaDonThuoc()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from DONTHUOC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }


        public DataTable GetThongTinDonThuocFromPhieuKham(string maPK)
        {
            try
            {
                string query = "exec LayThongTinDonThuoc @MaPK='" + maPK + "'";
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

        public string GetMaDonThuocLast()
        {
            try
            { 
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaDT FROM DONTHUOC ORDER BY MaDT DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "DT00000000";
            }
        }

        public DataTable GetThongTinTienThuocFromPhieuKham(string maPK)
        {
            try
            {
                string query = "exec LayThongTinTienThuoc @MaPK='" + maPK + "'";
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

        public bool XoaDonThuocCoMaPK(string maPK)
        {
            try
            {
                string query = @"delete from DONTHUOC where MaPK='"+maPK+"'";
                _cn.Open();
                using (SqlCommand command = new SqlCommand(query, _cn))
                {
                    command.ExecuteNonQuery();
                }
                _cn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable GetBangThongKeSuDungThuoc(int thang, int nam)
        {
            //exec ThongKeSuDungThuoc @thang='6', @nam='2019'
            try
            {
                string query = "exec ThongKeSuDungThuoc @thang='" + thang + "', @nam='" + nam + "'";
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


        #endregion

        #region Them Xoa Sua
        public bool Add(DTO_DonThuoc pDonThuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DONTHUOC", _cn);
                DataRow r = dt.NewRow();
                r["MaDT"] = pDonThuoc.MaDT;
                r["MaPK"] = pDonThuoc.MaPK;
                r["MaLoaiThuoc"] = pDonThuoc.MaLoaiThuoc;
                r["SoLuong"] = pDonThuoc.SoLuong;
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

        public bool Delete(string pMaDt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DONTHUOC", _cn);
                DataRow r = dt.Rows.Find(pMaDt);
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


        public bool Update(DTO_DonThuoc pDonThuoc)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from DONTHUOC", _cn);
                DataRow r = dt.Rows.Find(pDonThuoc.MaDT);
                if (r != null)
                {
                    r["MaDT"] = pDonThuoc.MaDT;
                    r["MaPKT"] = pDonThuoc.MaPK;
                    r["MaLoaiThuoc"] = pDonThuoc.MaLoaiThuoc;
                    r["SoLuong"] = pDonThuoc.SoLuong;
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
