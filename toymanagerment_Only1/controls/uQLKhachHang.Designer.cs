namespace toymanagerment_Only1.controls
{
    partial class uQLKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uQLKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_DSKH = new System.Windows.Forms.GroupBox();
            this.btnLocKH = new System.Windows.Forms.Button();
            this.btnTimKiem_KH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvThongTinKH = new System.Windows.Forms.DataGridView();
            this.gbTT_KH = new System.Windows.Forms.GroupBox();
            this.btnSua_KH = new System.Windows.Forms.Button();
            this.btnXoa_KH = new System.Windows.Forms.Button();
            this.btnThem_KH = new System.Windows.Forms.Button();
            this.txbMaSo_KH = new System.Windows.Forms.TextBox();
            this.txbSDT_KH = new System.Windows.Forms.TextBox();
            this.txbTen_KH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colTen_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaSo_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT_KH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_DSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKH)).BeginInit();
            this.gbTT_KH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DSKH
            // 
            this.gb_DSKH.Controls.Add(this.btnLocKH);
            this.gb_DSKH.Controls.Add(this.btnTimKiem_KH);
            this.gb_DSKH.Controls.Add(this.label6);
            this.gb_DSKH.Controls.Add(this.dgvThongTinKH);
            this.gb_DSKH.Location = new System.Drawing.Point(2, 143);
            this.gb_DSKH.Margin = new System.Windows.Forms.Padding(2);
            this.gb_DSKH.Name = "gb_DSKH";
            this.gb_DSKH.Padding = new System.Windows.Forms.Padding(2);
            this.gb_DSKH.Size = new System.Drawing.Size(484, 223);
            this.gb_DSKH.TabIndex = 4;
            this.gb_DSKH.TabStop = false;
            this.gb_DSKH.Text = "Danh sách khách hàng";
            this.gb_DSKH.Enter += new System.EventHandler(this.gb_DSKH_Enter);
            // 
            // btnLocKH
            // 
            this.btnLocKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocKH.BackgroundImage")));
            this.btnLocKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocKH.Location = new System.Drawing.Point(446, 9);
            this.btnLocKH.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocKH.Name = "btnLocKH";
            this.btnLocKH.Size = new System.Drawing.Size(29, 24);
            this.btnLocKH.TabIndex = 7;
            this.btnLocKH.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem_KH
            // 
            this.btnTimKiem_KH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem_KH.BackgroundImage")));
            this.btnTimKiem_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem_KH.Location = new System.Drawing.Point(412, 9);
            this.btnTimKiem_KH.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem_KH.Name = "btnTimKiem_KH";
            this.btnTimKiem_KH.Size = new System.Drawing.Size(29, 24);
            this.btnTimKiem_KH.TabIndex = 6;
            this.btnTimKiem_KH.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm khách hàng                                                              " +
    "                                 ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvThongTinKH
            // 
            this.dgvThongTinKH.AllowUserToOrderColumns = true;
            this.dgvThongTinKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinKH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvThongTinKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvThongTinKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTen_KH,
            this.colMaSo_KH,
            this.colSDT_KH});
            this.dgvThongTinKH.GridColor = System.Drawing.SystemColors.Control;
            this.dgvThongTinKH.Location = new System.Drawing.Point(4, 37);
            this.dgvThongTinKH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongTinKH.Name = "dgvThongTinKH";
            this.dgvThongTinKH.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinKH.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTinKH.RowTemplate.Height = 24;
            this.dgvThongTinKH.ShowCellErrors = false;
            this.dgvThongTinKH.ShowRowErrors = false;
            this.dgvThongTinKH.Size = new System.Drawing.Size(477, 182);
            this.dgvThongTinKH.TabIndex = 0;
            // 
            // gbTT_KH
            // 
            this.gbTT_KH.Controls.Add(this.btnSua_KH);
            this.gbTT_KH.Controls.Add(this.btnXoa_KH);
            this.gbTT_KH.Controls.Add(this.btnThem_KH);
            this.gbTT_KH.Controls.Add(this.txbMaSo_KH);
            this.gbTT_KH.Controls.Add(this.txbSDT_KH);
            this.gbTT_KH.Controls.Add(this.txbTen_KH);
            this.gbTT_KH.Controls.Add(this.label3);
            this.gbTT_KH.Controls.Add(this.label2);
            this.gbTT_KH.Controls.Add(this.label1);
            this.gbTT_KH.Location = new System.Drawing.Point(2, 2);
            this.gbTT_KH.Margin = new System.Windows.Forms.Padding(2);
            this.gbTT_KH.Name = "gbTT_KH";
            this.gbTT_KH.Padding = new System.Windows.Forms.Padding(2);
            this.gbTT_KH.Size = new System.Drawing.Size(484, 138);
            this.gbTT_KH.TabIndex = 3;
            this.gbTT_KH.TabStop = false;
            this.gbTT_KH.Text = "Thông tin khách hàng";
            // 
            // btnSua_KH
            // 
            this.btnSua_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua_KH.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_KH.Image")));
            this.btnSua_KH.Location = new System.Drawing.Point(376, 97);
            this.btnSua_KH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua_KH.Name = "btnSua_KH";
            this.btnSua_KH.Size = new System.Drawing.Size(79, 31);
            this.btnSua_KH.TabIndex = 14;
            this.btnSua_KH.Text = "SỬA";
            this.btnSua_KH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua_KH.UseVisualStyleBackColor = true;
            // 
            // btnXoa_KH
            // 
            this.btnXoa_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa_KH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_KH.Image")));
            this.btnXoa_KH.Location = new System.Drawing.Point(376, 57);
            this.btnXoa_KH.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa_KH.Name = "btnXoa_KH";
            this.btnXoa_KH.Size = new System.Drawing.Size(79, 31);
            this.btnXoa_KH.TabIndex = 13;
            this.btnXoa_KH.Text = "XOÁ";
            this.btnXoa_KH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa_KH.UseVisualStyleBackColor = true;
            // 
            // btnThem_KH
            // 
            this.btnThem_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem_KH.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_KH.Image")));
            this.btnThem_KH.Location = new System.Drawing.Point(376, 17);
            this.btnThem_KH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem_KH.Name = "btnThem_KH";
            this.btnThem_KH.Size = new System.Drawing.Size(79, 31);
            this.btnThem_KH.TabIndex = 12;
            this.btnThem_KH.Text = "THÊM";
            this.btnThem_KH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem_KH.UseVisualStyleBackColor = true;
            // 
            // txbMaSo_KH
            // 
            this.txbMaSo_KH.Location = new System.Drawing.Point(113, 60);
            this.txbMaSo_KH.Margin = new System.Windows.Forms.Padding(2);
            this.txbMaSo_KH.Name = "txbMaSo_KH";
            this.txbMaSo_KH.Size = new System.Drawing.Size(257, 20);
            this.txbMaSo_KH.TabIndex = 8;
            // 
            // txbSDT_KH
            // 
            this.txbSDT_KH.Location = new System.Drawing.Point(113, 98);
            this.txbSDT_KH.Margin = new System.Windows.Forms.Padding(2);
            this.txbSDT_KH.Name = "txbSDT_KH";
            this.txbSDT_KH.Size = new System.Drawing.Size(257, 20);
            this.txbSDT_KH.TabIndex = 6;
            // 
            // txbTen_KH
            // 
            this.txbTen_KH.Location = new System.Drawing.Point(113, 23);
            this.txbTen_KH.Margin = new System.Windows.Forms.Padding(2);
            this.txbTen_KH.Name = "txbTen_KH";
            this.txbTen_KH.Size = new System.Drawing.Size(257, 20);
            this.txbTen_KH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số khách hàng\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên khách hàng";
            // 
            // colTen_KH
            // 
            this.colTen_KH.HeaderText = "Tên khách hàng";
            this.colTen_KH.MinimumWidth = 6;
            this.colTen_KH.Name = "colTen_KH";
            // 
            // colMaSo_KH
            // 
            this.colMaSo_KH.HeaderText = "Mã Số";
            this.colMaSo_KH.MinimumWidth = 6;
            this.colMaSo_KH.Name = "colMaSo_KH";
            // 
            // colSDT_KH
            // 
            this.colSDT_KH.HeaderText = "SĐT";
            this.colSDT_KH.MinimumWidth = 6;
            this.colSDT_KH.Name = "colSDT_KH";
            // 
            // uQLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_DSKH);
            this.Controls.Add(this.gbTT_KH);
            this.Name = "uQLKhachHang";
            this.Size = new System.Drawing.Size(492, 370);
            this.Load += new System.EventHandler(this.uQLKhachHang_Load);
            this.gb_DSKH.ResumeLayout(false);
            this.gb_DSKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKH)).EndInit();
            this.gbTT_KH.ResumeLayout(false);
            this.gbTT_KH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DSKH;
        private System.Windows.Forms.Button btnLocKH;
        private System.Windows.Forms.Button btnTimKiem_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvThongTinKH;
        private System.Windows.Forms.GroupBox gbTT_KH;
        private System.Windows.Forms.Button btnSua_KH;
        private System.Windows.Forms.Button btnXoa_KH;
        private System.Windows.Forms.Button btnThem_KH;
        private System.Windows.Forms.TextBox txbMaSo_KH;
        private System.Windows.Forms.TextBox txbSDT_KH;
        private System.Windows.Forms.TextBox txbTen_KH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSo_KH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT_KH;
    }
}
