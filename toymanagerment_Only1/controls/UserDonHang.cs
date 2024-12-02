using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToyStory;
using System.Data.SqlClient;

namespace toymanagerment_Only1.controls
{
	public partial class UserDonHang : UserControl
	{

		public UserDonHang()
		{
			InitializeComponent();
			LoadDanhSachSP();
			LoadDanhSachKH();
		
		}
		private void LoadCBB()
		{

			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			cmd.CommandText = "SELECT ID,TenDoChoi,SoLuong FROM DoChoi";

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();

			conn.Open();

			da.Fill(dt);

			conn.Close();
			conn.Dispose();

			cboChonSP.DataSource = dt;

			cboChonSP.DisplayMember = "TenDoChoi";

			cboChonSP.ValueMember = "ID";
		}
		public void LoadDanhSachSP()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT DoChoi.ID,TenDoChoi,TenNCC,SoLuong,Gia FROM DoChoi,NhaCC WHERE DoChoi.NhaCC=NhaCC.ID";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvDanhSachSP.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không có sản phẩm nào để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void UserDonHang_Load(object sender, EventArgs e)
		{
			this.LoadCBB();
			LoadDanhSachNV();
		}

		private void panelTaoDonHang_Paint(object sender, PaintEventArgs e)
		{
			LoadDanhSachSP();
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{

		}

		private void btnThanhToan_Click_1(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			try
			{
				conn.Open();

				// Kiểm tra ID nhân viên
				if (string.IsNullOrEmpty(txtIDNV.Text) || !int.TryParse(txtIDNV.Text, out int idnv))
				{
					MessageBox.Show("ID nhân viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Duyệt qua từng dòng trong DataGridView
				foreach (DataGridViewRow row in dgvThongTInHD.Rows)
				{
					if (!row.IsNewRow)
					{
						int id = Convert.ToInt32(row.Cells[0].Value);
						int soLuong = Convert.ToInt32(row.Cells[3].Value);
						decimal tongTien = Convert.ToDecimal(txtTongHoaDon.Text);
						int idkh = int.Parse(txtIDKH.Text);
						DateTime ngayLapHD = dtpNgayLap.Value;

						// Kiểm tra ID sản phẩm có tồn tại không (nếu cần)
						cmd.CommandText = "INSERT INTO HoaDon (KhachHangID, NhanVienID, MaHang, SoLuong, TongTien, NgayLapHD) " +
										  "VALUES (@IDKH, @IDNV, @ID, @SoLuong, @TongTien, @NgayLapHD)";

						cmd.Parameters.Clear(); // Xóa các tham số cũ
						cmd.Parameters.AddWithValue("@IDKH", idkh);
						cmd.Parameters.AddWithValue("@IDNV", idnv);
						cmd.Parameters.AddWithValue("@ID", id);
						cmd.Parameters.AddWithValue("@SoLuong", soLuong);
						cmd.Parameters.AddWithValue("@TongTien", tongTien);
						cmd.Parameters.AddWithValue("@NgayLapHD", ngayLapHD);

						// Thực thi câu lệnh SQL (cập nhật)
						cmd.ExecuteNonQuery();
					}
					MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}

		}

		private void btnDSMT_Click(object sender, EventArgs e)
		{
			LoadDanhSachSP();
			
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();

			string find = txtTimSP.Text.Trim();
			string selectedValue = cboChonSP.SelectedValue?.ToString(); // Lấy giá trị từ ComboBox
			bool isSearchByText = !string.IsNullOrEmpty(find);

			// Kiểm tra điều kiện tìm kiếm
			if (!isSearchByText)
			{
				MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc chọn sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Xây dựng truy vấn tìm kiếm
			cmd.CommandText = "SELECT DoChoi.ID, TenDoChoi, TenNCC, SoLuong, Gia " +
							  "FROM DoChoi, NhaCC " +
							  "WHERE DoChoi.NhaCC = NhaCC.ID " +
							  (isSearchByText ? "AND (TenDoChoi LIKE @Find OR DoChoi.ID = @Find) " : "");


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
					dgvDanhSachSP.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvDanhSachSP.DataSource = null; // Xóa dữ liệu hiện có nếu không tìm thấy
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

		private void dgvDanhSachSP_DoubleClick(object sender, EventArgs e)
		{
			if (dgvDanhSachSP.CurrentRow != null)
			{
				string id = dgvDanhSachSP.CurrentRow.Cells["ID"].Value.ToString();  // Lấy giá trị của cột ID
				string tenDoChoi = dgvDanhSachSP.CurrentRow.Cells["TenDoChoi"].Value.ToString();  // Lấy tên sản phẩm
				string tenNCC = dgvDanhSachSP.CurrentRow.Cells["TenNCC"].Value.ToString();  // Lấy tên nhà cung cấp
				string soLuong = dgvDanhSachSP.CurrentRow.Cells["SoLuong"].Value.ToString();  // Lấy số lượng
				string gia = dgvDanhSachSP.CurrentRow.Cells["Gia"].Value.ToString();  // Lấy giá

				int soLuongThem = 1;

				// Kiểm tra sản phẩm đã tồn tại trong dgvThongTInHD chưa
				bool isFound = false;
				foreach (DataGridViewRow row in dgvThongTInHD.Rows)
				{
					if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
					{
						// Sản phẩm đã tồn tại, tăng số lượng
						int soLuongHienTai = int.Parse(row.Cells[3].Value.ToString());
						row.Cells[3].Value = soLuongHienTai + soLuongThem;
						isFound = true;
						break;
					}
				}

				if (!isFound)
				{
					// Thêm sản phẩm mới vào dgvThongTInHD
					int rowIndex = dgvThongTInHD.Rows.Add();  // Thêm một dòng mới vào dgvThongTInHD
					dgvThongTInHD.Rows[rowIndex].Cells[0].Value = id;
					dgvThongTInHD.Rows[rowIndex].Cells[1].Value = tenDoChoi;
					dgvThongTInHD.Rows[rowIndex].Cells[2].Value = tenNCC;
					dgvThongTInHD.Rows[rowIndex].Cells[3].Value = soLuongThem;  // Số lượng mặc định
					dgvThongTInHD.Rows[rowIndex].Cells[4].Value = gia;
				}
				txtTongHoaDon_TextChanged(sender, e);
			}
		}

		private void txtNhanVien_TextChanged(object sender, EventArgs e)
		{

		}
		public void SetNhanVien(string username)
		{
			txtNhanVien.Text = username;
		}

		private void txtTongHoaDon_TextChanged(object sender, EventArgs e)
		{
			float TongHoaDon = 0;
			foreach (DataGridViewRow row in dgvThongTInHD.Rows)
			{
				if (row.Cells[3].Value != null && row.Cells[4].Value != null)
				{
					try
					{
						float soLuong = Convert.ToSingle(row.Cells[3].Value);
						float gia = Convert.ToSingle(row.Cells[4].Value);

						TongHoaDon += soLuong * gia;
					}
					catch (Exception ex)
					{

						MessageBox.Show($"Lỗi tính tổng hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}
			txtTongHoaDon.Text = TongHoaDon.ToString();
		}

		private void txtTienThua_TextChanged(object sender, EventArgs e)
		{
			try
			{
				float tongHoaDon = 0;
				float tienKhachTra = 0;

				if (float.TryParse(txtTongHoaDon.Text, out tongHoaDon) && float.TryParse(txtTienKHTra.Text, out tienKhachTra))
				{
					float tienThua = tienKhachTra - tongHoaDon;

					txtTienThua.Text = tienThua.ToString();
				}
				else
				{
					txtTienThua.Text = "0.00";
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show($"Lỗi tính tiền thừa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtTienKHTra_TextChanged(object sender, EventArgs e)
		{
			try
			{
				float tongHoaDon = 0;
				float tienKhachTra = 0;

				if (float.TryParse(txtTongHoaDon.Text, out tongHoaDon) && float.TryParse(txtTienKHTra.Text, out tienKhachTra))
				{
					float tienThua = tienKhachTra - tongHoaDon;

					txtTienThua.Text = tienThua.ToString();
				}
				else
				{
					txtTienThua.Text = "0.00";
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show($"Lỗi tính tiền thừa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnfind_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();
			string selectedValue = cboChonSP.SelectedValue?.ToString(); // Lấy giá trị từ ComboBox
			bool isSearchByCombo = !string.IsNullOrEmpty(selectedValue);

			// Kiểm tra điều kiện tìm kiếm
			if (!isSearchByCombo)
			{
				MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm hoặc chọn sản phẩm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Xây dựng truy vấn tìm kiếm
			cmd.CommandText = "SELECT DoChoi.ID, TenDoChoi, TenNCC, SoLuong, Gia " +
							  "FROM DoChoi, NhaCC " +
							  "WHERE DoChoi.NhaCC = NhaCC.ID " +
							  (isSearchByCombo ? "AND DoChoi.ID = @SelectedID " : "");
			if (isSearchByCombo)
			{
				cmd.Parameters.AddWithValue("@SelectedID", selectedValue);
			}

			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					dgvDanhSachSP.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvDanhSachSP.DataSource = null; // Xóa dữ liệu hiện có nếu không tìm thấy
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
		public void LoadDanhSachKH()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandText = "SELECT ID,HoTen,SDT,DiaChi FROM KhachHang";
			try
			{
				conn.Open();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				// Kiểm tra nếu DataTable có dữ liệu
				if (dt.Rows.Count > 0)
				{
					dgvTimKhach.DataSource = dt;
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

		private void txtTimKH_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnTimKH_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";
			SqlConnection conn = new SqlConnection(connectionString);
			SqlCommand cmd = conn.CreateCommand();

			string find = txtTimKH.Text.Trim();
			bool isSearchByText = !string.IsNullOrEmpty(find);

			// Kiểm tra điều kiện tìm kiếm
			if (!isSearchByText)
			{
				MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Xây dựng truy vấn tìm kiếm
			cmd.CommandText = "SELECT HoTen,SDT " +
							  "FROM KhachHang " +
							  "WHERE " +
							  (isSearchByText ? "(HoTen LIKE @Find OR KhachHang.SDT = @Find) " : "");


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
					dgvTimKhach.DataSource = dt;
				}
				else
				{
					MessageBox.Show("Không tìm thấy KH!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvTimKhach.DataSource = null; // Xóa dữ liệu hiện có nếu không tìm thấy
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

		private void btnReloadKH_Click(object sender, EventArgs e)
		{
			LoadDanhSachKH();
		}

		private void dgvTimKhach_DoubleClick(object sender, EventArgs e)
		{
			if (dgvTimKhach != null)
			{
				string id = dgvTimKhach.CurrentRow.Cells["ID"].Value.ToString();
				string HoTen = dgvTimKhach.CurrentRow.Cells["HoTen"].Value.ToString();
				string SDT = dgvTimKhach.CurrentRow.Cells["SDT"].Value.ToString();
				string DiaChi = dgvTimKhach.CurrentRow.Cells["DiaChi"].Value.ToString();

				txtTenKH.Text = HoTen;
				mtbSDT.Text = SDT;
				txtDiaChi.Text = DiaChi;
				txtIDKH.Text = id;
			}
		}
		public void LoadDanhSachNV()
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database=Toy_Management1; Integrated Security=true;";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				try
				{
					SqlCommand cmd = conn.CreateCommand();
					cmd.CommandText = "SELECT NhanVien.ID FROM NhanVien, TaiKhoan WHERE TaiKhoan.ID = NhanVien.IDTaiKhoan AND TaiKhoan.TenTK = '"+txtNhanVien.Text.Trim()+"'";
					conn.Open();

					object result = cmd.ExecuteScalar();

					if (result != null)
					{
						// Đảm bảo rằng kết quả là ID đúng định dạng
						txtIDNV.Text = result.ToString();
					}
					else
					{
						txtIDNV.Text = "Không tìm thấy nhân viên!";
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi: " + ex.Message);
				}
			}
		}

        private void tsmXoaSP_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmXoaSP_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSP.SelectedRows.Count > 0) // Kiểm tra nếu có hàng được chọn
            {
                
                string selectedID = dgvDanhSachSP.SelectedRows[0].Cells["ID"].Value.ToString(); 
                
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
                            dgvDanhSachSP.Rows.Remove(dgvDanhSachSP.SelectedRows[0]);
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa mục được chọn.");
                        }
                    }
                }
            }  
        }

        private void dgvDanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsmXoa_Click(object sender, EventArgs e)
        {

            if (dgvThongTInHD.SelectedRows.Count > 0) // Kiểm tra nếu có hàng được chọn
            {
                // Lưu hàng được chọn
                DataGridViewRow selectedRow = dgvThongTInHD.SelectedRows[0];

                // Xóa hàng
                dgvThongTInHD.Rows.Remove(selectedRow);

                // Kiểm tra nếu không còn hàng nào
                if (dgvThongTInHD.Rows.Count == 0)
                {
                    MessageBox.Show("Không còn hàng nào trong bảng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
