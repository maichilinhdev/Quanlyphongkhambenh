using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
 
namespace GUI
{
    public partial class fTraCuuHoaDon : Form
    {
        BUS_HoaDon bus_hoaDon = new BUS_HoaDon();
        BUS_PhieuKham bus_phieuKham = new BUS_PhieuKham();
        BUS_DonThuoc bus_donThuoc = new BUS_DonThuoc();

        DataTable dtHoaDon;
        DataTable dtDonThuoc;
        

        
        public fTraCuuHoaDon()
        {
            InitializeComponent();

        }
        
        private void btnTraCuu_Click(object sender, EventArgs e)
        {

            tbxMaBN.Text = "";
            tbxHoTen.Text = "";
            tbxMaHoaDon.Text = "";
            tbxTienKham.Text = "";
            tbxTienThuoc.Text = "";
            tbxTongTien.Text = "";
            tbxNgayKham.Text = "";
            grvCTTienThuoc.DataSource = null;

            //*******************Lay thong tin tong quat Hoa Don***************
            dtHoaDon = bus_hoaDon.GetThongTinHoaDonFromPhieuKham(tbxMaPK.Text);
            if(dtHoaDon==null)
            {
                MessageBox.Show("Hóa đơn không tồn tại!");
                return;
            }
            try
            {
                tbxMaBN.Text = dtHoaDon.Rows[0].ItemArray[1].ToString();
                tbxHoTen.Text = dtHoaDon.Rows[0].ItemArray[2].ToString();
                tbxMaHoaDon.Text = dtHoaDon.Rows[0].ItemArray[3].ToString();

                tbxTienKham.Text = dtHoaDon.Rows[0].ItemArray[4].ToString();
                tbxTienThuoc.Text = dtHoaDon.Rows[0].ItemArray[5].ToString();
                tbxTongTien.Text = (Int32.Parse(tbxTienKham.Text) + Int32.Parse(tbxTienThuoc.Text)).ToString();

                string ngayKham = dtHoaDon.Rows[0].ItemArray[6].ToString();
                ngayKham = ngayKham[8].ToString() + ngayKham[9].ToString() + "/" + ngayKham[6].ToString() + ngayKham[7].ToString() +
                            "/" + ngayKham[2].ToString() + ngayKham[3].ToString() + ngayKham[4].ToString() + ngayKham[5].ToString();
                tbxNgayKham.Text = ngayKham;

                //*******************Lay thong tin chi tiet Tien Thuoc***************
                try
                {
                    dtDonThuoc = bus_donThuoc.GetThongTinTienThuocFromPhieuKham(tbxMaPK.Text);
                    dtDonThuoc.Columns[0].ColumnName = "Tên thuốc";
                    dtDonThuoc.Columns[1].ColumnName = "Số lượng";
                    dtDonThuoc.Columns[2].ColumnName = "Đơn vị";
                    dtDonThuoc.Columns[3].ColumnName = "Thành tiền";
                    dtDonThuoc.Columns.Remove(dtDonThuoc.Columns[3]);
                    grvCTTienThuoc.DataSource = dtDonThuoc;
                }
                catch // khong co thuoc
                { }
                

            }
            catch
            {
                MessageBox.Show("Hóa đơn không tồn tại!");
                return;
            } 
        }

        //private void tbxMaPK_TextChanged(object sender, EventArgs e)
        //{
        //    GetSourceComplete();
        //}

        void GetSourceComplete()
        {
            DataTable dtAuToCompleteMaPK = bus_phieuKham.GetTatCaMaPK(tbxMaPK.Text);
            if (dtAuToCompleteMaPK == null)
                return;

            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in dtAuToCompleteMaPK.Rows)
            {
                autoSourceCollection.Add(row[0].ToString());
            }
            tbxMaPK.AutoCompleteCustomSource = autoSourceCollection;
            
        }

        private void tbxMaPK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnTraCuu_Click(sender, e);
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
                bmp = new Bitmap((int)(this.Size.Width*getScalingFactor()),(int)(this.Size.Height*getScalingFactor()), g);
                Graphics mg = Graphics.FromImage(bmp);

                Size t = new Size((int)((this.Size.Width-20) * getScalingFactor()), (int)((this.Size.Height-38) * getScalingFactor()));
                btnIn.Hide();
                btnTraCuu.Hide();
                mg.CopyFromScreen((int)((this.Location.X+10)*getScalingFactor()),(int) ((this.Location.Y+30)*getScalingFactor()), 0, 0,t);
                printPreviewDialog1.ShowDialog();
                btnTraCuu.Show();
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


       /* public Size GetDpiSafeResolution()
        {
            using (Graphics graphics = this.CreateGraphics())
            {
                return new Size((Screen.PrimaryScreen.Bounds.Width * (int)graphics.DpiX) / 96
                  , (Screen.PrimaryScreen.Bounds.Height * (int)graphics.DpiY) / 96);
            }
        }*/

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
    }
}
