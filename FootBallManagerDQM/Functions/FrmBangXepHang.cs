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

namespace FootBallManagerDQM.Functions
{
    public partial class FrmBangXepHang : Form
    {
        public FrmBangXepHang()
        {
            InitializeComponent();
        }

        string connectionString = FootBallManagerDQM.Properties.Settings.Default.DatabaseFootballManagerConnectionString;

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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = @"select [TenDoi], sum([SoTranDaThiDau]) as SoTranDaDau, sum(HieuSo) as HieuSo, sum([Diem]) as TongDiem from BangDiemThiDau group by [TenDoi] order by sum([Diem]) desc, sum(HieuSo) desc";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        databaseFootballManagerDataSet.BangDiemThiDau.Clear();
                        adapter.Fill(databaseFootballManagerDataSet.BangDiemThiDau);
                        
                        int i = 1;
                        foreach (DataRow row in databaseFootballManagerDataSet.BangDiemThiDau.Rows)
                        {
                            row["STT"] = i;
                            i++;
                        }

                        // Hiển thị dữ liệu
                        bangDiemThiDauBindingSource.DataSource = databaseFootballManagerDataSet.BangDiemThiDau;
                        bangKetQuaDataGridView.DataSource = bangDiemThiDauBindingSource;

                        bangKetQuaDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
    }
}
