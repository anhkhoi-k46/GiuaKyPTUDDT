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
    public partial class phieunhaphang : UserControl
    {
        public phieunhaphang()
        {
            InitializeComponent();
        }

        private void phieunhaphang_Load(object sender, EventArgs e)
        {
            string[] row1 = { "123", "N01", "Đồ chơi trẻ em", "Trung Quốc", "Lego", "12000" };
            string[] row2 = { "124", "N02", "Đồ chơi trẻ em trẻ con", "Trung Quốc", "Lego", "9000" };
            ListViewItem item1 = new ListViewItem(row1);
            ListViewItem item2 = new ListViewItem(row2);
            lvChiTiet.Items.Add(item1);
            lvChiTiet.Items.Add(item2);
        }

        private void tsmDeleteNCC_Click(object sender, EventArgs e)
        {
            if (lvChiTiet.SelectedItems.Count > 0)
            {
                string selectedID = lvChiTiet.SelectedItems[0].SubItems[0].Text;
                string connectionString = "server=ANHKHOI\\ANHKHOI; database=Toy_Management1; Integrated Security=true;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Tạo câu lệnh xóa
                    string query = "DELETE FROM NhomMatHang WHERE ID = @ID";
                    using (SqlCommand sqlCommand = new SqlCommand(query, conn))
                    {
                        // Truyền tham số vào câu truy vấn để tránh SQL Injection
                        sqlCommand.Parameters.AddWithValue("@ID", selectedID);

                        // Thực thi câu lệnh
                        int rowsAffected = sqlCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã xóa thành công mục được chọn.");

                            // Xóa mục khỏi ListView
                            lvChiTiet.Items.Remove(lvChiTiet.SelectedItems[0]);
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