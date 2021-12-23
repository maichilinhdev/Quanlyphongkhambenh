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
    public partial class fXemDanhSachTaiKhoan : Form
    {
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        DataTable dtTaiKhoan;

        public fXemDanhSachTaiKhoan()
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
                grvDanhSachTK.AutoGenerateColumns = true;
                grvDanhSachTK.DataSource = dtTaiKhoan;


                dtTaiKhoan.Columns[0].ColumnName = "Tên tài khoản";
                dtTaiKhoan.Columns[1].ColumnName = "Tên hiển thị";
                dtTaiKhoan.Columns[2].ColumnName = "Chức vụ";
                dtTaiKhoan.Columns[3].ColumnName = "Quyền";
                //dtTaiKhoan.Columns[4].ColumnName = "Mật Khẩu";

                dtTaiKhoan.Columns.Remove(dtTaiKhoan.Columns[4]);

                grvDanhSachTK.AutoResizeColumns();
                grvDanhSachTK.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fXemDanhSachTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
