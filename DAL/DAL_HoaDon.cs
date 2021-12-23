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
    public class DAL_HoaDon:DAL_DBConnect
    {
        DataTable dt = new DataTable();
        public DAL_HoaDon()
        {
            dt = GetThongTinTatCaHoaDon();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }

        #region Get Thong Tin

        public DataTable GetThongTinTatCaHoaDon()
        {
            try
            {
                //phai using System.Data.SqlClient;
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable BaoCaoDoanhThu(int thang, int nam)
        {
            try
            {
                string query = "exec BaoCaoDoanhThu @thang='"+thang+"', @nam='"+nam+"'";
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

        public string GetMaHoaDonLast()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TOP 1 MaHoaDon FROM HOADON ORDER BY MaHoaDon DESC", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0].ItemArray[0].ToString();
            }
            catch
            {
                return "HD00000000";
            }
        }

        public bool XoaHoaDonCoMaPK(string maPK)
        {
            try
            {
                string query = @"delete from HOADON where MaPK='" + maPK + "'";
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
        #endregion

        #region Them Xoa Sua
        public bool Add(DTO_HoaDon pHoaDon)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", _cn);
                DataRow r = dt.NewRow();
                r["MaHoaDon"] = pHoaDon.MaHoaDon;
                r["MaPK"] = pHoaDon.MaPK;
                r["TienKham"] = pHoaDon.TienKham;
                r["TienThuoc"] = pHoaDon.TienThuoc;
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

        public DataTable GetThongTinHoaDonFromPhieuKham(string maPK)
        {
            try
            {
                string query = "exec LayThongTinHoaDon @MaPK='" + maPK + "'";
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

        public bool Delete(string pMaDt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", _cn);
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


        public bool Update(DTO_HoaDon pHoaDon)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", _cn);
                DataRow r = dt.Rows.Find(pHoaDon.MaHoaDon);
                if (r != null)
                {
                    r["MaHoaDon"] = pHoaDon.MaHoaDon;
                    r["MaPK"] = pHoaDon.MaPK;
                    r["TienKham"] = pHoaDon.TienKham;
                    r["TienThuoc"] = pHoaDon.TienThuoc;
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
