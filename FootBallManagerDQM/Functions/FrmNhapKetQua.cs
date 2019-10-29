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
    public partial class FrmNhapKetQua : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = FootBallManagerDQM.Properties.Settings.Default.DatabaseFootballManagerConnectionString;

        public FrmNhapKetQua()
        {
            InitializeComponent();
        }

        private void lblDoi2_Click(object sender, EventArgs e)
        {

        }

        private void txtDoi2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bangDiemThiDauBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bangDiemThiDauBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseFootballManagerDataSet);

        }

        private void FrmNhapKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseFootballManagerDataSet.BangDiemThiDau' table. You can move, or remove it, as needed.
            this.bangDiemThiDauTableAdapter.Fill(this.databaseFootballManagerDataSet.BangDiemThiDau);

        }

        /// <summary>
        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadBangDiemThiDau()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM BangDiemThiDau";

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
                        adapter.Fill(databaseFootballManagerDataSet.BangDiemThiDau);

                        // Hiển thị dữ liệu
                        bangDiemThiDauBindingSource.DataSource = null;
                        bangDiemThiDauBindingSource.DataSource = databaseFootballManagerDataSet.BangDiemThiDau;
                        //bangDiemThiDauDataGridView.Refresh();

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
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtVongBang.Text) || String.IsNullOrEmpty(txtDoi1.Text) || String.IsNullOrEmpty(txtDoi2.Text) || String.IsNullOrEmpty(txtTySo.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo]) VALUES(@txtVongBang, @txtDoi1, @txtDoi2, @txtTySo)";

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

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@txtVongBang", txtVongBang.Text);
                        command.Parameters.AddWithValue("@txtDoi1", txtDoi1.Text);
                        command.Parameters.AddWithValue("@txtDoi2", txtDoi2.Text);
                        command.Parameters.AddWithValue("@txtTySo", txtTySo.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadBangDiemThiDau();
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
}
