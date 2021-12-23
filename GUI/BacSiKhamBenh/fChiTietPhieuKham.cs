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
    public partial class fChiTietPhieuKham : Form
    {
        BUS_DonThuoc bus_donThuoc=new BUS_DonThuoc();
        BUS_HoaDon bus_hoaDon = new BUS_HoaDon();
        BUS_PhieuKham bus_phieuKham = new BUS_PhieuKham();
        DataTable dtDonThuoc;

        public fChiTietPhieuKham(string maPK, string maBenhNhan,string hoTen, string ngayKham, string tenBenh, string trieuChung)
        {
            InitializeComponent();

            tbxMaPhieuKham.Text = maPK;
            tbxMaBenhNhan.Text = maBenhNhan;
            tbxTenBenhNhan.Text = hoTen;
            tbxNgayKham.Text = ngayKham;
            tbxLoaiBenh.Text = tenBenh;
            tbxTrieuChung.Text = trieuChung;

            dtDonThuoc = bus_donThuoc.GetThongTinDonThuocFromPhieuKham(maPK);
            dtDonThuoc.Columns[0].ColumnName = "Tên thuốc";
            dtDonThuoc.Columns[1].ColumnName = "Số lượng";
            dtDonThuoc.Columns[2].ColumnName = "Đơn vị";
            dtDonThuoc.Columns[3].ColumnName = "Cách dùng";
            grvDSThuoc.DataSource = dtDonThuoc;

        }
        Bitmap bmp;
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics mg = Graphics.FromImage(bmp);
                mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printPreviewDialog1.ShowDialog();
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

        private void btnXoaPhieuKham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu khám này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (!bus_donThuoc.XoaDonThuocCoMaPK(tbxMaPhieuKham.Text))
                {
                    MessageBox.Show("Xóa đơn thuốc thất bại!");
                }
                else if (!bus_hoaDon.XoaHoaDonCoMaPK(tbxMaPhieuKham.Text))
                {
                    MessageBox.Show("Xóa hóa đơn thất bại!");
                }
                else if (!bus_phieuKham.Delete(tbxMaPhieuKham.Text))
                {
                    MessageBox.Show("Xóa phiếu khám thất bại!");
                }


                this.Close();
            }
            
        }

        private void fChiTietPhieuKham_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        
    }
}
