namespace GUI
{
    partial class fHdsd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(150, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hướng Dẫn Sử Dụng Phần Mềm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bước 1: Thêm Bệnh Nhân bấm vào mục Quản Lý Bệnh Nhân";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(141, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(492, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bệnh Nhân sẽ được thêm vào Danh Sách Khám";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(141, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(623, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phiếu Khám sẽ được thêm vào Xem Danh Sách Phiếu Khám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(594, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bước 2: Lập Phiếu Khám bấm vào mục Lập Phiếu Khám";
            // 
            // fHdsd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(839, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fHdsd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng Dẫn Sử Dụng Phần Mềm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}