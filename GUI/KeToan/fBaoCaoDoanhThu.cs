using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
 
namespace GUI
{
    public partial class fBaoCaoDoanhThu : Form
    {
        BUS_HoaDon bus_hoaDon = new BUS_HoaDon();
        DataTable dtBaoCao;
        public fBaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        
        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                grvBaoCao.DataSource = null;
                tbxTongDoanhThu.Text = "0";

                int thang = dtpThang.Value.Month;
                int nam = dtpThang.Value.Year;
                dtBaoCao = bus_hoaDon.BaoCaoDoanhThu(thang, nam);
                dtBaoCao.Columns.Add("TiLe");
                dtBaoCao.Columns[0].ColumnName = "Ngày khám";
                dtBaoCao.Columns[1].ColumnName = "Số bệnh nhân";
                dtBaoCao.Columns[2].ColumnName = "Doanh thu";
                dtBaoCao.Columns[3].ColumnName = "Tỉ lệ";
                grvBaoCao.DataSource = dtBaoCao;

                if (grvBaoCao.Rows == null)
                    return;
                int i = 0, tongTien = 0;
                foreach (DataGridViewRow r in grvBaoCao.Rows)
                {
                    if (i == grvBaoCao.RowCount - 1)
                        break;
                    //Them STT
                    r.Cells[0].Value = ++i;

                    tongTien += Int32.Parse(r.Cells[3].Value.ToString());
                    
                }
                tbxTongDoanhThu.Text = tongTien.ToString();

                //Tinh ti le
                i = 0;
                
                foreach (DataGridViewRow r in grvBaoCao.Rows)
                {
                    //Them STT
                    double tiLe = Int32.Parse(r.Cells[3].Value.ToString()) * 1.0 / tongTien;

                    r.Cells[4].Value = (Math.Round(tiLe * 100, 1)).ToString() + @"%";

                    i++;
                    if (i == grvBaoCao.RowCount - 1)
                        break;
                }
            }
            catch { }
            

        }

        Bitmap bmp;
         private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                //float currentDPI = (float)Microsoft.Win32.Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", 96);
                //float scale = 96 / (float)currentDPI;
                //MessageBox.Show(getScalingFactor().ToString());

                Graphics g = this.CreateGraphics();
                bmp = new Bitmap((int)(this.Size.Width * getScalingFactor()), (int)(this.Size.Height * getScalingFactor()), g);
                Graphics mg = Graphics.FromImage(bmp);

                Size t = new Size((int)((this.Size.Width-10) * getScalingFactor()), (int)((this.Size.Height - 38) * getScalingFactor()));
                btnIn.Hide();
                btnXuatExcel.Hide();
                btnXem.Hide();
                mg.CopyFromScreen((int)((this.Location.X + 10) * getScalingFactor()), (int)((this.Location.Y + 30) * getScalingFactor()), 0, 0, t);
                printPreviewDialog1.ShowDialog();
                btnXem.Show();
                btnIn.Show();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy máy in nào được kết nối!", "Không tìm thấy thiết bị!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
        #region Get Scaling of Screen
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }


        private float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(IntPtr.Zero);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES);

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }

        #endregion
        private void fBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

        }

     private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            
             try
            {
                ExportToExcel excel = new ExportToExcel();
                // Lấy về nguồn dữ liệu cần Export là 1 DataTable
                // DataTable này mỗi bạn lấy mỗi khác. 
                // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
                // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
                // DataGridView nhé 
                DataTable dt = (DataTable)grvBaoCao.DataSource;
                try
                {
                    if (dt.Rows[0].ItemArray[0]==null)
                    {
                        MessageBox.Show("Lỗi: Bảng báo cáo này rỗng!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi: Bảng báo cáo này rỗng!");
                    return;
                }
                
                string thangNam = dtpThang.Value.Month.ToString()+@"-"+dtpThang.Value.Year.ToString();
                string sheetName = "DoanhThu-" + thangNam;
                string tieuDe = "BÁO CÁO DOANH THU THÁNG " + thangNam;
                string tongKet = "TỔNG DOANH THU: " + tbxTongDoanhThu.Text;

                excel.Export(dt, sheetName, tieuDe,tongKet);

            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi trong quá trình liên kết đến MS.Excel trên thiết bị!");
            }
        } 

   
    }
}
