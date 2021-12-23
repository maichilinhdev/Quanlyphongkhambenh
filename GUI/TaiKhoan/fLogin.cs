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
    public partial class fLogin : Form
    {
        BUS_TaiKhoan bus_TaiKhoan = new BUS_TaiKhoan();
        public fLogin()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ?", "Thoát", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                return;
            }
            if (tbxTaiKhoan.Text.Length < 3)
            {
                MessageBox.Show("Tài khoản không hợp lệ");
                return;
            }
            if (tbxMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu");
                return;
            }

            if (bus_TaiKhoan.GetTenFromTenTaiKhoan(tbxTaiKhoan.Text) == "")
            {
                MessageBox.Show("Tài khoản không tồn tại!");
                return;
            }
            else
            {
                string a = Hash256.Hash256Data(tbxTaiKhoan.Text + tbxMatKhau.Text);
                if (bus_TaiKhoan.GetMatKhauFromTenTaiKhoan(tbxTaiKhoan.Text) != Hash256.Hash256Data(tbxTaiKhoan.Text+tbxMatKhau.Text))
                {
                    MessageBox.Show("Sai mật khẩu vui lòng nhập lại!");
                    tbxMatKhau.Clear();
                    return;
                }
            }
            MessageBox.Show("Đăng nhập thành công!", "Thông báo");
            fMainForm fMainForm = new fMainForm(tbxTaiKhoan.Text);
            //fMainForm.SetTaiKhoan(tbxTaiKhoan.Text);
            this.Hide();
            fMainForm.ShowDialog();
            this.Close();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
                tbxMatKhau.PasswordChar = '*';
            else
                tbxMatKhau.PasswordChar = new char();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkKhongcotaikhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ quản trị viên để cấp tài khoản!");
        }

        private void tbxMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void tbxTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
       
    }
}
