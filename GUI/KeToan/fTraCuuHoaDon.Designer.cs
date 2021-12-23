namespace GUI
{
    partial class fTraCuuHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraCuuHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvCTTienThuoc = new System.Windows.Forms.DataGridView();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.tbxTienThuoc = new System.Windows.Forms.TextBox();
            this.tbxTienKham = new System.Windows.Forms.TextBox();
            this.tbxMaBN = new System.Windows.Forms.TextBox();
            this.tbxMaPK = new System.Windows.Forms.TextBox();
            this.tbxHoTen = new System.Windows.Forms.TextBox();
            this.tbxMaHoaDon = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.tbxNgayKham = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTTienThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvCTTienThuoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 220);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn thuốc";
            // 
            // grvCTTienThuoc
            // 
            this.grvCTTienThuoc.BackgroundColor = System.Drawing.Color.White;
            this.grvCTTienThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCTTienThuoc.Location = new System.Drawing.Point(6, 29);
            this.grvCTTienThuoc.Name = "grvCTTienThuoc";
            this.grvCTTienThuoc.ReadOnly = true;
            this.grvCTTienThuoc.RowHeadersWidth = 51;
            this.grvCTTienThuoc.RowTemplate.Height = 24;
            this.grvCTTienThuoc.Size = new System.Drawing.Size(813, 184);
            this.grvCTTienThuoc.TabIndex = 10;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.Color.White;
            this.btnTraCuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraCuu.Location = new System.Drawing.Point(327, 57);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(79, 32);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "HÓA ĐƠN";
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTongTien.Location = new System.Drawing.Point(173, 199);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.ReadOnly = true;
            this.tbxTongTien.Size = new System.Drawing.Size(193, 30);
            this.tbxTongTien.TabIndex = 8;
            // 
            // tbxTienThuoc
            // 
            this.tbxTienThuoc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxTienThuoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTienThuoc.Location = new System.Drawing.Point(616, 155);
            this.tbxTienThuoc.Name = "tbxTienThuoc";
            this.tbxTienThuoc.ReadOnly = true;
            this.tbxTienThuoc.Size = new System.Drawing.Size(186, 30);
            this.tbxTienThuoc.TabIndex = 7;
            // 
            // tbxTienKham
            // 
            this.tbxTienKham.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxTienKham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTienKham.Location = new System.Drawing.Point(173, 155);
            this.tbxTienKham.Name = "tbxTienKham";
            this.tbxTienKham.ReadOnly = true;
            this.tbxTienKham.Size = new System.Drawing.Size(193, 30);
            this.tbxTienKham.TabIndex = 6;
            // 
            // tbxMaBN
            // 
            this.tbxMaBN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxMaBN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaBN.Location = new System.Drawing.Point(616, 105);
            this.tbxMaBN.Name = "tbxMaBN";
            this.tbxMaBN.ReadOnly = true;
            this.tbxMaBN.Size = new System.Drawing.Size(186, 30);
            this.tbxMaBN.TabIndex = 5;
            // 
            // tbxMaPK
            // 
            this.tbxMaPK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxMaPK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxMaPK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaPK.Location = new System.Drawing.Point(173, 59);
            this.tbxMaPK.Name = "tbxMaPK";
            this.tbxMaPK.Size = new System.Drawing.Size(149, 30);
            this.tbxMaPK.TabIndex = 1;
            this.tbxMaPK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMaPK_KeyDown);
            // 
            // tbxHoTen
            // 
            this.tbxHoTen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHoTen.Location = new System.Drawing.Point(173, 108);
            this.tbxHoTen.Name = "tbxHoTen";
            this.tbxHoTen.ReadOnly = true;
            this.tbxHoTen.Size = new System.Drawing.Size(223, 30);
            this.tbxHoTen.TabIndex = 4;
            // 
            // tbxMaHoaDon
            // 
            this.tbxMaHoaDon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxMaHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaHoaDon.Location = new System.Drawing.Point(616, 59);
            this.tbxMaHoaDon.Name = "tbxMaHoaDon";
            this.tbxMaHoaDon.ReadOnly = true;
            this.tbxMaHoaDon.Size = new System.Drawing.Size(186, 30);
            this.tbxMaHoaDon.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(478, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(108, 22);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Ngày  khám:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Tổng tiền:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(478, 153);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(98, 22);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "Tiền thuốc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tiền khám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã BN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã Hóa đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã phiếu khám:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Họ tên:";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(704, 473);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(143, 48);
            this.btnIn.TabIndex = 11;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // tbxNgayKham
            // 
            this.tbxNgayKham.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbxNgayKham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNgayKham.Location = new System.Drawing.Point(616, 199);
            this.tbxNgayKham.Name = "tbxNgayKham";
            this.tbxNgayKham.ReadOnly = true;
            this.tbxNgayKham.Size = new System.Drawing.Size(186, 30);
            this.tbxNgayKham.TabIndex = 9;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fTraCuuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(867, 530);
            this.Controls.Add(this.tbxNgayKham);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTongTien);
            this.Controls.Add(this.tbxTienThuoc);
            this.Controls.Add(this.tbxTienKham);
            this.Controls.Add(this.tbxMaBN);
            this.Controls.Add(this.tbxMaPK);
            this.Controls.Add(this.tbxHoTen);
            this.Controls.Add(this.tbxMaHoaDon);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fTraCuuHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu hóa đơn";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTTienThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvCTTienThuoc;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.TextBox tbxTienThuoc;
        private System.Windows.Forms.TextBox tbxTienKham;
        private System.Windows.Forms.TextBox tbxMaBN;
        private System.Windows.Forms.TextBox tbxMaPK;
        private System.Windows.Forms.TextBox tbxHoTen;
        private System.Windows.Forms.TextBox tbxMaHoaDon;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.TextBox tbxNgayKham;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}