namespace toymanagerment_Only1.controls
{
    partial class UserNCC
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConCung = new System.Windows.Forms.Button();
            this.btnMevaBe = new System.Windows.Forms.Button();
            this.btnMyKingdom = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tsmXoaNCC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoáNhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.tsmXoaNCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-63, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tìm kiếm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConCung);
            this.groupBox3.Controls.Add(this.btnMevaBe);
            this.groupBox3.Controls.Add(this.btnMyKingdom);
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(742, 58);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lọc theo đơn vị cung cấp";
            // 
            // btnConCung
            // 
            this.btnConCung.Location = new System.Drawing.Point(237, 24);
            this.btnConCung.Margin = new System.Windows.Forms.Padding(2);
            this.btnConCung.Name = "btnConCung";
            this.btnConCung.Size = new System.Drawing.Size(82, 21);
            this.btnConCung.TabIndex = 4;
            this.btnConCung.Text = "Con Cưng";
            this.btnConCung.UseVisualStyleBackColor = true;
            this.btnConCung.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnMevaBe
            // 
            this.btnMevaBe.Location = new System.Drawing.Point(125, 24);
            this.btnMevaBe.Margin = new System.Windows.Forms.Padding(2);
            this.btnMevaBe.Name = "btnMevaBe";
            this.btnMevaBe.Size = new System.Drawing.Size(82, 21);
            this.btnMevaBe.TabIndex = 3;
            this.btnMevaBe.Text = "Mẹ và Bé";
            this.btnMevaBe.UseVisualStyleBackColor = true;
            this.btnMevaBe.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnMyKingdom
            // 
            this.btnMyKingdom.Location = new System.Drawing.Point(7, 24);
            this.btnMyKingdom.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyKingdom.Name = "btnMyKingdom";
            this.btnMyKingdom.Size = new System.Drawing.Size(82, 21);
            this.btnMyKingdom.TabIndex = 0;
            this.btnMyKingdom.Text = "My Kingdom";
            this.btnMyKingdom.UseVisualStyleBackColor = true;
            this.btnMyKingdom.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemNCC.ForeColor = System.Drawing.Color.Red;
            this.btnThemNCC.Location = new System.Drawing.Point(454, 80);
            this.btnThemNCC.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(130, 21);
            this.btnThemNCC.TabIndex = 12;
            this.btnThemNCC.Text = "Thêm Nhà Cung Cấp";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTim.ForeColor = System.Drawing.Color.Red;
            this.btnTim.Location = new System.Drawing.Point(382, 80);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(50, 21);
            this.btnTim.TabIndex = 11;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(88, 82);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(261, 20);
            this.txtTimKiem.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tìm kiếm";
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.ContextMenuStrip = this.tsmXoaNCC;
            this.dgvNCC.Location = new System.Drawing.Point(9, 107);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNCC.Size = new System.Drawing.Size(866, 326);
            this.dgvNCC.TabIndex = 13;
            this.dgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNCC_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(606, 80);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "LoadNCC";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tsmXoaNCC
            // 
            this.tsmXoaNCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoáNhàCungCấpToolStripMenuItem});
            this.tsmXoaNCC.Name = "tsmXoaNCC";
            this.tsmXoaNCC.Size = new System.Drawing.Size(181, 48);
            this.tsmXoaNCC.Opening += new System.ComponentModel.CancelEventHandler(this.tsmXoaNCC_Opening);
            // 
            // xoáNhàCungCấpToolStripMenuItem
            // 
            this.xoáNhàCungCấpToolStripMenuItem.Name = "xoáNhàCungCấpToolStripMenuItem";
            this.xoáNhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xoáNhàCungCấpToolStripMenuItem.Text = "Xoá Nhà Cung Cấp";
            this.xoáNhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.xoáNhàCungCấpToolStripMenuItem_Click);
            // 
            // UserNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvNCC);
            this.Controls.Add(this.btnThemNCC);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserNCC";
            this.Size = new System.Drawing.Size(878, 436);
            this.Load += new System.EventHandler(this.UserNCC_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.tsmXoaNCC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConCung;
        private System.Windows.Forms.Button btnMevaBe;
        private System.Windows.Forms.Button btnMyKingdom;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvNCC;
		private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ContextMenuStrip tsmXoaNCC;
        private System.Windows.Forms.ToolStripMenuItem xoáNhàCungCấpToolStripMenuItem;
    }
}
