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

        /*private void TinhHieuSoBanThang()
        {
            // Lấy dữ liệu tỷ số của đội 1 và 2
            string str = txtTySo.Text;
            int tyso1 = Convert.ToInt32(str.Split('-')[0]);
            int tyso2 = Convert.ToInt32(str.Split('-')[1]);
            int hieuso = tyso1 - tyso2;
            int hieuso1 = tyso2 - tyso1;

            int diemdoi1, diemdoi2;

            // So sánh dữ liệu tỷ số đội 1 và đội 2 để tính điểm
            if (hieuso > 0)
            {
                diemdoi1 = 3;
                diemdoi2 = 0;
            } else if (hieuso == 0)
            {
                diemdoi1 = 1;
                diemdoi2 = 1;
            } else if (hieuso < 0)
            {
                diemdoi1 = 0;
                diemdoi2 = 3;
            } else
            {
                diemdoi1 = diemdoi2 = 0;
            }
        }*/

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(txtVongBang.Text) || String.IsNullOrEmpty(txtDoi1.Text) || String.IsNullOrEmpty(txtDoi2.Text) || String.IsNullOrEmpty(txtTySo.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            //TinhHieuSoBanThang();

            // Lấy dữ liệu tỷ số của đội 1 và 2
            string str = txtTySo.Text;
            int tyso1 = Convert.ToInt32(str.Split('-')[0]);
            int tyso2 = Convert.ToInt32(str.Split('-')[1]);
            string tysodao = (tyso2 + '-' + tyso1).ToString();

            int hieuso = tyso1 - tyso2;
            int hieuso1 = tyso2 - tyso1;

            int diemdoi1, diemdoi2;

            // So sánh dữ liệu tỷ số đội 1 và đội 2 để tính điểm
            if (hieuso > 0)
            {
                diemdoi1 = 3;
                diemdoi2 = 0;
            }
            else if (hieuso == 0)
            {
                diemdoi1 = 1;
                diemdoi2 = 1;
            }
            else if (hieuso < 0)
            {
                diemdoi1 = 0;
                diemdoi2 = 3;
            }
            else
            {
                diemdoi1 = diemdoi2 = 0;
            }

            // Tạo câu lệnh để thực thi đến database đối với đội 1
            string queryInsert = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [HieuSo], [Diem]) VALUES(@txtVongBang, @txtDoi1, @txtDoi2, @txtTySo, @hieuso, @diem)";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryInsert, connection))
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
                        command.Parameters.AddWithValue("@sotrandathidau", 1);
                        command.Parameters.AddWithValue("@hieuso", hieuso);
                        command.Parameters.AddWithValue("@diem", diemdoi1);

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

            // Tạo câu lệnh để thực thi đến database đối với đội 2
            string queryInsert1 = @"INSERT INTO BangDiemThiDau([TenBang], [TenDoi], [TenDoiDoiThu], [TiSo], [sotrandathidau],[HieuSo], [Diem]) VALUES(@txtVongBang, @txtDoi1, @txtDoi2, @txtTySo, @sotrandathidau, @hieuso, @diem)";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryInsert1, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@txtVongBang", txtVongBang.Text);
                        command.Parameters.AddWithValue("@txtDoi1", txtDoi2.Text);
                        command.Parameters.AddWithValue("@txtDoi2", txtDoi1.Text);
                        command.Parameters.AddWithValue("@txtTySo", tysodao);
                        command.Parameters.AddWithValue("@sotrandathidau", 1);
                        command.Parameters.AddWithValue("@hieuso", hieuso1);
                        command.Parameters.AddWithValue("@diem", diemdoi2);

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
