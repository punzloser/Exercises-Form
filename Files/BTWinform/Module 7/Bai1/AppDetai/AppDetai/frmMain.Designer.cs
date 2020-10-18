namespace AppDetai
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiDT = new System.Windows.Forms.ComboBox();
            this.loaiDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new AppDetai.DataSet1();
            this.txtTenDT = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtGVHD = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGVHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet11 = new AppDetai.DataSet1();
            this.loaiDTTableAdapter = new AppDetai.DataSet1TableAdapters.LoaiDTTableAdapter();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detaiTableAdapter = new AppDetai.DataSet1TableAdapters.detaiTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loaiDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(215, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÀN HÌNH NHẬP ĐỀ TÀI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn loại đề tài:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên đề tài:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên giáo viên HD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Danh sách đề tài";
            // 
            // cbLoaiDT
            // 
            this.cbLoaiDT.DataSource = this.loaiDTBindingSource;
            this.cbLoaiDT.DisplayMember = "TenLoaiDeTai";
            this.cbLoaiDT.FormattingEnabled = true;
            this.cbLoaiDT.Location = new System.Drawing.Point(375, 141);
            this.cbLoaiDT.Name = "cbLoaiDT";
            this.cbLoaiDT.Size = new System.Drawing.Size(121, 24);
            this.cbLoaiDT.TabIndex = 2;
            this.cbLoaiDT.ValueMember = "MaLoaiDT";
            this.cbLoaiDT.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDT_SelectedIndexChanged);
            // 
            // loaiDTBindingSource
            // 
            this.loaiDTBindingSource.DataMember = "LoaiDT";
            this.loaiDTBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenDT
            // 
            this.txtTenDT.Location = new System.Drawing.Point(375, 180);
            this.txtTenDT.Name = "txtTenDT";
            this.txtTenDT.Size = new System.Drawing.Size(356, 22);
            this.txtTenDT.TabIndex = 3;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(375, 210);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(121, 22);
            this.txtDiem.TabIndex = 3;
            // 
            // txtGVHD
            // 
            this.txtGVHD.Location = new System.Drawing.Point(375, 242);
            this.txtGVHD.Name = "txtGVHD";
            this.txtGVHD.Size = new System.Drawing.Size(356, 22);
            this.txtGVHD.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDTDataGridViewTextBoxColumn,
            this.tenDTDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.tenGVHDDataGridViewTextBoxColumn,
            this.maLoaiDTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.detaiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(100, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 175);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // maDTDataGridViewTextBoxColumn
            // 
            this.maDTDataGridViewTextBoxColumn.DataPropertyName = "MaDT";
            this.maDTDataGridViewTextBoxColumn.HeaderText = "Mã đề tài";
            this.maDTDataGridViewTextBoxColumn.Name = "maDTDataGridViewTextBoxColumn";
            this.maDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDTDataGridViewTextBoxColumn
            // 
            this.tenDTDataGridViewTextBoxColumn.DataPropertyName = "TenDT";
            this.tenDTDataGridViewTextBoxColumn.HeaderText = "Tên đề tài";
            this.tenDTDataGridViewTextBoxColumn.Name = "tenDTDataGridViewTextBoxColumn";
            this.tenDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "diem";
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            this.diemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGVHDDataGridViewTextBoxColumn
            // 
            this.tenGVHDDataGridViewTextBoxColumn.DataPropertyName = "TenGVHD";
            this.tenGVHDDataGridViewTextBoxColumn.HeaderText = "Giáo viên HD";
            this.tenGVHDDataGridViewTextBoxColumn.Name = "tenGVHDDataGridViewTextBoxColumn";
            this.tenGVHDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLoaiDTDataGridViewTextBoxColumn
            // 
            this.maLoaiDTDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiDT";
            this.maLoaiDTDataGridViewTextBoxColumn.HeaderText = "Mã loại DT";
            this.maLoaiDTDataGridViewTextBoxColumn.Name = "maLoaiDTDataGridViewTextBoxColumn";
            this.maLoaiDTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detaiBindingSource
            // 
            this.detaiBindingSource.DataMember = "detai";
            this.detaiBindingSource.DataSource = this.dataSet11;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiDTTableAdapter
            // 
            this.loaiDTTableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(18, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 33);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(149, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 33);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(277, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 33);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(12, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 33);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(143, 10);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 33);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(773, 526);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 33);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Location = new System.Drawing.Point(82, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 60);
            this.panel1.TabIndex = 6;
            // 
            // detaiTableAdapter
            // 
            this.detaiTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Location = new System.Drawing.Point(502, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 57);
            this.panel2.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(514, 208);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 22);
            this.txtID.TabIndex = 3;
            this.txtID.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtGVHD);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtTenDT);
            this.Controls.Add(this.cbLoaiDT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình nhập đề tài";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loaiDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiDT;
        private System.Windows.Forms.TextBox txtTenDT;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtGVHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource loaiDTBindingSource;
        private DataSet1TableAdapters.LoaiDTTableAdapter loaiDTTableAdapter;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource detaiBindingSource;
        private DataSet1TableAdapters.detaiTableAdapter detaiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGVHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtID;
    }
}

