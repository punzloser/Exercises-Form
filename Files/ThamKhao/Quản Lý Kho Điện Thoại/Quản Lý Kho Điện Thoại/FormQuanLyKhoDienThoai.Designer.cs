namespace Quản_Lý_Kho_Điện_Thoại
{
    partial class FormQuanLyKhoDienThoai
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
            this.comboBoxHang = new System.Windows.Forms.ComboBox();
            this.hangSXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhoDienThoaiDataSet = new Quản_Lý_Kho_Điện_Thoại.QuanLyKhoDienThoaiDataSet();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderMa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTenDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCapNhat = new System.Windows.Forms.Button();
            this.checkBoxCapNhatGia = new System.Windows.Forms.CheckBox();
            this.textBoxSoLuongTon = new System.Windows.Forms.TextBox();
            this.textBoxGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.hangSXTableAdapter = new Quản_Lý_Kho_Điện_Thoại.QuanLyKhoDienThoaiDataSetTableAdapters.HangSXTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangSXBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDienThoaiDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn hãng:";
            // 
            // comboBoxHang
            // 
            this.comboBoxHang.DataSource = this.hangSXBindingSource;
            this.comboBoxHang.DisplayMember = "TenHang";
            this.comboBoxHang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxHang.FormattingEnabled = true;
            this.comboBoxHang.Location = new System.Drawing.Point(123, 6);
            this.comboBoxHang.Name = "comboBoxHang";
            this.comboBoxHang.Size = new System.Drawing.Size(415, 44);
            this.comboBoxHang.TabIndex = 1;
            this.comboBoxHang.SelectedIndexChanged += new System.EventHandler(this.comboBoxHang_SelectedIndexChanged);
            // 
            // hangSXBindingSource
            // 
            this.hangSXBindingSource.DataMember = "HangSX";
            this.hangSXBindingSource.DataSource = this.quanLyKhoDienThoaiDataSet;
            // 
            // quanLyKhoDienThoaiDataSet
            // 
            this.quanLyKhoDienThoaiDataSet.DataSetName = "QuanLyKhoDienThoaiDataSet";
            this.quanLyKhoDienThoaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderMa,
            this.columnHeaderTenDT,
            this.columnHeaderGia,
            this.columnHeaderTon});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 50);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(526, 219);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            // 
            // columnHeaderMa
            // 
            this.columnHeaderMa.Text = "Mã";
            this.columnHeaderMa.Width = 90;
            // 
            // columnHeaderTenDT
            // 
            this.columnHeaderTenDT.Text = "Tên Dòng Điện Thoại";
            this.columnHeaderTenDT.Width = 215;
            // 
            // columnHeaderGia
            // 
            this.columnHeaderGia.Text = "Đơn Giá";
            this.columnHeaderGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderGia.Width = 127;
            // 
            // columnHeaderTon
            // 
            this.columnHeaderTon.Text = "Tồn Kho";
            this.columnHeaderTon.Width = 87;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCapNhat);
            this.groupBox1.Controls.Add(this.checkBoxCapNhatGia);
            this.groupBox1.Controls.Add(this.textBoxSoLuongTon);
            this.groupBox1.Controls.Add(this.textBoxGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật giá - Tồn kho";
            // 
            // buttonCapNhat
            // 
            this.buttonCapNhat.Location = new System.Drawing.Point(388, 83);
            this.buttonCapNhat.Name = "buttonCapNhat";
            this.buttonCapNhat.Size = new System.Drawing.Size(138, 44);
            this.buttonCapNhat.TabIndex = 3;
            this.buttonCapNhat.Text = "Cập Nhật";
            this.buttonCapNhat.UseVisualStyleBackColor = true;
            this.buttonCapNhat.Click += new System.EventHandler(this.buttonCapNhat_Click);
            // 
            // checkBoxCapNhatGia
            // 
            this.checkBoxCapNhatGia.AutoSize = true;
            this.checkBoxCapNhatGia.Location = new System.Drawing.Point(388, 44);
            this.checkBoxCapNhatGia.Name = "checkBoxCapNhatGia";
            this.checkBoxCapNhatGia.Size = new System.Drawing.Size(199, 40);
            this.checkBoxCapNhatGia.TabIndex = 2;
            this.checkBoxCapNhatGia.Text = "Cập nhật giá";
            this.checkBoxCapNhatGia.UseVisualStyleBackColor = true;
            this.checkBoxCapNhatGia.CheckedChanged += new System.EventHandler(this.checkBoxCapNhatGia_CheckedChanged);
            // 
            // textBoxSoLuongTon
            // 
            this.textBoxSoLuongTon.Location = new System.Drawing.Point(135, 83);
            this.textBoxSoLuongTon.Name = "textBoxSoLuongTon";
            this.textBoxSoLuongTon.ReadOnly = true;
            this.textBoxSoLuongTon.Size = new System.Drawing.Size(233, 44);
            this.textBoxSoLuongTon.TabIndex = 1;
            // 
            // textBoxGia
            // 
            this.textBoxGia.Location = new System.Drawing.Point(135, 41);
            this.textBoxGia.Name = "textBoxGia";
            this.textBoxGia.ReadOnly = true;
            this.textBoxGia.Size = new System.Drawing.Size(233, 44);
            this.textBoxGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng tồn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonXoa);
            this.groupBox2.Location = new System.Drawing.Point(12, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 65);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngừng bán điện thoại";
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(271, 27);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(249, 32);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa dòng điện thoại";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // hangSXTableAdapter
            // 
            this.hangSXTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Số Lượng Dòng Điện Thoại: ";
            // 
            // FormQuanLyKhoDienThoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.comboBoxHang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormQuanLyKhoDienThoai";
            this.Text = "FormQuanLyKhoDienThoai";
            this.Load += new System.EventHandler(this.FormQuanLyKhoDienThoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangSXBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhoDienThoaiDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHang;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderMa;
        private System.Windows.Forms.ColumnHeader columnHeaderTenDT;
        private System.Windows.Forms.ColumnHeader columnHeaderGia;
        private System.Windows.Forms.ColumnHeader columnHeaderTon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCapNhat;
        private System.Windows.Forms.CheckBox checkBoxCapNhatGia;
        private System.Windows.Forms.TextBox textBoxSoLuongTon;
        private System.Windows.Forms.TextBox textBoxGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonXoa;
        private QuanLyKhoDienThoaiDataSet quanLyKhoDienThoaiDataSet;
        private System.Windows.Forms.BindingSource hangSXBindingSource;
        private QuanLyKhoDienThoaiDataSetTableAdapters.HangSXTableAdapter hangSXTableAdapter;
        private System.Windows.Forms.Label label4;
    }
}