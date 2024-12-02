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

namespace them
{
    public partial class Themmh : Form
    {
        public Themmh()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";
			string TenDoChoi = txtTenMatHang.Text.Trim();
			string NhomMatHang = txtNhomMatHang.Text.Trim();
			string NhaCC = txtNCC.Text.Trim();
			string Hang = txtHang.Text.Trim();
			string GhiChu = txtMoTa.Text.Trim();	
			string SoLuong = txtSL.Text.Trim();
			string PhanLoai = txtPhanLoai.Text.Trim();	

			if (!float.TryParse(txtGiaNiemYet.Text.Trim(), out float Gia))
			{
				MessageBox.Show("Giá niêm yết không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (string.IsNullOrEmpty(TenDoChoi) || string.IsNullOrEmpty(NhomMatHang) || string.IsNullOrEmpty(PhanLoai) || string.IsNullOrEmpty(NhaCC) || string.IsNullOrEmpty(SoLuong))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Tạo kết nối đến cơ sở dữ liệu
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				SqlCommand cmd = conn.CreateCommand();

				// Câu lệnh SQL để thêm dữ liệu vào bảng DoChoi
				cmd.CommandText = "INSERT INTO DoChoi (TenDoChoi, NhomMatHang, NhaCC,SoLuong, Gia, GhiChu, PhanLoai) " +
								  "VALUES (@TenDoChoi, @NhomMatHang, @NhaCC, @SoLuong, @Gia, @GhiChu, @PhanLoai)";

				// Thêm tham số vào câu truy vấn
				cmd.Parameters.AddWithValue("@TenDoChoi", TenDoChoi);
				cmd.Parameters.AddWithValue("@NhomMatHang", NhomMatHang);
				cmd.Parameters.AddWithValue("@NhaCC", NhaCC);
				cmd.Parameters.AddWithValue("@Hang", Hang);
				cmd.Parameters.AddWithValue("@Gia", Gia);
				cmd.Parameters.AddWithValue("@GhiChu", GhiChu);
				cmd.Parameters.AddWithValue("@SoLuong", SoLuong);
				cmd.Parameters.AddWithValue("@PhanLoai", PhanLoai);
				try
				{
					conn.Open(); // Mở kết nối
					int rowsAffected = cmd.ExecuteNonQuery(); // Thực thi câu lệnh SQL

					if (rowsAffected > 0)
					{
						MessageBox.Show("Thêm đồ chơi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// Xóa dữ liệu trên các TextBox sau khi thêm thành công
						txtTenMatHang.Clear();
						txtNhomMatHang.Clear();
						txtNCC.Clear();
						txtHang.Clear();
						txtMoTa.Clear();
						txtSL.Clear();
						txtGiaNiemYet.Clear();
					}
					else
					{
						MessageBox.Show("Không thêm được đồ chơi. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					// Hiển thị thông báo lỗi nếu xảy ra ngoại lệ
					MessageBox.Show($"Lỗi khi thêm đồ chơi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
