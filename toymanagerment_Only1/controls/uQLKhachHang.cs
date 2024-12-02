using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toymanagerment_Only1.controls
{
    public partial class uQLKhachHang : UserControl
    {
        public uQLKhachHang()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gb_DSKH_Enter(object sender, EventArgs e)
        {
            
        }

        private void uQLKhachHang_Load(object sender, EventArgs e)
        {
            dgvThongTinKH.Rows.Add("Nham Vinh Thuy", "692004", "0988676767");
        }
    }
}
