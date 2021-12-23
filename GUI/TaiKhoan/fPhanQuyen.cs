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
    public partial class fPhanQuyen : Form
    {
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        DataTable dtTaiKhoan;

        // lưu thông tin này để update lại 
        string ChucVu;
       // string MatKhau;
        int Quyen;
        //
        public fPhanQuyen()
        {
            InitializeComponent();
            ReloadGridViewTaiKhoan();
           
        }
            void ReloadGridViewTaiKhoan()
            {
                dtTaiKhoan = bus_TaiKhoan.GetThongTinTatCaTaiKhoan();
                if (dtTaiKhoan != null)
                {
                    grvDanhSachTK.Visible = true;
                    //grcDanhSachTK.AutoGenerateColumns = true;
                    grvDanhSachTK.DataSource = dtTaiKhoan;

                   
                    dtTaiKhoan.Columns[0].ColumnName = "Tên tài khoản";
                    dtTaiKhoan.Columns[1].ColumnName = "Tên hiển thị";
                    dtTaiKhoan.Columns[2].ColumnName = "Chức vụ";
                    dtTaiKhoan.Columns[3].ColumnName = "Quyền";
                   // dtTaiKhoan.Columns[4].ColumnName = "Mật Khẩu";
                    dtTaiKhoan.Columns.Remove(dtTaiKhoan.Columns[4]);


                    grvDanhSachTK.AutoResizeColumns();
                    grvDanhSachTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }


        private void grvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDanhSachTK.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells["Tên tài khoản"].Value.ToString() == "")
                    return;

                tbxTenTK.Text = row.Cells["Tên tài khoản"].Value.ToString();
                tbxTenHienThi.Text = row.Cells["Tên hiển thị"].Value.ToString();
                Quyen =Int32.Parse( row.Cells["Quyền"].Value.ToString());
                LoadQuyen(Quyen);
                ChucVu= row.Cells["Chức vụ"].Value.ToString();
                //MatKhau= row.Cells["Mật khẩu"].Value.ToString();
            }
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
            while(i>0)
            {
                indexCheck = i % 10;
                switch(indexCheck)
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
                    default:break;
                }
                i /= 10;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quyen = 0;
            if(tbxTenTK.Text=="admin")
            {
                MessageBox.Show("Không thể phân quyền cho admin!");
                ReloadGridViewTaiKhoan();
                return;
            }
            if(tbxTenTK.Text=="")
            {
            MessageBox.Show("Vui lòng chọn tài khoản phân quyền!!!");
            return;
            }

            if (checkBox1.Checked)
            {
                MessageBox.Show("Hệ thống chỉ cần 1 admin!");
                return;
            }


            if (checkBox2.Checked)
                Quyen = Quyen * 10 + 2;
            if (checkBox3.Checked)
                Quyen = Quyen * 10 + 3;
            if (checkBox4.Checked)
                Quyen = Quyen * 10 + 4;
            if (checkBox5.Checked)
                Quyen = Quyen * 10 + 5;
            if (checkBox6.Checked)
                Quyen = Quyen * 10 + 6;

            DTO_TaiKhoan pTaiKhoan = new DTO_TaiKhoan(tbxTenTK.Text, tbxTenHienThi.Text, ChucVu, Quyen, bus_TaiKhoan.GetMatKhauFromTenTaiKhoan(tbxTenTK.Text));
            if (bus_TaiKhoan.Update(pTaiKhoan))
                MessageBox.Show("Phân quyền cho " + tbxTenTK.Text + " thành công!");
            else
                MessageBox.Show("Phân quyền cho " + tbxTenTK.Text + " thất bại!");
            ReloadGridViewTaiKhoan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
