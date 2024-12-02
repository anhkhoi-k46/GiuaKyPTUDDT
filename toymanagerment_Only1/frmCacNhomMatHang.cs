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

namespace danh_sách_mặt_hàng
{
    public partial class frmCacNhomMH : Form
    {
        public frmCacNhomMH()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCacNhomMH_Load(object sender, EventArgs e)
        {
			LoadNhomMH();

		}

		private void txtMaNhomMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtTenNhomMH.Text = "";
            txtMaNhomMH.Text = "";
            txtLuuY.Text = "";
        }
        private void LoadNhomMH()
        {
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM NhomMatHang";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvNhomMH.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có hóa đơn nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi kết nối hoặc truy vấn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			string tenNMH  = txtTenNhomMH.Text.Trim();
			string manhom = txtMaNhomMH.Text.Trim();
			string luuy = txtLuuY.Text.Trim();
			if (string.IsNullOrEmpty(tenNMH) || string.IsNullOrEmpty(manhom))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Tạo kết nối đến cơ sở dữ liệu
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();

				// Câu lệnh SQL để thêm dữ liệu vào bảng NhaCC
				cmd.CommandText = "INSERT INTO NhomMatHang (IDDoChoi,LoaiDoChoi,GhiChu) VALUES (@IDDoChoi,@LoaiDoChoi,@LuuY)";
				cmd.Parameters.AddWithValue("@IDDoChoi", manhom);
				cmd.Parameters.AddWithValue("@LoaiDoChoi", tenNMH);
				cmd.Parameters.AddWithValue("@LuuY", luuy);

				try
				{
					conn.Open(); // Mở kết nối
					int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL

					if (rowsAffected > 0)
					{
						MessageBox.Show("Thêm MH thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Xóa dữ liệu trên các TextBox sau khi thêm thành công
					txtLuuY.Clear();
						txtMaNhomMH.Clear();
						txtTenNhomMH.Clear();
					}
					else
					{
						MessageBox.Show("Không thêm được MH. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					// Hiển thị thông báo lỗi nếu xảy ra ngoại lệ
					MessageBox.Show($"Lỗi khi thêm nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			LoadNhomMH();
		}
	}
}
