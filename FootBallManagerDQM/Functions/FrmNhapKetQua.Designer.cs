namespace FootBallManagerDQM.Functions
{
    partial class FrmNhapKetQua
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapKetQua));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVongBang = new System.Windows.Forms.Label();
            this.txtVongBang = new System.Windows.Forms.TextBox();
            this.lblDoi1 = new System.Windows.Forms.Label();
            this.txtDoi1 = new System.Windows.Forms.TextBox();
            this.lblDoi2 = new System.Windows.Forms.Label();
            this.txtDoi2 = new System.Windows.Forms.TextBox();
            this.lblTySo = new System.Windows.Forms.Label();
            this.txtTySo = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.databaseFootballManagerDataSet = new FootBallManagerDQM.DatabaseFootballManagerDataSet();
            this.bangDiemThiDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangDiemThiDauTableAdapter = new FootBallManagerDQM.DatabaseFootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter();
            this.tableAdapterManager = new FootBallManagerDQM.DatabaseFootballManagerDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseFootballManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblVongBang
            // 
            this.lblVongBang.AutoSize = true;
            this.lblVongBang.Location = new System.Drawing.Point(217, 9);
            this.lblVongBang.Name = "lblVongBang";
            this.lblVongBang.Size = new System.Drawing.Size(62, 13);
            this.lblVongBang.TabIndex = 1;
            this.lblVongBang.Text = "Vòng bảng:";
            // 
            // txtVongBang
            // 
            this.txtVongBang.Location = new System.Drawing.Point(285, 6);
            this.txtVongBang.Name = "txtVongBang";
            this.txtVongBang.Size = new System.Drawing.Size(223, 20);
            this.txtVongBang.TabIndex = 2;
            // 
            // lblDoi1
            // 
            this.lblDoi1.AutoSize = true;
            this.lblDoi1.Location = new System.Drawing.Point(217, 35);
            this.lblDoi1.Name = "lblDoi1";
            this.lblDoi1.Size = new System.Drawing.Size(68, 13);
            this.lblDoi1.TabIndex = 1;
            this.lblDoi1.Text = "Đội thứ nhất:";
            // 
            // txtDoi1
            // 
            this.txtDoi1.Location = new System.Drawing.Point(285, 32);
            this.txtDoi1.Name = "txtDoi1";
            this.txtDoi1.Size = new System.Drawing.Size(223, 20);
            this.txtDoi1.TabIndex = 2;
            // 
            // lblDoi2
            // 
            this.lblDoi2.AutoSize = true;
            this.lblDoi2.Location = new System.Drawing.Point(217, 61);
            this.lblDoi2.Name = "lblDoi2";
            this.lblDoi2.Size = new System.Drawing.Size(61, 13);
            this.lblDoi2.TabIndex = 1;
            this.lblDoi2.Text = "Đội thứ hai:";
            this.lblDoi2.Click += new System.EventHandler(this.lblDoi2_Click);
            // 
            // txtDoi2
            // 
            this.txtDoi2.Location = new System.Drawing.Point(285, 58);
            this.txtDoi2.Name = "txtDoi2";
            this.txtDoi2.Size = new System.Drawing.Size(223, 20);
            this.txtDoi2.TabIndex = 2;
            this.txtDoi2.TextChanged += new System.EventHandler(this.txtDoi2_TextChanged);
            // 
            // lblTySo
            // 
            this.lblTySo.AutoSize = true;
            this.lblTySo.Location = new System.Drawing.Point(217, 87);
            this.lblTySo.Name = "lblTySo";
            this.lblTySo.Size = new System.Drawing.Size(36, 13);
            this.lblTySo.TabIndex = 1;
            this.lblTySo.Text = "Tỷ số:";
            this.lblTySo.Click += new System.EventHandler(this.lblDoi2_Click);
            // 
            // txtTySo
            // 
            this.txtTySo.Location = new System.Drawing.Point(285, 84);
            this.txtTySo.Name = "txtTySo";
            this.txtTySo.Size = new System.Drawing.Size(223, 20);
            this.txtTySo.TabIndex = 2;
            this.txtTySo.TextChanged += new System.EventHandler(this.txtDoi2_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.Location = new System.Drawing.Point(353, 110);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(434, 110);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // databaseFootballManagerDataSet
            // 
            this.databaseFootballManagerDataSet.DataSetName = "DatabaseFootballManagerDataSet";
            this.databaseFootballManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangDiemThiDauBindingSource
            // 
            this.bangDiemThiDauBindingSource.DataMember = "BangDiemThiDau";
            this.bangDiemThiDauBindingSource.DataSource = this.databaseFootballManagerDataSet;
            // 
            // bangDiemThiDauTableAdapter
            // 
            this.bangDiemThiDauTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangDiemThiDauTableAdapter = this.bangDiemThiDauTableAdapter;
            this.tableAdapterManager.UpdateOrder = FootBallManagerDQM.DatabaseFootballManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmNhapKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 139);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTySo);
            this.Controls.Add(this.lblTySo);
            this.Controls.Add(this.txtDoi2);
            this.Controls.Add(this.lblDoi2);
            this.Controls.Add(this.txtDoi1);
            this.Controls.Add(this.lblDoi1);
            this.Controls.Add(this.txtVongBang);
            this.Controls.Add(this.lblVongBang);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNhapKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Kết Quả Trận Đấu";
            this.Load += new System.EventHandler(this.FrmNhapKetQua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseFootballManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangDiemThiDauBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVongBang;
        private System.Windows.Forms.TextBox txtVongBang;
        private System.Windows.Forms.Label lblDoi1;
        private System.Windows.Forms.TextBox txtDoi1;
        private System.Windows.Forms.Label lblDoi2;
        private System.Windows.Forms.TextBox txtDoi2;
        private System.Windows.Forms.Label lblTySo;
        private System.Windows.Forms.TextBox txtTySo;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private DatabaseFootballManagerDataSet databaseFootballManagerDataSet;
        private System.Windows.Forms.BindingSource bangDiemThiDauBindingSource;
        private DatabaseFootballManagerDataSetTableAdapters.BangDiemThiDauTableAdapter bangDiemThiDauTableAdapter;
        private DatabaseFootballManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}