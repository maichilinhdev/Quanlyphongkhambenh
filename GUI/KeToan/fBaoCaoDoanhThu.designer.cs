namespace GUI
{
    partial class fBaoCaoDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBaoCaoDoanhThu));
            this.label2 = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grvBaoCao = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTongDoanhThu = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng:";
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(113, 92);
            this.dtpThang.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.ShowUpDown = true;
            this.dtpThang.Size = new System.Drawing.Size(182, 30);
            this.dtpThang.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grvBaoCao);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 152);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.groupBox1.Size = new System.Drawing.Size(828, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // grvBaoCao
            // 
            this.grvBaoCao.BackgroundColor = System.Drawing.Color.White;
            this.grvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grvBaoCao.Location = new System.Drawing.Point(7, 25);
            this.grvBaoCao.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grvBaoCao.Name = "grvBaoCao";
            this.grvBaoCao.ReadOnly = true;
            this.grvBaoCao.RowHeadersWidth = 51;
            this.grvBaoCao.RowTemplate.Height = 24;
            this.grvBaoCao.Size = new System.Drawing.Size(811, 212);
            this.grvBaoCao.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 432);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // tbxTongDoanhThu
            // 
            this.tbxTongDoanhThu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTongDoanhThu.Location = new System.Drawing.Point(648, 430);
            this.tbxTongDoanhThu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.tbxTongDoanhThu.Name = "tbxTongDoanhThu";
            this.tbxTongDoanhThu.ReadOnly = true;
            this.tbxTongDoanhThu.Size = new System.Drawing.Size(180, 30);
            this.tbxTongDoanhThu.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.White;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(16, 420);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(158, 40);
            this.btnXuatExcel.TabIndex = 7;
            this.btnXuatExcel.Text = "Xuất file Excel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(676, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.White;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(207, 420);
            this.btnIn.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(99, 40);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(331, 85);
            this.btnXem.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(122, 47);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // fBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(848, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTongDoanhThu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.dtpThang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "fBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.fBaoCaoDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grvBaoCao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}