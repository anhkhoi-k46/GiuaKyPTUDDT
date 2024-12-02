namespace toymanagerment_Only1
{
    partial class frmDangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.txtTaiKhoan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblChuY = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(187, 281);
			this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 28);
			this.btnThoat.TabIndex = 13;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnDangNhap.Location = new System.Drawing.Point(55, 281);
			this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(100, 28);
			this.btnDangNhap.TabIndex = 14;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = false;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(120, 15);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 95);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(17, 222);
			this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new System.Drawing.Size(315, 22);
			this.txtMatKhau.TabIndex = 11;
			// 
			// txtTaiKhoan
			// 
			this.txtTaiKhoan.Location = new System.Drawing.Point(17, 159);
			this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTaiKhoan.Name = "txtTaiKhoan";
			this.txtTaiKhoan.Size = new System.Drawing.Size(315, 22);
			this.txtTaiKhoan.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(101, 113);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "ĐĂNG NHẬP";
			// 
			// lblChuY
			// 
			this.lblChuY.AutoSize = true;
			this.lblChuY.ForeColor = System.Drawing.Color.Red;
			this.lblChuY.Location = new System.Drawing.Point(64, 254);
			this.lblChuY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblChuY.Name = "lblChuY";
			this.lblChuY.Size = new System.Drawing.Size(202, 16);
			this.lblChuY.TabIndex = 7;
			this.lblChuY.Text = "Vui lòng nhập cả tên và mật khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 202);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mật khẩu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 139);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tài khoản";
			// 
			// frmDangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 336);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtMatKhau);
			this.Controls.Add(this.txtTaiKhoan);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblChuY);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmDangNhap";
			this.Text = "DangNhap";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChuY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}