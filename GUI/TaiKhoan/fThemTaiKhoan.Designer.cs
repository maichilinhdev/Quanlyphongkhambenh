namespace GUI 
{
    partial class fThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.tbxNhapLaiMK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemTk = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbxTenHienThi = new System.Windows.Forms.TextBox();
            this.tbxMatKhau = new System.Windows.Forms.TextBox();
            this.tbxTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbxChucVu);
            this.groupBox1.Controls.Add(this.tbxNhapLaiMK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbxTenHienThi);
            this.groupBox1.Controls.Add(this.tbxMatKhau);
            this.groupBox1.Controls.Add(this.tbxTenDangNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 367);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Items.AddRange(new object[] {
            "Bác sĩ",
            "Tiếp tân",
            "Thu ngân"});
            this.cbxChucVu.Location = new System.Drawing.Point(193, 291);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(198, 30);
            this.cbxChucVu.TabIndex = 5;
            // 
            // tbxNhapLaiMK
            // 
            this.tbxNhapLaiMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNhapLaiMK.Location = new System.Drawing.Point(193, 168);
            this.tbxNhapLaiMK.Name = "tbxNhapLaiMK";
            this.tbxNhapLaiMK.PasswordChar = '*';
            this.tbxNhapLaiMK.Size = new System.Drawing.Size(198, 30);
            this.tbxNhapLaiMK.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nhập lại mật khẩu:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnThemTk);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(432, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 161);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnThemTk
            // 
            this.btnThemTk.BackColor = System.Drawing.Color.White;
            this.btnThemTk.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTk.Image")));
            this.btnThemTk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTk.Location = new System.Drawing.Point(5, 46);
            this.btnThemTk.Name = "btnThemTk";
            this.btnThemTk.Size = new System.Drawing.Size(185, 44);
            this.btnThemTk.TabIndex = 6;
            this.btnThemTk.Text = "Thêm tài khoản";
            this.btnThemTk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTk.UseVisualStyleBackColor = false;
            this.btnThemTk.Click += new System.EventHandler(this.tbxThemTK_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(5, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbxTenHienThi
            // 
            this.tbxTenHienThi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenHienThi.Location = new System.Drawing.Point(193, 231);
            this.tbxTenHienThi.Name = "tbxTenHienThi";
            this.tbxTenHienThi.Size = new System.Drawing.Size(198, 30);
            this.tbxTenHienThi.TabIndex = 4;
            this.tbxTenHienThi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxMatKhau
            // 
            this.tbxMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMatKhau.Location = new System.Drawing.Point(193, 111);
            this.tbxMatKhau.Name = "tbxMatKhau";
            this.tbxMatKhau.PasswordChar = '*';
            this.tbxMatKhau.Size = new System.Drawing.Size(198, 30);
            this.tbxMatKhau.TabIndex = 2;
            // 
            // tbxTenDangNhap
            // 
            this.tbxTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenDangNhap.Location = new System.Drawing.Point(193, 51);
            this.tbxTenDangNhap.Name = "tbxTenDangNhap";
            this.tbxTenDangNhap.Size = new System.Drawing.Size(198, 30);
            this.tbxTenDangNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên hiển thị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên đăng nhâp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "THÊM TÀI KHOẢN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(690, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fThemTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxNhapLaiMK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemTk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbxTenHienThi;
        private System.Windows.Forms.TextBox tbxMatKhau;
        private System.Windows.Forms.TextBox tbxTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxChucVu;
    }
}