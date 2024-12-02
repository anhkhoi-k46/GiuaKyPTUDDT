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
using them;

namespace toymanagerment_Only1.controls
{
	public partial class UserDSMH : UserControl
	{
		public UserDSMH()
		{
			InitializeComponent();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var form = new Themmh();
			form.Show();
		}

		private void button12_Click(object sender, EventArgs e)
		{

		}


		private void button11_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var form = new frmCacNhomMH();
			form.Show();
		}

		private void UserDSMH_Load(object sender, EventArgs e)
		{
			LoadDanhSachHD();
			LoadCBBNhomMH();

		}
		public void LoadDanhSachHD()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM DoChoi";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvDanhSach.DataSource = dt;
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
		public void LoadDSMHbanchay()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				DateTime selectedDate1 = dtpTuNgay.Value.Date;
				DateTime selectedDate2 = dtpDenNgay.Value.Date.AddDays(1);
				// Câu truy vấn SQL với sắp xếp từ lớn đến nhỏ
				cmd.CommandText = @"
			SELECT 
                TenDoChoi, 
                SUM(HoaDon.SoLuong) AS TongSoLuong
            FROM 
                HoaDon
            INNER JOIN 
                DoChoi ON HoaDon.MaHang = DoChoi.ID
            WHERE 
                HoaDon.NgayLapHD >= @TuNgay AND HoaDon.NgayLapHD <= @DenNgay
            GROUP BY 
                TenDoChoi
            ORDER BY 
                TongSoLuong DESC
           "; // Sắp xếp giảm dần theo SoLuong

				cmd.Parameters.AddWithValue("@TuNgay", selectedDate1);
				cmd.Parameters.AddWithValue("@DenNgay", selectedDate2);
				try
				{

					conn.Open();
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);


					dgvSPBanChay.DataSource = dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"Lỗi khi tải danh sách mặt hàng bán chạy: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void bttnFind_Click(object sender, EventArgs e)
		{
			LoadDSMHbanchay();
		}
		private void LoadCBBNhomMH()
		{

			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT ID, LoaiDoChoi FROM NhomMatHang";

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			conn.Open();
			da.Fill(dt);
			conn.Close();

			cbNhomMatHang.DataSource = dt;
			cbNhomMatHang.DisplayMember = "LoaiDoChoi";
			cbNhomMatHang.ValueMember = "ID";
		}

		private void cbNhomMatHang_Click(object sender, EventArgs e)
		{

		}

		private void cbNhomMatHang_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			if (cbNhomMatHang.SelectedValue != null)
			{
				int selectedNhomMatHangId = Convert.ToInt32(cbNhomMatHang.SelectedValue);

				// Gọi phương thức LoadDanhSachHD theo nhóm mặt hàng đã chọn
				LoadDanhSachDoChoiTheoNhom(selectedNhomMatHangId);
			}
			else
			{
				MessageBox.Show("Vui lòng chọn một nhóm mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		public void LoadDanhSachDoChoiTheoNhom(int nhomMatHangId)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();
				// Thêm điều kiện WHERE để lọc đồ chơi theo nhóm mặt hàng đã chọn
				cmd.CommandText = "SELECT * FROM DoChoi WHERE NhomMatHang = @NhomMatHangID";

				// Thêm tham số vào câu truy vấn
				cmd.Parameters.AddWithValue("@NhomMatHangID", nhomMatHangId);

				try
				{
					conn.Open();
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					da.Fill(dt);

					// Kiểm tra nếu DataTable có dữ liệu
					if (dt.Rows.Count > 0)
					{
						dgvDanhSach.DataSource = dt;
					}
					else
					{
						MessageBox.Show("Không có đồ chơi nào trong nhóm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
		}

		private void btnFindName_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			string find = txtTenHoacMaMH.Text.Trim();
			bool isSearchByText = !string.IsNullOrEmpty(find);

			if (!isSearchByText)
			{
				MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc chọn sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			cmd.CommandText = "SELECT * " +
							  "FROM DoChoi " +
							  "WHERE " +
							  (isSearchByText ? "(TenDoChoi LIKE @Find) " : "");
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
					dgvDanhSach.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không tìm thấy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvDanhSach.DataSource = null; // Xóa dữ liệu hiện có nếu không tìm thấy
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

		private void btnXoa_Click(object sender, EventArgs e)
		{
			LoadDanhSachHD();
		}

		private void xoáSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dgvDanhSach.SelectedRows.Count > 0) // Kiểm tra nếu có hàng được chọn
			{

				string selectedID = dgvDanhSach.SelectedRows[0].Cells["ID"].Value.ToString();

				string connectionString = "server=ANHKHOI\\ANHKHOI; database=Toy_Management1; Integrated Security=true;";
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					conn.Open();

					// Tạo câu lệnh xóa
					string query = "DELETE FROM DoChoi WHERE ID = @ID";
					using (SqlCommand sqlCommand = new SqlCommand(query, conn))
					{
						// Truyền tham số vào câu truy vấn để tránh SQL Injection
						sqlCommand.Parameters.AddWithValue("@ID", selectedID);

						// Thực thi câu lệnh
						int rowsAffected = sqlCommand.ExecuteNonQuery();
						if (rowsAffected > 0)
						{
							MessageBox.Show("Đã xóa thành công mục được chọn.");

							// Xóa hàng khỏi DataGridView
							dgvDanhSach.Rows.Remove(dgvDanhSach.SelectedRows[0]);
						}
						else
						{
							MessageBox.Show("Không thể xóa mục được chọn.");
						}
					}

				}
			}
		}
	}
}
