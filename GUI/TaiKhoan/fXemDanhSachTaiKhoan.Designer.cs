namespace GUI
{ 
    partial class fXemDanhSachTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fXemDanhSachTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.grvDanhSachTK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachTK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // grvDanhSachTK
            // 
            this.grvDanhSachTK.AllowUserToOrderColumns = true;
            this.grvDanhSachTK.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grvDanhSachTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDanhSachTK.Location = new System.Drawing.Point(12, 86);
            this.grvDanhSachTK.Name = "grvDanhSachTK";
            this.grvDanhSachTK.ReadOnly = true;
            this.grvDanhSachTK.RowHeadersWidth = 51;
            this.grvDanhSachTK.RowTemplate.Height = 24;
            this.grvDanhSachTK.Size = new System.Drawing.Size(587, 248);
            this.grvDanhSachTK.TabIndex = 2;
            this.grvDanhSachTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fXemDanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(611, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvDanhSachTK);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fXemDanhSachTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem danh sách tài khoản";
            this.Load += new System.EventHandler(this.fXemDanhSachTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDanhSachTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvDanhSachTK;
    }
}