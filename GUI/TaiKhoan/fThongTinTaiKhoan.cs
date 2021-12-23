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
    public partial class fThongTinTaiKhoan : Form
    {
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        string TaiKhoan;
        public fThongTinTaiKhoan(string pTaiKhoan)
        {
            TaiKhoan = pTaiKhoan;
            InitializeComponent();
            tbxTenTK.Text = TaiKhoan;
            tbxTenHienThi.Text = bus_TaiKhoan.GetTenFromTenTaiKhoan(TaiKhoan);
            tbxChucVu.Text = bus_TaiKhoan.GetChucVuFromTenTaiKhoan(TaiKhoan);
            LoadQuyen(Int32.Parse(bus_TaiKhoan.GetQuyenFromTenTaiKhoan(TaiKhoan)));
        }

        void LoadQuyen(int i)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            int indexCheck = 0;
            while (i > 0)
            {
                indexCheck = i % 10;
                switch (indexCheck)
                {
                    case 1:
                        checkBox1.Checked = true;
                        break;
                    case 2:
                        checkBox2.Checked = true;
                        break;
                    case 3:
                        checkBox3.Checked = true;
                        break;
                    case 4:
                        checkBox4.Checked = true;
                        break;
                    case 5:
                        checkBox5.Checked = true;
                        break;
                    case 6:
                        checkBox6.Checked = true;
                        break;
                    default: break;
                }
                i /= 10;
            }
        }

        private void fThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox7.Checked)
                grbDoiMK.Enabled = false;
            else
                grbDoiMK.Enabled = true;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (bus_TaiKhoan.GetMatKhauFromTenTaiKhoan(TaiKhoan) != Hash256.Hash256Data(tbxTenTK.Text + tbxMKCu.Text))
            {
                MessageBox.Show("Nhập mật khẩu cũ bị sai!");
                tbxMKCu.Clear();
                return;
            }
            if (tbxMKMoi.Text == tbxMKCu.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ!");
                tbxMKMoi.Clear();
                return;
            }
            if (tbxMKMoi.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu mới phải 5 kí tự trở lên!");
                tbxMKMoi.Clear();
                return;
            }
            if (tbxMKMoi.Text != tbxNhapLaiMK.Text)
            {
                MessageBox.Show("Hai mật khẩu mới phải giống nhau!");
                // tbxMKCu.Clear();
                tbxNhapLaiMK.Clear();
                return;
            }

            DTO_TaiKhoan pTaiKhoan = new DTO_TaiKhoan(TaiKhoan, tbxTenHienThi.Text, tbxChucVu.Text, Int32.Parse(bus_TaiKhoan.GetQuyenFromTenTaiKhoan(TaiKhoan)), Hash256.Hash256Data(tbxTenTK.Text + tbxMKMoi.Text));
            if (bus_TaiKhoan.Update(pTaiKhoan))
                MessageBox.Show("Đổi mật khẩu thành công!");
            else
                MessageBox.Show("Đổi mật khẩu thất bại");
            tbxMKCu.Clear();
            tbxMKMoi.Clear();
            tbxNhapLaiMK.Clear();
            checkBox7.Checked = false;
        }
        
    }
}
