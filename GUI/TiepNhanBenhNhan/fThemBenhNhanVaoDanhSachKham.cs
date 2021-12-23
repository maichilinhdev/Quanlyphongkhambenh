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
using DTO;
namespace GUI
{
    public partial class fThemBenhNhanVaoDanhSachKham : Form
    {
        BUS_BenhNhan bus_benhNhan = new BUS_BenhNhan();
        BUS_DanhSachKhamBenh bus_danhSachKhamBenh = new BUS_DanhSachKhamBenh();
        BUS_PhieuKham bus_phieuKham = new BUS_PhieuKham();
        BUS_CT_DSKB bus_ctdskb = new BUS_CT_DSKB();
        DataTable dtDSBenhNhan;

        public fThemBenhNhanVaoDanhSachKham()
        {
            InitializeComponent();
            ReloadGridViewDanhSach();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ReloadGridViewDanhSach();
        }
        
        void ReloadGridViewDanhSach()
        {
            dtDSBenhNhan = bus_danhSachKhamBenh.LayDanhSachKhamBenh(dtpNgayKham.Value);
            if (dtDSBenhNhan != null)
            {
                grvDanhSachKham.Visible = true;
                //grvDanhSachBN.AutoGenerateColumns = true;
                grvDanhSachKham.DataSource = dtDSBenhNhan;
                dtDSBenhNhan.Columns[0].ColumnName = "Mã bệnh nhân";
                dtDSBenhNhan.Columns[1].ColumnName = "Họ tên";
                dtDSBenhNhan.Columns[2].ColumnName = "Giới tính";
                dtDSBenhNhan.Columns[3].ColumnName = "Năm sinh";
                dtDSBenhNhan.Columns[4].ColumnName = "Địa chỉ";
                dtDSBenhNhan.Columns[5].ColumnName = "SĐT";
                dtDSBenhNhan.Columns[6].ColumnName = "CMND";
                for(int i=0;i< grvDanhSachKham.Rows.Count-1;i++)
                {
                    grvDanhSachKham.Rows[i].Cells[0].Value = i+1;
                }
                
                grvDanhSachKham.AutoResizeColumns();
                grvDanhSachKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // fTraCuuBenhNhan f = new fTraCuuBenhNhan();
           // f.ShowDialog();
        }

        private void cbxMaBenhNhan_KeyDown(object sender, KeyEventArgs e)
        {
            //Tu dong tim benh nhan
        }

        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            if(tbxMaBenhNhan.Text.Length>10)
            {
                MessageBox.Show("Mã bệnh nhân không hợp lệ!");
                return;
            }
            //lấy mã danh sách của ngày được chọn
            string maDS = "DS" + dtpNgayKham.Value.Year.ToString();
            if (dtpNgayKham.Value.Month < 10)
                maDS += "0" + dtpNgayKham.Value.Month.ToString();
            else
                maDS += dtpNgayKham.Value.Month.ToString();
            if(dtpNgayKham.Value.Day<10)
                maDS += "0" + dtpNgayKham.Value.Day.ToString();
            else
                maDS += dtpNgayKham.Value.Day.ToString();

            //Nếu ngày đó chưa có danh sách thì tự động tạo
            if (!bus_danhSachKhamBenh.CheckDanhSachTonTai(maDS))
            {
                DTO_DanhSachKhamBenh dskb = new DTO_DanhSachKhamBenh(maDS, dtpNgayKham.Value);
                if (!bus_danhSachKhamBenh.ThemDanhSach(dskb))
                {
                    MessageBox.Show("Thêm danh sách thất bại!");
                    return;
                }
            }
            //Đến bước này thì đã có danh sách được tạo cho ngày đấy rồi
            //Lấy mã ctDS next
            string maCTDSNext = bus_ctdskb.GetNextMaCTDSKB();
            DTO_CT_DSKB CTDS = new DTO_CT_DSKB(maCTDSNext, maDS, tbxMaBenhNhan.Text);
            if (bus_ctdskb.ThemBenhNhanVaoDanhSach(CTDS))
            {
                MessageBox.Show("Thêm thành công!");
                ReloadGridViewDanhSach();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
                return;
            }
        }

        private void btnXoaKhoiDS_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy mã danh sách của ngày được chọn
                string maDS = "DS" + dtpNgayKham.Value.Year.ToString();
                if (dtpNgayKham.Value.Month < 10)
                    maDS += "0" + dtpNgayKham.Value.Month.ToString();
                else
                    maDS += dtpNgayKham.Value.Month.ToString();
                if (dtpNgayKham.Value.Day < 10)
                    maDS += "0" + dtpNgayKham.Value.Day.ToString();
                else
                    maDS += dtpNgayKham.Value.Day.ToString();

                string maCTDS = bus_ctdskb.GetMaCTDSKB(maDS, tbxMaBenhNhan.Text);
                if(maCTDS=="")
                {
                    MessageBox.Show("Bệnh nhân không tồn tại trong danh sách khám này!");
                    return;
                }
                if(bus_ctdskb.Delete(maCTDS))
                    MessageBox.Show("Xóa thành công!");
                else
                    MessageBox.Show("Xóa thất bại!");
                ReloadGridViewDanhSach();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!");

            }
        }

        private void grvDanhSachKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbxMaBenhNhan.Text = grvDanhSachKham.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxHoTen.Text = grvDanhSachKham.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        }

        private void tbxMaBenhNhan_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                tbxHoTen.Text = bus_benhNhan.GetTenFromMaBenhNhan(tbxMaBenhNhan.Text);
            }
            catch
            {
                tbxHoTen.Text = "";
            }
            
        }
    }
}
