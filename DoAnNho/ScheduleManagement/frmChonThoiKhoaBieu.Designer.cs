namespace ScheduleManagement
{
    partial class frmChonThoiKhoaBieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonThoiKhoaBieu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbBuoi = new System.Windows.Forms.ComboBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.cbbMaMon = new System.Windows.Forms.ComboBox();
            this.cbbMaLop = new System.Windows.Forms.ComboBox();
            this.cbbChonGV = new System.Windows.Forms.ComboBox();
            this.cbbMaGV = new System.Windows.Forms.ComboBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.lbMaLop = new System.Windows.Forms.Label();
            this.lbMaGV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 35);
            this.panel1.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(326, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(534, 354);
            this.panel4.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "XẾP THỜI KHÓA BIỂU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbBuoi);
            this.groupBox1.Controls.Add(this.cbbMaPhong);
            this.groupBox1.Controls.Add(this.cbbMaMon);
            this.groupBox1.Controls.Add(this.cbbMaLop);
            this.groupBox1.Controls.Add(this.cbbChonGV);
            this.groupBox1.Controls.Add(this.cbbMaGV);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbMaPhong);
            this.groupBox1.Controls.Add(this.lbMaMon);
            this.groupBox1.Controls.Add(this.lbMaLop);
            this.groupBox1.Controls.Add(this.lbMaGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 351);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // cbbBuoi
            // 
            this.cbbBuoi.FormattingEnabled = true;
            this.cbbBuoi.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbbBuoi.Location = new System.Drawing.Point(80, 250);
            this.cbbBuoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbBuoi.Name = "cbbBuoi";
            this.cbbBuoi.Size = new System.Drawing.Size(59, 21);
            this.cbbBuoi.TabIndex = 6;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(80, 213);
            this.cbbMaPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(59, 21);
            this.cbbMaPhong.TabIndex = 6;
            this.cbbMaPhong.SelectedIndexChanged += new System.EventHandler(this.cbbMaPhong_SelectedIndexChanged);
            // 
            // cbbMaMon
            // 
            this.cbbMaMon.FormattingEnabled = true;
            this.cbbMaMon.Location = new System.Drawing.Point(80, 175);
            this.cbbMaMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaMon.Name = "cbbMaMon";
            this.cbbMaMon.Size = new System.Drawing.Size(59, 21);
            this.cbbMaMon.TabIndex = 6;
            this.cbbMaMon.SelectedIndexChanged += new System.EventHandler(this.cbbMaMon_SelectedIndexChanged);
            // 
            // cbbMaLop
            // 
            this.cbbMaLop.FormattingEnabled = true;
            this.cbbMaLop.Location = new System.Drawing.Point(80, 136);
            this.cbbMaLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaLop.Name = "cbbMaLop";
            this.cbbMaLop.Size = new System.Drawing.Size(59, 21);
            this.cbbMaLop.TabIndex = 6;
            this.cbbMaLop.SelectedIndexChanged += new System.EventHandler(this.cbbMaLop_SelectedIndexChanged);
            // 
            // cbbChonGV
            // 
            this.cbbChonGV.FormattingEnabled = true;
            this.cbbChonGV.Location = new System.Drawing.Point(176, 65);
            this.cbbChonGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbChonGV.Name = "cbbChonGV";
            this.cbbChonGV.Size = new System.Drawing.Size(137, 21);
            this.cbbChonGV.TabIndex = 6;
            this.cbbChonGV.SelectedIndexChanged += new System.EventHandler(this.cbbChonGV_SelectedIndexChanged);
            // 
            // cbbMaGV
            // 
            this.cbbMaGV.FormattingEnabled = true;
            this.cbbMaGV.Location = new System.Drawing.Point(80, 104);
            this.cbbMaGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbMaGV.Name = "cbbMaGV";
            this.cbbMaGV.Size = new System.Drawing.Size(59, 21);
            this.cbbMaGV.TabIndex = 6;
            this.cbbMaGV.SelectedIndexChanged += new System.EventHandler(this.cbbMaGV_SelectedIndexChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(79, 25);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(157, 20);
            this.dtpNgay.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Buổi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chọn GV";
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhong.Location = new System.Drawing.Point(142, 216);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(10, 15);
            this.lbMaPhong.TabIndex = 2;
            this.lbMaPhong.Text = " ";
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaMon.Location = new System.Drawing.Point(142, 179);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(10, 15);
            this.lbMaMon.TabIndex = 2;
            this.lbMaMon.Text = " ";
            // 
            // lbMaLop
            // 
            this.lbMaLop.AutoSize = true;
            this.lbMaLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLop.Location = new System.Drawing.Point(142, 140);
            this.lbMaLop.Name = "lbMaLop";
            this.lbMaLop.Size = new System.Drawing.Size(10, 15);
            this.lbMaLop.TabIndex = 2;
            this.lbMaLop.Text = " ";
            // 
            // lbMaGV
            // 
            this.lbMaGV.AutoSize = true;
            this.lbMaGV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaGV.Location = new System.Drawing.Point(142, 108);
            this.lbMaGV.Name = "lbMaGV";
            this.lbMaGV.Size = new System.Drawing.Size(10, 15);
            this.lbMaGV.TabIndex = 2;
            this.lbMaGV.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã GV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(327, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 40);
            this.panel3.TabIndex = 32;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(441, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(236, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(71, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(160, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(76, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(87, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(73, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(87, 38);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(327, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 307);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Nhập Liệu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(527, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // frmChonThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChonThoiKhoaBieu";
            this.Text = "XẾP THỜI KHÓA BIỂU";
            this.Load += new System.EventHandler(this.frmChonThoiKhoaBieu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbBuoi;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.ComboBox cbbMaMon;
        private System.Windows.Forms.ComboBox cbbMaLop;
        private System.Windows.Forms.ComboBox cbbMaGV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbChonGV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.Label lbMaMon;
        private System.Windows.Forms.Label lbMaLop;
        private System.Windows.Forms.Label lbMaGV;
    }
}