namespace danh_sách_mặt_hàng
{
    partial class frmCacNhomMH
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
			this.txtTenNhomMH = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaNhomMH = new System.Windows.Forms.TextBox();
			this.txtLuuY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnDong = new System.Windows.Forms.Button();
			this.dgvNhomMH = new System.Windows.Forms.DataGridView();
			this.btnLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhomMH)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTenNhomMH
			// 
			this.txtTenNhomMH.Location = new System.Drawing.Point(329, 54);
			this.txtTenNhomMH.Margin = new System.Windows.Forms.Padding(2);
			this.txtTenNhomMH.Name = "txtTenNhomMH";
			this.txtTenNhomMH.Size = new System.Drawing.Size(301, 20);
			this.txtTenNhomMH.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(327, 40);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tên nhóm mặt hàng";
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(389, 206);
			this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(69, 21);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xoá trống";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(327, 80);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Mã nhóm (viết chữ in hoa,từ 3-5 ký tự)";
			// 
			// txtMaNhomMH
			// 
			this.txtMaNhomMH.Location = new System.Drawing.Point(329, 96);
			this.txtMaNhomMH.Margin = new System.Windows.Forms.Padding(2);
			this.txtMaNhomMH.Name = "txtMaNhomMH";
			this.txtMaNhomMH.Size = new System.Drawing.Size(301, 20);
			this.txtMaNhomMH.TabIndex = 6;
			this.txtMaNhomMH.TextChanged += new System.EventHandler(this.txtMaNhomMH_TextChanged);
			// 
			// txtLuuY
			// 
			this.txtLuuY.Location = new System.Drawing.Point(329, 136);
			this.txtLuuY.Margin = new System.Windows.Forms.Padding(2);
			this.txtLuuY.Name = "txtLuuY";
			this.txtLuuY.Size = new System.Drawing.Size(301, 20);
			this.txtLuuY.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(327, 123);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Lưu ý";
			// 
			// btnLuu
			// 
			this.btnLuu.Location = new System.Drawing.Point(484, 206);
			this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(50, 21);
			this.btnLuu.TabIndex = 9;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnDong
			// 
			this.btnDong.Location = new System.Drawing.Point(558, 206);
			this.btnDong.Margin = new System.Windows.Forms.Padding(2);
			this.btnDong.Name = "btnDong";
			this.btnDong.Size = new System.Drawing.Size(50, 21);
			this.btnDong.TabIndex = 10;
			this.btnDong.Text = "Đóng";
			this.btnDong.UseVisualStyleBackColor = true;
			// 
			// dgvNhomMH
			// 
			this.dgvNhomMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhomMH.Location = new System.Drawing.Point(13, 13);
			this.dgvNhomMH.Name = "dgvNhomMH";
			this.dgvNhomMH.Size = new System.Drawing.Size(309, 246);
			this.dgvNhomMH.TabIndex = 11;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(330, 183);
			this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(58, 21);
			this.btnLoad.TabIndex = 12;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// frmCacNhomMH
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 271);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.dgvNhomMH);
			this.Controls.Add(this.btnDong);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLuuY);
			this.Controls.Add(this.txtMaNhomMH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTenNhomMH);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmCacNhomMH";
			this.Text = "Thêm nhóm mặt hàng";
			this.Load += new System.EventHandler(this.frmCacNhomMH_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvNhomMH)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhomMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNhomMH;
        private System.Windows.Forms.TextBox txtLuuY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDong;
		private System.Windows.Forms.DataGridView dgvNhomMH;
		private System.Windows.Forms.Button btnLoad;
	}
}

