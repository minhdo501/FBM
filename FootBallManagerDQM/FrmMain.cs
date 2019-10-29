using FootBallManagerDQM.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallManagerDQM
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBangXepHang_Click(object sender, EventArgs e)
        {
            FrmBangXepHang frmbangxephang = new FrmBangXepHang();
            frmbangxephang.Show();
        }

        private void btnNhapKetQua_Click(object sender, EventArgs e)
        {
            FrmNhapKetQua frmnhapketqua = new FrmNhapKetQua();
            frmnhapketqua.Show();
        }
    }
}
