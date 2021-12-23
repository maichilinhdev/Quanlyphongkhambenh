namespace GUI
{
    partial class frmTestBenhNhan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; 

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNamSinh = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbxTestLoadTen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(122, 165);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(203, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(284, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giới tính";
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(119, 21);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(75, 22);
            this.tbxMaBenhNhan.TabIndex = 6;
            this.tbxMaBenhNhan.Text = "BN01";
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.Location = new System.Drawing.Point(119, 48);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.Size = new System.Drawing.Size(240, 22);
            this.tbxHoTen.TabIndex = 7;
            this.tbxHoTen.Text = "ABC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Năm sinh";
            // 
            // tbxNamSinh
            // 
            this.tbxNamSinh.Location = new System.Drawing.Point(273, 85);
            this.tbxNamSinh.Name = "tbxNamSinh";
            this.tbxNamSinh.Size = new System.Drawing.Size(86, 22);
            this.tbxNamSinh.TabIndex = 10;
            this.tbxNamSinh.Text = "1990";
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(119, 124);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(240, 22);
            this.tbxDiaChi.TabIndex = 12;
            this.tbxDiaChi.Text = "ABCD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Địa chỉ";
            // 
            // cbxGioiTinh
            // 
            this.cbxGioiTinh.FormattingEnabled = true;
            this.cbxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxGioiTinh.Location = new System.Drawing.Point(119, 83);
            this.cbxGioiTinh.Name = "cbxGioiTinh";
            this.cbxGioiTinh.Size = new System.Drawing.Size(78, 24);
            this.cbxGioiTinh.TabIndex = 13;
            // 
            // cbxTestLoadTen
            // 
            this.cbxTestLoadTen.FormattingEnabled = true;
            this.cbxTestLoadTen.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbxTestLoadTen.Location = new System.Drawing.Point(145, 227);
            this.cbxTestLoadTen.Name = "cbxTestLoadTen";
            this.cbxTestLoadTen.Size = new System.Drawing.Size(214, 24);
            this.cbxTestLoadTen.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Test load du lieu";
            // 
            // frmTestBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 312);
            this.Controls.Add(this.cbxTestLoadTen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxGioiTinh);
            this.Controls.Add(this.tbxDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNamSinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxHoTen);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmTestBenhNhan";
            this.Text = "frmTestBenhNhan";
            this.Load += new System.EventHandler(this.frmTestBenhNhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNamSinh;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbxGioiTinh;
        public System.Windows.Forms.ComboBox cbxTestLoadTen;
        private System.Windows.Forms.Label label6;
    }
}