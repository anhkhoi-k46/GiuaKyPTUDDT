namespace toymanagerment_Only1.controls
{
    partial class UserDSMH
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnNhomMH = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNhomMatHang = new System.Windows.Forms.ComboBox();
            this.txtTenHoacMaMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSPBanChay = new System.Windows.Forms.DataGridView();
            this.bttnFind = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmXoaMH = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPBanChay)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(11, 100);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(979, 245);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(2, 15);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(975, 228);
            this.dgvDanhSach.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindName);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.btnNhomMH);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbNhomMatHang);
            this.groupBox1.Controls.Add(this.txtTenHoacMaMH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThemMH);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(920, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc và tìm kiếm";
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(478, 34);
            this.btnFindName.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(50, 19);
            this.btnFindName.TabIndex = 18;
            this.btnFindName.Text = "Tìm";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(89, 49);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 19);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnNhomMH
            // 
            this.btnNhomMH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNhomMH.ForeColor = System.Drawing.Color.Cyan;
            this.btnNhomMH.Location = new System.Drawing.Point(785, 34);
            this.btnNhomMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhomMH.Name = "btnNhomMH";
            this.btnNhomMH.Size = new System.Drawing.Size(111, 21);
            this.btnNhomMH.TabIndex = 16;
            this.btnNhomMH.Text = "Nhóm mặt hàng";
            this.btnNhomMH.UseVisualStyleBackColor = false;
            this.btnNhomMH.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(577, 34);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 19);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá bộ lọc";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên hoặc mã mặt hàng";
            // 
            // cbNhomMatHang
            // 
            this.cbNhomMatHang.FormattingEnabled = true;
            this.cbNhomMatHang.Items.AddRange(new object[] {
            "Trò chơi bé gái",
            "Trò chơi bé trai "});
            this.cbNhomMatHang.Location = new System.Drawing.Point(89, 24);
            this.cbNhomMatHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbNhomMatHang.Name = "cbNhomMatHang";
            this.cbNhomMatHang.Size = new System.Drawing.Size(143, 21);
            this.cbNhomMatHang.TabIndex = 13;
            this.cbNhomMatHang.SelectedIndexChanged += new System.EventHandler(this.cbNhomMatHang_SelectedIndexChanged);
            this.cbNhomMatHang.Click += new System.EventHandler(this.cbNhomMatHang_Click);
            // 
            // txtTenHoacMaMH
            // 
            this.txtTenHoacMaMH.Location = new System.Drawing.Point(356, 33);
            this.txtTenHoacMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHoacMaMH.Name = "txtTenHoacMaMH";
            this.txtTenHoacMaMH.Size = new System.Drawing.Size(118, 20);
            this.txtTenHoacMaMH.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhóm mặt hàng";
            // 
            // btnThemMH
            // 
            this.btnThemMH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemMH.ForeColor = System.Drawing.Color.Red;
            this.btnThemMH.Location = new System.Drawing.Point(661, 34);
            this.btnThemMH.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(111, 21);
            this.btnThemMH.TabIndex = 8;
            this.btnThemMH.Text = "Thêm mặt hàng";
            this.btnThemMH.UseVisualStyleBackColor = false;
            this.btnThemMH.Click += new System.EventHandler(this.button8_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSPBanChay);
            this.panel1.Controls.Add(this.bttnFind);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(17, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 205);
            this.panel1.TabIndex = 7;
            // 
            // dgvSPBanChay
            // 
            this.dgvSPBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPBanChay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSPBanChay.Location = new System.Drawing.Point(0, 55);
            this.dgvSPBanChay.Name = "dgvSPBanChay";
            this.dgvSPBanChay.Size = new System.Drawing.Size(495, 150);
            this.dgvSPBanChay.TabIndex = 15;
            // 
            // bttnFind
            // 
            this.bttnFind.Location = new System.Drawing.Point(399, 31);
            this.bttnFind.Name = "bttnFind";
            this.bttnFind.Size = new System.Drawing.Size(75, 23);
            this.bttnFind.TabIndex = 14;
            this.bttnFind.Text = "Find";
            this.bttnFind.UseVisualStyleBackColor = true;
            this.bttnFind.Click += new System.EventHandler(this.bttnFind_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Đến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Từ:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(239, 33);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(135, 20);
            this.dtpDenNgay.TabIndex = 11;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(44, 33);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(135, 20);
            this.dtpTuNgay.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sản phẩm bán chạy";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXoaMH});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // tsmXoaMH
            // 
            this.tsmXoaMH.Name = "tsmXoaMH";
            this.tsmXoaMH.Size = new System.Drawing.Size(180, 22);
            this.tsmXoaMH.Text = "Xoá mặt hàng";
            this.tsmXoaMH.Click += new System.EventHandler(this.xoáSảnPhẩmToolStripMenuItem_Click);
            // 
            // UserDSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserDSMH";
            this.Size = new System.Drawing.Size(1008, 560);
            this.Load += new System.EventHandler(this.UserDSMH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPBanChay)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbNhomMatHang;
        private System.Windows.Forms.TextBox txtTenHoacMaMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnNhomMH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgvDanhSach;
		private System.Windows.Forms.DataGridView dgvSPBanChay;
		private System.Windows.Forms.Button bttnFind;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmXoaMH;
    }
}
