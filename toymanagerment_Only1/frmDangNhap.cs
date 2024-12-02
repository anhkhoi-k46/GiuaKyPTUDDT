using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace toymanagerment_Only1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
			string username = txtTaiKhoan.Text.Trim();
			string password = txtMatKhau.Text.Trim();
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
            
				if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			try
			{
				conn.Open();
				string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenTK=@TenTK and MatKhau=@mk";
				using (cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@TenTK", username);
					cmd.Parameters.AddWithValue("@mk", password);

					object result = cmd.ExecuteScalar();

                    if (result!=null)
                    {
						int role = Convert.ToInt32(result);
						MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
						OpenMainForm(role,username);
					}
					else
					{
						MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						txtTaiKhoan.Text = "";
						txtMatKhau.Text = "";
					}
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
		private void OpenMainForm(int role,string username)
		{
			var main = new mainform(role);
			main.UserName = username;
			main.Show();
			this.Hide();
		}
    }
}
