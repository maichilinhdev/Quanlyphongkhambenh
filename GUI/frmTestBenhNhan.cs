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
    public partial class frmTestBenhNhan : Form
    {
        BUS_BenhNhan bus_benhNhan = new BUS_BenhNhan();

        public frmTestBenhNhan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DTO_BenhNhan benhNhan = new DTO_BenhNhan(tbxMaBenhNhan.Text.ToString(), tbxHoTen.Text.ToString(), cbxGioiTinh.SelectedItem.ToString(),
                                          Int32.Parse(tbxNamSinh.Text.ToString()), tbxDiaChi.Text.ToString(),"000","000");
            //DTO_BenhNhan benhNhan = new DTO_BenhNhan();
            //benhNhan.MaBenhNhan = tbxMaBenhNhan.Text.ToString();
            //benhNhan.HoTen = tbxHoTen.Text.ToString();
            //benhNhan.GioiTinh = cbxGioiTinh.SelectedItem.ToString();
            //benhNhan.NamSinh = Int32.Parse(tbxNamSinh.Text.ToString());
            //benhNhan.DiaChi = tbxDiaChi.Text.ToString();


            if (bus_benhNhan.ThemBenhNhan(benhNhan))
            {
                MessageBox.Show("Thêm bệnh nhân thành công!");
            }
            else
            {
                MessageBox.Show("Thêm bệnh nhân thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bus_benhNhan.Delete(tbxMaBenhNhan.Text))
            {
                MessageBox.Show("Xóa thành công bệnh nhân!");
            }
            else
            {
                MessageBox.Show("Xóa bệnh nhân thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_BenhNhan benhNhan = new DTO_BenhNhan(tbxMaBenhNhan.Text.ToString(), tbxHoTen.Text.ToString(), cbxGioiTinh.SelectedItem.ToString(),
                                            Int32.Parse(tbxNamSinh.Text.ToString()), tbxDiaChi.Text.ToString(), "000", "000");
            if (bus_benhNhan.Update(benhNhan))
            {
                MessageBox.Show("Sửa bệnh nhân thành công!");
            }
            else
            {
                MessageBox.Show("Sửa bệnh nhân thất bại!");
            }
        }

        private void frmTestBenhNhan_Load(object sender, EventArgs e)
        {
            //Load len load het luon
            cbxTestLoadTen.DataSource = bus_benhNhan.Get_Ten();

            //Hien thi cot nao, gia tri cot nao
            cbxTestLoadTen.DisplayMember = "HoTen";
            cbxTestLoadTen.ValueMember = "MaBenhNhan";
        }
    }
}
