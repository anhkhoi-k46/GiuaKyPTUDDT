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


namespace toymanagerment_Only1.controls
{
    public partial class UserNCC : UserControl
    {
        public UserNCC()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM NhaCC WHERE TenNCC = N'MyKingDom'";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvNCC.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có nhà cung cấp nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void button12_Click(object sender, EventArgs e)
        {
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM NhaCC WHERE TenNCC = N'ConCung'";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvNCC.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có nhà cung cấp nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button11_Click(object sender, EventArgs e)
        {
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT * FROM NhaCC WHERE TenNCC = N'MeVaBe'";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvNCC.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có nhà cung cấp nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UserNCC_Load(object sender, EventArgs e)
        {
			LoadDanhSachNCC();

		}
		public void LoadDanhSachNCC()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM NhaCC";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvNCC.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có nhà cung cấp nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void btnTim_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			string find = txtTimKiem.Text.Trim();
			bool isSearchByText = !string.IsNullOrEmpty(find);

			if (!isSearchByText)
			{
				MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc chọn sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			cmd.CommandText = "SELECT ID, TenNCC, DiaChi, SDT, Email " +
							  "FROM NhaCC " +
							  "WHERE " +
							  (isSearchByText ? "(TenNCC LIKE @Find) " : "");
			if (isSearchByText)
			{
				cmd.Parameters.AddWithValue("@Find", find); // Tìm kiếm gần đúng với LIKE
			}
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					dgvNCC.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvNCC.DataSource = null; // Xóa dữ liệu hiện có nếu không tìm thấy
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

		private void btnThemNCC_Click(object sender, EventArgs e)
		{
			var them = new ThemNCC();
			them.Show();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			LoadDanhSachNCC();
		}

		private void xoáNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
		{          
                string connectionString = "server=ANHKHOI\\ANHKHOI; database=Toy_Management1; Integrated Security=true;";
				SqlConnection conn = new SqlConnection(connectionString);

				SqlCommand sqlCommand = conn.CreateCommand();
				sqlCommand.CommandText= "DELETE FROM NhaCC WHERE TenNCC = @TenCC";
				if (dgvNCC.SelectedRows.Count > 0)
				{
					DataGridViewRow selectedRow = dgvNCC.SelectedRows[0];
					DataRowView rowview = selectedRow.DataBoundItem as DataRowView;

					sqlCommand.Parameters.Add("@TenCC", SqlDbType.NVarChar);
					sqlCommand.Parameters["@TenCC"].Value = rowview["TenNCC"];

					conn.Open();
             
					int rowsAffected = sqlCommand.ExecuteNonQuery();
					conn.Close();

					if (rowsAffected == 1)
					{
						MessageBox.Show("Đã xóa thành công mục được chọn.");
						dgvNCC.Rows.Remove(selectedRow);
					}
					else
					{
						MessageBox.Show("Không thể xóa mục được chọn.");

					}
				sqlCommand.Dispose();
				conn.Dispose();
            }
		}

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmXoaNCC_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
