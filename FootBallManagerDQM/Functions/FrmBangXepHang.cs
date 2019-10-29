using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBallManagerDQM.Functions
{
    public partial class FrmBangXepHang : Form
    {
        public FrmBangXepHang()
        {
            InitializeComponent();
        }

        private void bangDiemThiDauBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bangDiemThiDauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseFootballManagerDataSet);

        }

        private void FrmBangXepHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFootballManagerDataSet.BangDiemThiDau' table. You can move, or remove it, as needed.
            this.bangDiemThiDauTableAdapter.Fill(this.databaseFootballManagerDataSet.BangDiemThiDau);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
