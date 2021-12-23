namespace GUI
{
    partial class fLapPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLapPhieuKham));
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxMaPhieuKham = new System.Windows.Forms.TextBox();
            this.tbxTenBenhNhan = new System.Windows.Forms.TextBox();
            this.tbxTrieuChung = new System.Windows.Forms.TextBox();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgrvDSThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxTenThuoc = new System.Windows.Forms.ComboBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.lbStatusTimBenhNhan = new System.Windows.Forms.Label();
            this.cbxLoaiBenh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSThuoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(199, 64);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(176, 30);
            this.dtpNgayKham.TabIndex = 0;
            this.dtpNgayKham.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Bệnh Nhân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã BN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Triệu chứng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Loại bệnh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(458, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã phiếu khám:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ngày lập phiếu:";
            // 
            // tbxMaPhieuKham
            // 
            this.tbxMaPhieuKham.Enabled = false;
            this.tbxMaPhieuKham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaPhieuKham.Location = new System.Drawing.Point(614, 64);
            this.tbxMaPhieuKham.Name = "tbxMaPhieuKham";
            this.tbxMaPhieuKham.ReadOnly = true;
            this.tbxMaPhieuKham.Size = new System.Drawing.Size(238, 30);
            this.tbxMaPhieuKham.TabIndex = 1;
            this.tbxMaPhieuKham.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxTenBenhNhan
            // 
            this.tbxTenBenhNhan.Enabled = false;
            this.tbxTenBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenBenhNhan.Location = new System.Drawing.Point(614, 119);
            this.tbxTenBenhNhan.Name = "tbxTenBenhNhan";
            this.tbxTenBenhNhan.ReadOnly = true;
            this.tbxTenBenhNhan.Size = new System.Drawing.Size(238, 30);
            this.tbxTenBenhNhan.TabIndex = 3;
            // 
            // tbxTrieuChung
            // 
            this.tbxTrieuChung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTrieuChung.Location = new System.Drawing.Point(199, 169);
            this.tbxTrieuChung.Multiline = true;
            this.tbxTrieuChung.Name = "tbxTrieuChung";
            this.tbxTrieuChung.Size = new System.Drawing.Size(238, 59);
            this.tbxTrieuChung.TabIndex = 4;
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(199, 123);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(176, 30);
            this.tbxMaBenhNhan.TabIndex = 2;
            this.tbxMaBenhNhan.TextChanged += new System.EventHandler(this.tbxMaBenhNhan_Leave);
            this.tbxMaBenhNhan.Leave += new System.EventHandler(this.tbxMaBenhNhan_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnXoaThuoc);
            this.groupBox1.Controls.Add(this.btnThemThuoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 274);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kê thuốc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgrvDSThuoc);
            this.groupBox3.Location = new System.Drawing.Point(454, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 241);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toa thuốc";
            // 
            // dgrvDSThuoc
            // 
            this.dgrvDSThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrvDSThuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgrvDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvDSThuoc.Location = new System.Drawing.Point(22, 25);
            this.dgrvDSThuoc.Name = "dgrvDSThuoc";
            this.dgrvDSThuoc.ReadOnly = true;
            this.dgrvDSThuoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgrvDSThuoc.RowTemplate.Height = 24;
            this.dgrvDSThuoc.Size = new System.Drawing.Size(578, 206);
            this.dgrvDSThuoc.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxTenThuoc);
            this.groupBox2.Controls.Add(this.tbxSoLuong);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm thuốc vào toa";
            // 
            // cbxTenThuoc
            // 
            this.cbxTenThuoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxTenThuoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTenThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTenThuoc.FormattingEnabled = true;
            this.cbxTenThuoc.Location = new System.Drawing.Point(112, 71);
            this.cbxTenThuoc.Name = "cbxTenThuoc";
            this.cbxTenThuoc.Size = new System.Drawing.Size(149, 30);
            this.cbxTenThuoc.TabIndex = 7;
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoLuong.Location = new System.Drawing.Point(112, 111);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(55, 30);
            this.tbxSoLuong.TabIndex = 8;
            this.tbxSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSoLuong_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng:";
            this.label9.Click += new System.EventHandler(this.label8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tên thuốc:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.BackColor = System.Drawing.Color.White;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaThuoc.Image")));
            this.btnXoaThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaThuoc.Location = new System.Drawing.Point(300, 157);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(129, 41);
            this.btnXoaThuoc.TabIndex = 10;
            this.btnXoaThuoc.Text = "    Xóa thuốc";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.Color.White;
            this.btnThemThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemThuoc.Image")));
            this.btnThemThuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemThuoc.Location = new System.Drawing.Point(300, 99);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(129, 40);
            this.btnThemThuoc.TabIndex = 9;
            this.btnThemThuoc.Text = "Thêm >>";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // lbStatusTimBenhNhan
            // 
            this.lbStatusTimBenhNhan.AutoSize = true;
            this.lbStatusTimBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusTimBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusTimBenhNhan.ForeColor = System.Drawing.Color.Red;
            this.lbStatusTimBenhNhan.Location = new System.Drawing.Point(196, 146);
            this.lbStatusTimBenhNhan.Name = "lbStatusTimBenhNhan";
            this.lbStatusTimBenhNhan.Size = new System.Drawing.Size(15, 22);
            this.lbStatusTimBenhNhan.TabIndex = 8;
            this.lbStatusTimBenhNhan.Text = " ";
            // 
            // cbxLoaiBenh
            // 
            this.cbxLoaiBenh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLoaiBenh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLoaiBenh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiBenh.FormattingEnabled = true;
            this.cbxLoaiBenh.Location = new System.Drawing.Point(614, 174);
            this.cbxLoaiBenh.Name = "cbxLoaiBenh";
            this.cbxLoaiBenh.Size = new System.Drawing.Size(149, 30);
            this.cbxLoaiBenh.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "LẬP PHIẾU KHÁM BỆNH";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.resume_icon;
            this.pictureBox1.Location = new System.Drawing.Point(881, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 196);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(930, 538);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(163, 41);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "     Lưu phiếu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(831, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // fLapPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1103, 590);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxLoaiBenh);
            this.Controls.Add(this.lbStatusTimBenhNhan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxTrieuChung);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.tbxTenBenhNhan);
            this.Controls.Add(this.tbxMaPhieuKham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayKham);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fLapPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lập phiếu khám bệnh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvDSThuoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxMaPhieuKham;
        private System.Windows.Forms.TextBox tbxTenBenhNhan;
        private System.Windows.Forms.TextBox tbxTrieuChung;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrvDSThuoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lbStatusTimBenhNhan;
        private System.Windows.Forms.ComboBox cbxLoaiBenh;
        private System.Windows.Forms.ComboBox cbxTenThuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}