namespace GUI
{
    partial class fXemDanhSachPhieuKham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fXemDanhSachPhieuKham));
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.grvDSBenhNhan = new System.Windows.Forms.DataGridView();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaPhieuKham = new System.Windows.Forms.TextBox();
            this.tbxMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTenBenhNhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSDT = new System.Windows.Forms.TextBox();
            this.cbxNgay = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.White;
            this.btnTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuu.Image")));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(840, 235);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(138, 40);
            this.btnTraCuu.TabIndex = 7;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // grvDSBenhNhan
            // 
            this.grvDSBenhNhan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDSBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDSBenhNhan.Location = new System.Drawing.Point(30, 281);
            this.grvDSBenhNhan.Name = "grvDSBenhNhan";
            this.grvDSBenhNhan.ReadOnly = true;
            this.grvDSBenhNhan.RowHeadersWidth = 51;
            this.grvDSBenhNhan.RowTemplate.Height = 24;
            this.grvDSBenhNhan.Size = new System.Drawing.Size(948, 210);
            this.grvDSBenhNhan.TabIndex = 8;
            this.grvDSBenhNhan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvDSBenhNhan_CellMouseDoubleClick);
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(651, 81);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(176, 30);
            this.dtpNgay.TabIndex = 4;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ngày: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "DANH SÁCH KHÁM BỆNH";
            // 
            // tbxMaPhieuKham
            // 
            this.tbxMaPhieuKham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaPhieuKham.Location = new System.Drawing.Point(178, 88);
            this.tbxMaPhieuKham.Name = "tbxMaPhieuKham";
            this.tbxMaPhieuKham.Size = new System.Drawing.Size(218, 30);
            this.tbxMaPhieuKham.TabIndex = 1;
            // 
            // tbxMaBenhNhan
            // 
            this.tbxMaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaBenhNhan.Location = new System.Drawing.Point(178, 143);
            this.tbxMaBenhNhan.Name = "tbxMaBenhNhan";
            this.tbxMaBenhNhan.Size = new System.Drawing.Size(218, 30);
            this.tbxMaBenhNhan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã phiếu khám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã bệnh nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tên bệnh nhân:";
            // 
            // tbxTenBenhNhan
            // 
            this.tbxTenBenhNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenBenhNhan.Location = new System.Drawing.Point(651, 139);
            this.tbxTenBenhNhan.Name = "tbxTenBenhNhan";
            this.tbxTenBenhNhan.Size = new System.Drawing.Size(218, 30);
            this.tbxTenBenhNhan.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "CMND:";
            // 
            // tbxCMND
            // 
            this.tbxCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCMND.Location = new System.Drawing.Point(178, 189);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(218, 30);
            this.tbxCMND.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(496, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 26;
            this.label7.Text = "SĐT:";
            // 
            // tbxSDT
            // 
            this.tbxSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSDT.Location = new System.Drawing.Point(651, 189);
            this.tbxSDT.Name = "tbxSDT";
            this.tbxSDT.Size = new System.Drawing.Size(218, 30);
            this.tbxSDT.TabIndex = 6;
            this.tbxSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSDT_KeyPress);
            // 
            // cbxNgay
            // 
            this.cbxNgay.AutoSize = true;
            this.cbxNgay.Checked = true;
            this.cbxNgay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNgay.Location = new System.Drawing.Point(831, 88);
            this.cbxNgay.Name = "cbxNgay";
            this.cbxNgay.Size = new System.Drawing.Size(18, 17);
            this.cbxNgay.TabIndex = 27;
            this.cbxNgay.UseVisualStyleBackColor = true;
            this.cbxNgay.CheckedChanged += new System.EventHandler(this.cbxNgay_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(27, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Click đúp để xem chi tiết";
            // 
            // fXemDanhSachPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(991, 506);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxNgay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxSDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxCMND);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxTenBenhNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxMaBenhNhan);
            this.Controls.Add(this.tbxMaPhieuKham);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.grvDSBenhNhan);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fXemDanhSachPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách phiếu khám";
            this.Activated += new System.EventHandler(this.fXemDanhSachPhieuKham_Activated);
            this.Enter += new System.EventHandler(this.fXemDanhSachPhieuKham_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.DataGridView grvDSBenhNhan;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaPhieuKham;
        private System.Windows.Forms.TextBox tbxMaBenhNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTenBenhNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCMND;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSDT;
        private System.Windows.Forms.CheckBox cbxNgay;
        private System.Windows.Forms.Label label8;
    }
}