using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fMainForm : Form
    {
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        string TaiKhoan;
        public fMainForm(string pTaiKhoan)
        {
            TaiKhoan = pTaiKhoan;
            // MessageBox.Show(TaiKhoan);
            InitializeComponent();

            //PhanQuyen(Int32.Parse(bus_TaiKhoan.GetQuyenFromTenTaiKhoan(TaiKhoan)));

            //btnXemDSPhieuKham.Text = "Xem danh sách\n phiếu khám bệnh";

        }
        public void SetTaiKhoan(string pTaiKhoan)
        {
            TaiKhoan = pTaiKhoan;
        }

        //public void PhanQuyen(int i)
        //{
        //    grbTiepTan.Enabled = false;
        //    grbBacSi.Enabled = false;
        //    grbQuanTriVien.Enabled = false;
        //    grbKeToan.Enabled = false;
        //    tabQLThuoc.Enabled = false;
        //    tabKhamBenh.Enabled = false;
        //    tabThuTien.Enabled = false;
        //    //tabThuKho.Enabled = false;
        //    tabBaoCao.Enabled = false;
        //    int indexCheck = 0;
        //    while (i > 0)
        //    {
        //        indexCheck = i % 10;
        //        switch (indexCheck)
        //        {
        //            case 1:
        //                grbQuanTriVien.Enabled = true;
        //                break;
        //            case 2:
        //                grbTiepTan.Enabled = true;
        //                break;
        //            case 3:
        //                grbBacSi.Enabled = true;
        //                tabKhamBenh.Enabled = true;
        //                break;
        //            case 4:
        //                grbBacSi.Enabled = true;
        //                tabQLThuoc.Enabled = true;
        //                break;
        //            case 5:
        //                grbKeToan.Enabled = true;
        //                tabThuTien.Enabled = true;
        //                break;
        //            case 6:
        //                grbKeToan.Enabled = true;
        //                //tabThuKho.Enabled = true;
        //                tabBaoCao.Enabled = true;
        //                break;
        //            default: break;
        //        }
        //        i /= 10;
        //    }

        //}

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fThemBenhNhan addBenhNhan = new fThemBenhNhan();
            addBenhNhan.ShowDialog();
           // panel2.Controls.Add(addBenhNhan);
            //panel2.Controls.Remove(addBenhNhan);
            //addBenhNhan.Hide();
            //this.Controls.Add(addBenhNhan);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void phânQuềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhanQuyen fPhanQuyen = new fPhanQuyen();
            fPhanQuyen.ShowDialog();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fThemBenhNhan f = new fThemBenhNhan();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fLapPhieuKham f = new fLapPhieuKham();
            f.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //fXemDanhSachKham f = new fXemDanhSachKham();
            //f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //fTaoDanhSachKham f = new fTaoDanhSachKham();
           // f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fThemBenhNhanVaoDanhSachKham f = new fThemBenhNhanVaoDanhSachKham();
            f.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
           // fTraCuuBenhNhan f = new fTraCuuBenhNhan();
            //f.ShowDialog();
            
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            fThemThuoc f = new fThemThuoc();
            f.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //fTraCuuThuoc f = new fTraCuuThuoc();
            //f.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //fDoiThongTinThuoc f = new fDoiThongTinThuoc();
            //f.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            fPhanQuyen f = new fPhanQuyen();
            f.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f = new fThemTaiKhoan();
            f.ShowDialog();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            fXoaTaiKhoan f = new fXoaTaiKhoan();
            f.ShowDialog();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            fXemDanhSachTaiKhoan f = new fXemDanhSachTaiKhoan();
            f.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //fLapHoaDon f = new fLapHoaDon();
           // f.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //fSuaHoaDon f = new fSuaHoaDon();
            //f.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            //fInHoaDon f = new fInHoaDon();
           // f.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fBaoCaoDoanhThu f = new fBaoCaoDoanhThu();
            f.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            fThongKeSuDungThuoc f = new fThongKeSuDungThuoc();
            f.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //fTraCuuPhieuKham f = new fTraCuuPhieuKham();
            //f.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TranHoangLong_1811546681_18DTH2D \nGVHD:Thầy Nguyễn Xuân Cường \nĐề tài: Phần mềm quản lý PKBS GD\nVersoin 1.0");
            
        }
       
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("NO UPDATE :)))", "Update", MessageBoxButtons.OKCancel);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin fLogin = new fLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTinTaiKhoan f = new fThongTinTaiKhoan(TaiKhoan);
            f.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            fXemDanhSachPhieuKham f = new fXemDanhSachPhieuKham();
            f.ShowDialog();
        }

        private void btnTraCuuHoaDon_Click(object sender, EventArgs e)
        {
            fTraCuuHoaDon formHoaDon = new fTraCuuHoaDon();
            formHoaDon.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fQuanLyThamSo f = new fQuanLyThamSo();
            f.ShowDialog();
        }

        private void btnQuanLyBenh_Click(object sender, EventArgs e)
        {
            fQuanLyBenh f = new fQuanLyBenh();
            f.ShowDialog();

        }

        private void btnDonViThuoc_Click(object sender, EventArgs e)
        {
            fDonViThuoc f = new fDonViThuoc();
            f.ShowDialog();
        }

        private void btnCachSuDungThuoc_Click(object sender, EventArgs e)
        {
            fQuanLyCachDung f = new fQuanLyCachDung();
            f.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            fHdsd f = new fHdsd();
            f.ShowDialog();
        }

        private void quanLyBenhNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemBenhNhan f = new fThemBenhNhan();
            f.ShowDialog();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void quanLyBacSiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quanLyBenhNhanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThemBenhNhan f = new fThemBenhNhan();
            f.ShowDialog();
        }

        private void danhSachKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemBenhNhanVaoDanhSachKham f = new fThemBenhNhanVaoDanhSachKham();
            f.ShowDialog();
        }

        private void lapPhieuKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLapPhieuKham f = new fLapPhieuKham();
            f.ShowDialog();
        }

        private void xemDanhSachPhieuKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemDanhSachPhieuKham f = new fXemDanhSachPhieuKham();
            f.ShowDialog();
        }

        private void quanLyThuocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fThemThuoc f = new fThemThuoc();
            f.ShowDialog();
        }

        private void donViThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDonViThuoc f = new fDonViThuoc();
            f.ShowDialog();
        }

        private void cachSuDungThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyCachDung f = new fQuanLyCachDung();
            f.ShowDialog();
        }

        private void themNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemTaiKhoan f = new fThemTaiKhoan();
            f.ShowDialog();
        }

        private void xoaNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXoaTaiKhoan f = new fXoaTaiKhoan();
            f.ShowDialog();
        }

        private void xemDanhSachNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemDanhSachTaiKhoan f = new fXemDanhSachTaiKhoan();
            f.ShowDialog();
        }

        private void phanQuyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhanQuyen f = new fPhanQuyen();
            f.ShowDialog();
        }

        private void traCuuHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTraCuuHoaDon formHoaDon = new fTraCuuHoaDon();
            formHoaDon.ShowDialog();
        }

        private void baoCaoDanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fBaoCaoDoanhThu f = new fBaoCaoDoanhThu();
            f.ShowDialog();
        }

        private void thongKeSuDungThuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongKeSuDungThuoc f = new fThongKeSuDungThuoc();
            f.ShowDialog();
        }

        private void fMainForm_Load(object sender, EventArgs e)
        {

        }

        private void quanLyBenhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyBenh f = new fQuanLyBenh();
            f.ShowDialog();
        }
    }
   }
   
    
    

