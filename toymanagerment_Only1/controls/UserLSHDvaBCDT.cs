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
	public partial class UserLSHDvaBCDT : UserControl
	{
		public UserLSHDvaBCDT()
		{
			InitializeComponent();
			LoadDanhSachHD();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			var form = new BaoCaoDoanhThu();
			form.ShowDialog();
		}

		private void UserLSHDvaBCDT_Load(object sender, EventArgs e)
		{
			LoadCBBNhanVien();
		}

		public void LoadDanhSachHD()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM HoaDon";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvHoaDon.DataSource = dt;
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
		/*public void LoadDanhSachCTHD()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT * FROM ChiTietHoaDon";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvChiTietHD.DataSource = dt;
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
		}*/
		private void LoadCBBNhanVien()
		{

			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT ID,HoTen FROM NhanVien";

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			conn.Open();

			da.Fill(dt);

			conn.Close();
			conn.Dispose();

			cbLapBoi.DataSource = dt;

			cbLapBoi.DisplayMember = "HoTen";

			cbLapBoi.ValueMember = "ID";
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			try
			{
				string selectedNhanVienID = cbLapBoi.SelectedValue.ToString();
				DateTime selectedDate1 = dtpTuNgay.Value.Date;
				DateTime selectedDate2 = dtpDenNgay.Value.Date.AddDays(1);
				cmd.CommandText = "SELECT * FROM HoaDon WHERE NhanVienID = @NhanVienID AND NgayLapHD >= @TuNgay And NgayLapHD < @DenNgay";


				cmd.Parameters.AddWithValue("@NhanVienID", selectedNhanVienID);
				cmd.Parameters.AddWithValue("@TuNgay", selectedDate1);
				cmd.Parameters.AddWithValue("@DenNgay", selectedDate2);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();

				conn.Open();
				da.Fill(dt);
				conn.Close();

				dgvHoaDon.DataSource = dt;
				if (dt.Rows.Count == 0)
				{
					MessageBox.Show("Không tìm thấy kết quả phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Dispose();
			}
		}

		private void lvCTHoaDon_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dgvHoaDon_DoubleClick(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true;";

			if (dgvHoaDon.CurrentRow != null)
			{
				// Lấy giá trị từ dòng hiện tại
				string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString(); // HoaDonID
				string khachhangID = dgvHoaDon.CurrentRow.Cells[1].Value.ToString(); // KhachHangID
				string nhanvienID = dgvHoaDon.CurrentRow.Cells[2].Value.ToString(); // NhanVienID
				string tongtien = dgvHoaDon.CurrentRow.Cells[4].Value.ToString(); // TongTien
				string ngaylap = dgvHoaDon.CurrentRow.Cells[5].Value.ToString(); // NgayLapHD

				// Hiển thị thông tin cơ bản lên các control
				dtpNgayLap.Text = ngaylap;
				txtTongThanhTien.Text = tongtien;


				// Truy vấn để lấy tên khách hàng từ KhachHangID
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					using (SqlCommand cmd = conn.CreateCommand())
					{
						try
						{
							// Câu lệnh SQL để lấy tên khách hàng
							cmd.CommandText = "SELECT HoTen,SDT,DiaChi FROM KhachHang WHERE ID = @KhachHangID";
							cmd.Parameters.AddWithValue("@KhachHangID", khachhangID);

							conn.Open();

							// Thực thi và lấy kết quả
							object result = cmd.ExecuteScalar();

							// Sử dụng SqlDataReader để đọc dữ liệu nhiều cột
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									txtTenKH.Text = reader["HoTen"].ToString(); // Gán tên khách hàng
									txtSDT.Text = reader["SDT"].ToString();    // Gán số điện thoại
									txtDiaChiGiao.Text = reader["DiaChi"].ToString(); // Gán địa chỉ
								}
								else
								{
									MessageBox.Show("Không tìm thấy thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
								}
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Lỗi khi truy vấn khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					using (SqlCommand cmd = conn.CreateCommand())
					{
						try
						{
							cmd.CommandText = "SELECT HoTen FROM NhanVien WHERE ID = @NhanVienID";
							cmd.Parameters.Clear(); // Xóa các tham số trước đó
							cmd.Parameters.AddWithValue("@NhanVienID", nhanvienID);

							object result = cmd.ExecuteScalar();
							if (result != null)
							{
								txtNhanVien.Text = result.ToString(); // Gán tên nhân viên vào textbox
							}
							else
							{
								MessageBox.Show("Không tìm thấy thông tin nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Lỗi khi truy vấn nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void dgvChiTietHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void tsmXoaHD_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database=Toy_Management1; Integrated Security=true;";
			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand sqlCommand = conn.CreateCommand();
			sqlCommand.CommandText = "DELETE FROM HoaDon WHERE ID = @ID";
			if (dgvHoaDon.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvHoaDon.SelectedRows[0];
				DataRowView rowview = selectedRow.DataBoundItem as DataRowView;

				sqlCommand.Parameters.Add("@ID", SqlDbType.NVarChar);
				sqlCommand.Parameters["@ID"].Value = rowview["ID"];

				conn.Open();

				int rowsAffected = sqlCommand.ExecuteNonQuery();

                conn.Close();

				if (rowsAffected == 1)
				{
					MessageBox.Show("Đã xóa thành công mục được chọn.");
					dgvHoaDon.Rows.Remove(selectedRow);
				}
				else
				{
					MessageBox.Show("Không thể xóa mục được chọn.");

				}
				sqlCommand.Dispose();
				conn.Dispose();
			}
		}

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
