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
    public partial class fQuanLyBenh : Form
    {
        BUS_LoaiBenh bus_loaiBenh = new BUS_LoaiBenh();
        DataTable dtLoaiBenh;

        public fQuanLyBenh()
        {
            InitializeComponent();
            ReloadDSLoaiBenh();
        }
        void ReloadDSLoaiBenh()
        {
            dtLoaiBenh = bus_loaiBenh.GetThongTinTatCaLoaiBenh();
            dtLoaiBenh.Columns[0].ColumnName = "Mã loại bệnh";
            dtLoaiBenh.Columns[1].ColumnName = "Tên loại bệnh";

            grvDSBenh.DataSource = dtLoaiBenh;

        }

        bool isThem = false;
        bool isSua = false;
        private void grvDSBenh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isThem || isSua)
                return;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = grvDSBenh.Rows[e.RowIndex];

                //Nếu dòng được chọn không tồn tại
                if (row.Cells["Mã loại bệnh"].Value.ToString() == "")
                    return;

                tbxMaLoaiBenh.Text = row.Cells["Mã loại bệnh"].Value.ToString();
                tbxTenLoaiBenh.Text = row.Cells["Tên loại bệnh"].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!isThem)//them
            {
                tbxMaLoaiBenh.Text = bus_loaiBenh.GetMaLoaiBenhNext();
                tbxTenLoaiBenh.ReadOnly = false;
                btnThem.Text = "Hoàn tất";
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                
            }
            else//Luu
            {
                if(tbxTenLoaiBenh.Text.Length>30)
                {
                    MessageBox.Show("Tên loại bệnh không được quá 30 ký tự!");
                    return;
                }
                if (tbxTenLoaiBenh.Text.Length ==0)
                {
                    MessageBox.Show("Tên loại bệnh không được để trống!");
                    return;
                }
                try
                {
                    DTO_LoaiBenh loaiBenh = new DTO_LoaiBenh(tbxMaLoaiBenh.Text, tbxTenLoaiBenh.Text);
                    if (!bus_loaiBenh.Add(loaiBenh))
                    {
                        MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công!");
                        ReloadDSLoaiBenh();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                
                btnThem.Text = "Thêm";
                tbxTenLoaiBenh.ReadOnly = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                
            }
            isThem = !isThem;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbxMaLoaiBenh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại bệnh cần sửa!");
                return;
            }
            if (!isSua)//Sua
            {
                tbxTenLoaiBenh.ReadOnly = false;
                btnSua.Text = "Hoàn tất";
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                if (tbxTenLoaiBenh.Text.Length > 30)
                {
                    MessageBox.Show("Tên loại bệnh không được quá 30 ký tự!");
                    return;
                }
                if (tbxTenLoaiBenh.Text.Length == 0)
                {
                    MessageBox.Show("Tên loại bệnh không được để trống!");
                    return;
                }
                try
                {
                    DTO_LoaiBenh loaiBenh = new DTO_LoaiBenh(tbxMaLoaiBenh.Text, tbxTenLoaiBenh.Text);
                    if (!bus_loaiBenh.Update(loaiBenh))
                    {
                        MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa thành công!");
                        ReloadDSLoaiBenh();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại! Vui lòng kiểm tra lại!");
                    return;
                }
                tbxTenLoaiBenh.ReadOnly = true;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
            }
            
            isSua = !isSua;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tbxMaLoaiBenh.Text == "")
            {
                MessageBox.Show("Không tìm thấy mã loại bệnh!");
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa loại bệnh này?", "Xóa", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                bool kq = bus_loaiBenh.Delete(tbxMaLoaiBenh.Text);
                if (kq)
                {
                    ReloadDSLoaiBenh();
                    tbxMaLoaiBenh.Text = "";
                    tbxTenLoaiBenh.Text = "";
                    MessageBox.Show("Xóa loại bệnh thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa loại bệnh thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (isSua)
            {
                isSua = false;

                tbxTenLoaiBenh.ReadOnly = true;
                btnSua.Text = "Sửa";
                btnThem.Enabled = true;
                btnXoa.Enabled = true;

                tbxMaLoaiBenh.Text = "";
                tbxTenLoaiBenh.Text = "";
                ReloadDSLoaiBenh();
            }
            else if (isThem)
            {
                isThem = false;

                tbxTenLoaiBenh.ReadOnly = true;
                btnThem.Text = "Thêm";
                btnSua.Enabled = true;
                btnXoa.Enabled = true;


                tbxMaLoaiBenh.Text = "";
                tbxTenLoaiBenh.Text = "";
                ReloadDSLoaiBenh();
            }

        }

        private void fQuanLyBenh_Load(object sender, EventArgs e)
        {

        }
    }
}
