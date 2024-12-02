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
    public partial class uqlnv : UserControl
    {
        public uqlnv()
        {
            InitializeComponent();
        }

    

        private void btnSuaMK_NV_Click(object sender, EventArgs e)
        {
           
        }

        private void uqlnv_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Rows.Add("Tran Anh Khoi", "K123", "09223323", "Nam", "05/01/2004", "Quản lý", "12/12/2023", "");
        }
    }
}
