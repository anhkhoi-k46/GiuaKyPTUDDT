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
    public partial class BaoCaoDoanhThu : Form
    {
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
          
        }

		private void btnXemBaoCao_Click(object sender, EventArgs e)
		{
			string connectionString = "server=ANHKHOI\\ANHKHOI; database = Toy_Management1; Integrated Security = true; ";

			SqlConnection conn = new SqlConnection(connectionString);

			SqlCommand cmd = conn.CreateCommand();

			try
			{
				
				DateTime selectedDate1 = dtpTuNgay.Value.Date;
				DateTime selectedDate2 = dtpDenNgay.Value.Date.AddDays(1);
			
				cmd.CommandText = "SELECT * FROM HoaDon WHERE NgayLapHD >= @TuNgay And NgayLapHD < @DenNgay";
			
				cmd.Parameters.AddWithValue("@TuNgay", selectedDate1);
				cmd.Parameters.AddWithValue("@DenNgay", selectedDate2);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();

				conn.Open();
				da.Fill(dt);
				conn.Close();

				dgvHoaDon.DataSource = dt;

				int soLuong = dt.Rows.Count;
				lblSoLuongDon.Text = $"{soLuong}";

				float tongTien = 0;
				foreach (DataRow row in dt.Rows)
				{
					if (float.TryParse(row["TongTien"]?.ToString(), out float tien))
					{
						tongTien += tien;
					}
				}
				lblTongTien.Text = $"{tongTien:N2}";

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
	}
}
