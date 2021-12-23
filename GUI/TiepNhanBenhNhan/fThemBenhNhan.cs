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
    public partial class fThemBenhNhan : Form
    {
        BUS_BenhNhan bus_benhNhan = new BUS_BenhNhan();

        DataTable dtBenhNhan;

        public fThemBenhNhan()
        {
            InitializeComponent();

            //Setup
            DisableControl();

            //Load du lieu benh nhan
            ReloadGridViewBenhNhan();

        }


        #region Support Function
        //Load danh sách bệnh nhân vào gridview
        void ReloadGridViewBenhNhan()
        {
            dtBenhNhan = bus_benhNhan.GetThongTinTatCaBenhNhan();
            if (dtBenhNhan != null)
            {
                grvDanhSachBN.Visible = true;
                //grvDanhSachBN.AutoGenerateColumns = true;
                grvDanhSachBN.DataSource = dtBenhNhan;

                dtBenhNhan.Columns[0].ColumnName = "Mã bệnh nhân";
                dtBenhNhan.Columns[1].ColumnName = "Họ tên";
                dtBenhNhan.Columns[2].ColumnName = "Giới tính";
                dtBenhNhan.Columns[3].ColumnName = "Năm sinh";
                dtBenhNhan.Columns[4].ColumnName = "Địa chỉ";
                dtBenhNhan.Columns[5].ColumnName = "SĐT";
                dtBenhNhan.Columns[6].ColumnName = "CMND";

                grvDanhSachBN.AutoResizeColumns();
                grvDanhSachBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        void EnableControl()
        {
            tbxHoTen.ReadOnly = false;
            tbxSDT.ReadOnly = false;
            tbxDiaChi.ReadOnly = false;
            tbxCMND.ReadOnly = false;

            rbtnNam.Enabled = true;
            rbtnNu.Enabled = true;
            dtpNamSinh.Enabled = true;
        }

        void DisableControl()
        {
            tbxHoTen.ReadOnly = true;
            tbxSDT.ReadOnly = true;
            tbxDiaChi.ReadOnly = true;
            tbxCMND.ReadOnly = true;

            rbtnNam.Enabled = false;
            rbtnNu.Enabled = false;
            dtpNamSinh.Enabled = false;
        }

        #endregion


        //--------------------------------------------------------------------------------------------------------

        private void grvDanhSachBN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDanhSachBN.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells["Mã bệnh nhân"].Value.ToString() == "")
                    return;

                tbxMaBenhNhan.Text = row.Cells["Mã bệnh nhân"].Value.ToString();
                tbxHoTen.Text = row.Cells["Họ tên"].Value.ToString();
                if (row.Cells["Giới tính"].Value.ToString() == "Nam")
                {
                    rbtnNam.Checked = true;
                    rbtnNu.Checked = false;
                }
                else
                {
                    rbtnNam.Checked = false;
                    rbtnNu.Checked = true;
                }
                dtpNamSinh.Value = new DateTime(Int32.Parse(row.Cells["Năm sinh"].Value.ToString()), 1, 1);
                tbxSDT.Text = row.Cells["SĐT"].Value.ToString();
                tbxDiaChi.Text = row.Cells["Địa chỉ"].Value.ToString();
                tbxCMND.Text = row.Cells["CMND"].Value.ToString();
            }
        }




        //**********************************SỬA THÔNG TIN BỆNH NHÂN********************************************
        private bool isSua = false;
        private void btnSuaBenhNhan_Click(object sender, EventArgs e)
        {
            if(tbxMaBenhNhan.Text=="")
            {
                MessageBox.Show("Không tìm thấy mã bệnh nhân!");
                return;
            }
            
            if(isSua)// neu sua xong thi luu va disable
            {

                if (tbxHoTen.Text.Length < 3)
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    return;
                }
                
                if(!CheckThongTinPhuHop())
                {
                    return;
                }

                DisableControl();
                btnSuaBenhNhan.Text = "Sửa";
                btnThemBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                btnTimKiem.Enabled = true;
                string gioiTinh="Nam";
                if(rbtnNu.Checked)
                {
                    gioiTinh = "Nữ";
                }
                DTO_BenhNhan benhNhan = new DTO_BenhNhan(tbxMaBenhNhan.Text.ToString(), tbxHoTen.Text.ToString(), gioiTinh,
                                          dtpNamSinh.Value.Year, tbxDiaChi.Text.ToString(), tbxSDT.Text.ToString(), tbxCMND.Text.ToString());
                if (bus_benhNhan.Update(benhNhan))
                {
                    ReloadGridViewBenhNhan();
                    MessageBox.Show("Sửa bệnh nhân thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa bệnh nhân thất bại!");
                }
            }
            else //Neu chua sua thi enable
            {
                EnableControl();
                btnThemBenhNhan.Enabled = false;
                btnXoaBenhNhan.Enabled = false;
                btnTimKiem.Enabled = false;
                btnSuaBenhNhan.Text = "Hoàn tất";
            }

            isSua = !isSua;

        }





        //**********************************XÓA BỆNH NHÂN**********************************
        private void btnXoaBenhNhan_Click(object sender, EventArgs e)
        {
            if (tbxMaBenhNhan.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã bệnh nhân!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bệnh nhân này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = bus_benhNhan.Delete(tbxMaBenhNhan.Text);
                if (kq)
                {
                    ReloadGridViewBenhNhan();
                    MessageBox.Show("Xóa bệnh nhân thành công!");
                    tbxMaBenhNhan.Text = "";
                    tbxHoTen.Text = "";
                    tbxDiaChi.Text = "";
                    tbxCMND.Text = "";
                    tbxSDT.Text = "";
                }
                else
                {
                    MessageBox.Show("Xóa bệnh nhân thất bại!");
                }
            }
        }





        //**********************************THÊM BỆNH NHÂN**********************************
        bool isThem = false;
        private void btnThemBenhNhan_Click(object sender, EventArgs e)
        {
            if(!isThem)//neu chua them thi gio them
            {
                tbxHoTen.Text = "";
                tbxDiaChi.Text = "";
                tbxCMND.Text = "";
                tbxSDT.Text = "";
                EnableControl();

                tbxMaBenhNhan.Text = bus_benhNhan.GetMaBenhNhanNext();
                if (tbxMaBenhNhan.Text == "")
                {
                    MessageBox.Show("Không lấy được mã bệnh nhân!");
                    return;
                }
                

                btnThemBenhNhan.Text = "Hoàn tất";
                btnSuaBenhNhan.Enabled = false;
                btnXoaBenhNhan.Enabled = false;
                btnTimKiem.Enabled = false;

            }
            else //Neu nhap xong thi them vo
            {
                if (tbxMaBenhNhan.Text == "")
                {
                    MessageBox.Show("Mã bệnh nhân không hợp lệ!");
                    return;
                }
                else if (tbxHoTen.Text.Length < 3)
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    return;
                }
                else if (tbxCMND.Text.Length < 5)
                {
                    MessageBox.Show("CMND không hợp lệ!");
                    return;
                }
                if(!CheckThongTinPhuHop())
                {
                    return;
                }
                //THÊM
                string gioiTinh = "Nam";
                if (rbtnNu.Checked)
                {
                    gioiTinh = "Nữ";
                }

                DTO_BenhNhan benhNhan = new DTO_BenhNhan(tbxMaBenhNhan.Text.ToString(), tbxHoTen.Text.ToString(), gioiTinh,
                                         dtpNamSinh.Value.Year, tbxDiaChi.Text.ToString(), tbxSDT.Text.ToString(), tbxCMND.Text.ToString());

                if (bus_benhNhan.ThemBenhNhan(benhNhan))
                {
                    ReloadGridViewBenhNhan();
                    MessageBox.Show("Thêm bệnh nhân thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm bệnh nhân thất bại!");
                }

                //Done
                DisableControl();
                btnThemBenhNhan.Text = "Thêm +";
                btnSuaBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                btnTimKiem.Enabled = true; 
            }

            isThem = !isThem;

        }





        //**********************************HỦY THAO TÁC**********************************
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                isSua = false;
                DisableControl();
                btnSuaBenhNhan.Text = "Sửa";
                btnThemBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                btnTimKiem.Enabled = true;

                tbxMaBenhNhan.Text = "";
                tbxHoTen.Text = "";
                tbxDiaChi.Text = "";
                tbxCMND.Text = "";
                tbxSDT.Text = "";
            }
            if(isThem)
            {
                isThem = false;
                DisableControl();
                btnThemBenhNhan.Text = "Thêm +";
                btnSuaBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                btnTimKiem.Enabled = true;

                tbxHoTen.Text = "";
                tbxDiaChi.Text = "";
                tbxCMND.Text = "";
                tbxSDT.Text = "";
            }
            if(isTimKiem)
            {
                isTimKiem = false;
                btnThemBenhNhan.Enabled = true;
                btnSuaBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                DisableControl();
                btnTimKiem.Text = "Tìm kiếm";
                tbxMaBenhNhan.ReadOnly = true;
                cbxNamSinh.Enabled = false;
                cbxNamSinh.Checked = false;
               
            }
            ReloadGridViewBenhNhan();
        }

        private void tbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
        }

        bool isTimKiem = false;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!isTimKiem)//Mo che do tim kiem
            {

                tbxMaBenhNhan.ReadOnly = false;

                btnThemBenhNhan.Enabled = false;
                btnSuaBenhNhan.Enabled = false;
                btnXoaBenhNhan.Enabled = false;
                EnableControl();
                btnTimKiem.Text = "Tìm ngay";

                cbxNamSinh.Enabled = true;
                dtpNamSinh.Enabled = false;

                tbxMaBenhNhan.Text = "";
                tbxHoTen.Text = "";
                tbxDiaChi.Text = "";
                tbxSDT.Text = "";
                tbxCMND.Text = "";
                rbtnNam.Checked = false;
                rbtnNu.Checked = false;
            }
            else //Ket thuc tim kiem
            {
                string gioiTinh = "";
                if (rbtnNu.Checked)
                    gioiTinh = "Nữ";
                if (rbtnNam.Checked)
                    gioiTinh = "Nam";
                string namSinh = "";
                if(cbxNamSinh.Checked)
                {
                    namSinh = dtpNamSinh.Text;
                }
                dtBenhNhan = bus_benhNhan.TimBenhNhan(tbxMaBenhNhan.Text, tbxHoTen.Text, tbxCMND.Text, gioiTinh
                              , namSinh,tbxSDT.Text,tbxDiaChi.Text);
                if (dtBenhNhan != null)
                {
                    grvDanhSachBN.Visible = true;
                    //grvDSThuoc.AutoGenerateColumns = true;
                    grvDanhSachBN.DataSource = dtBenhNhan;

                    dtBenhNhan.Columns[0].ColumnName = "Mã bệnh nhân";
                    dtBenhNhan.Columns[1].ColumnName = "Họ tên";
                    dtBenhNhan.Columns[2].ColumnName = "Giới tính";
                    dtBenhNhan.Columns[3].ColumnName = "Năm sinh";
                    dtBenhNhan.Columns[4].ColumnName = "Địa chỉ";
                    dtBenhNhan.Columns[5].ColumnName = "SĐT";
                    dtBenhNhan.Columns[6].ColumnName = "CMND";

                    grvDanhSachBN.AutoResizeColumns();
                    grvDanhSachBN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

                btnThemBenhNhan.Enabled = true;
                btnSuaBenhNhan.Enabled = true;
                btnXoaBenhNhan.Enabled = true;
                DisableControl();
                btnTimKiem.Text = "Tìm kiếm";
                tbxMaBenhNhan.ReadOnly = true;
                cbxNamSinh.Enabled = false;
                cbxNamSinh.Checked = false;
                dtpNamSinh.Enabled = true;
            }
            isTimKiem = !isTimKiem;
        }

        private void cbxNamSinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNamSinh.Checked)
            {
                dtpNamSinh.Enabled = true;
            }
            else
                dtpNamSinh.Enabled = false;
        }

        private void tbxCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            //&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private bool CheckThongTinPhuHop()
        {
            if(tbxHoTen.Text.Length>30)
            {
                MessageBox.Show("Tên quá dài! (Tối đa 30 ký tự)");
                return false;
            }
            if(tbxCMND.Text.Length>13)
            {
                MessageBox.Show("Số CMND quá dài! (Tối đa 13 ký tự)");
                return false;
            }
            if(tbxSDT.Text.Length>11)
            {
                MessageBox.Show("SĐT quá dài! (Tối đa 11 ký tự)");
                return false;
            }
            if(tbxDiaChi.Text.Length>50)
            {
                MessageBox.Show("Địa chỉ quá dài! (Tối đa 50 ký tự)");
                return false;
            }
                

            return true;
        }
    }
}
