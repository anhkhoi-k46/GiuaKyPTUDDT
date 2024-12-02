using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using danh_sách_mặt_hàng;
using toymanagerment_Only1.controls;
using ToyStory;

namespace toymanagerment_Only1
{
    public partial class mainform : Form
    {
		private int _role;
		public string UserName { get; set; }
		controls.UserDonHang udonhang = new controls.UserDonHang();
        controls.UserDSMH udsmh = new controls.UserDSMH();
        controls.UserNCC uncc = new controls.UserNCC();
        controls.UserLSHDvaBCDT ulshdvabcdt = new controls.UserLSHDvaBCDT();
        controls.phieunhaphang upnh = new controls.phieunhaphang();
        controls.uQLKhachHang uqlkh = new controls .uQLKhachHang();
        controls.uqlnv uqlnv = new controls .uqlnv();
        public mainform(int role)
        {
            InitializeComponent();
            _role = role;
            CustomizeUIBasedOnRole();
			udonhang.SetNhanVien(UserName);
		}
		private void CustomizeUIBasedOnRole()
		{
			if (_role == 1) // Chủ
			{
				// Chủ có quyền truy cập tất cả các chức năng
				btnTaoDonHang.Enabled = true;
				btnLSHD.Enabled = true;
				btnQLSP.Enabled = true;
				btnNCC.Enabled = true;
				btnKH.Enabled = true;
				btnNhamVien.Enabled = true;
			}
			else if (_role == 0) // Nhân viên
			{
				// Nhân viên không có quyền truy cập các chức năng quản lý
				btnTaoDonHang.Enabled = true;  // Nhân viên vẫn có thể tạo đơn hàng
				btnLSHD.Enabled = false; 
				btnQLSP.Enabled = false;
				btnNCC.Enabled = false;
				btnKH.Enabled = false;
            
				btnNhamVien.Enabled = false;
			}
		}
		private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
           panelForm.Controls.Clear();
            panelForm.Controls.Add(udonhang);
            udonhang.Dock = DockStyle.Fill;
        }


        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            panelForm.Controls.Add(udonhang);
        }

        private void btLSHD_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            panelForm.Controls.Add(ulshdvabcdt);
            ulshdvabcdt.Dock = DockStyle.Fill;
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            panelForm.Controls.Add(udsmh);
            udsmh.Dock = DockStyle.Fill;
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            panelForm.Controls.Add(uncc);
            uncc.Dock = DockStyle.Fill;
        }

        private void btnBaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            panelForm.Controls.Add(uqlkh);
            uqlkh.Dock = DockStyle.Fill;
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            panelForm.Controls.Add(upnh);
            upnh.Dock = DockStyle.Fill;
        }

        private void btnNhamVien_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            panelForm.Controls.Add(uqlnv);
            uqlnv.Dock = DockStyle.Fill;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmDangNhap();
            form.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            txtUser.Text=UserName;
			if (_role == 1)
            {
                txtChucVu.Text = "CHỦ";
            }
            else
            {
				txtChucVu.Text = "NHÂN VIÊN";
			}
			udonhang.SetNhanVien(UserName);
		}
	}
}
