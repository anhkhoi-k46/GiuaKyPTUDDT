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

namespace toymanagerment_Only1
{
	public partial class ThemNCC : Form
	{
		public ThemNCC()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			string tenNCC = txtNCC.Text.Trim();
			string diaChi = txtDiaChi.Text.Trim();
			string sdt = txtSDT.Text.Trim();
			string email = txtEmail.Text.Trim();
			if (string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Tạo kết nối đến cơ sở dữ liệu
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();

				// Câu lệnh SQL để thêm dữ liệu vào bảng NhaCC
				cmd.CommandText = "INSERT INTO NhaCC (TenNCC, DiaChi, SDT, Email) VALUES (@TenNCC, @DiaChi, @SDT, @Email)";
				cmd.Parameters.AddWithValue("@TenNCC", tenNCC);
				cmd.Parameters.AddWithValue("@DiaChi", diaChi);
				cmd.Parameters.AddWithValue("@SDT", sdt);
				cmd.Parameters.AddWithValue("@Email", email);

				try
				{
					conn.Open(); // Mở kết nối
					int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL

					if (rowsAffected > 0)
					{
						MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Xóa dữ liệu trên các TextBox sau khi thêm thành công
						txtNCC.Clear();
						txtDiaChi.Clear();
						txtSDT.Clear();
						txtEmail.Clear();
					}
					else
					{
						MessageBox.Show("Không thêm được nhà cung cấp. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					// Hiển thị thông báo lỗi nếu xảy ra ngoại lệ
					MessageBox.Show($"Lỗi khi thêm nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}
	}
}
