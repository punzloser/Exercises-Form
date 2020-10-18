namespace Bai_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtXuat = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnInHoa = new System.Windows.Forms.Button();
            this.btnInThuong = new System.Windows.Forms.Button();
            this.btnDemChuThuong = new System.Windows.Forms.Button();
            this.btnDemChuHoa = new System.Windows.Forms.Button();
            this.btnDemSoTuMoiDong = new System.Windows.Forms.Button();
            this.btnDemSoTu = new System.Windows.Forms.Button();
            this.btnInNguyenPhuAm = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "SỬ DỤNG CÁC HÀM XỬ LÝ CHUỖI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(29, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 184);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(18, 32);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNhap.Size = new System.Drawing.Size(220, 133);
            this.txtNhap.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtXuat);
            this.groupBox2.Location = new System.Drawing.Point(326, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // txtXuat
            // 
            this.txtXuat.Location = new System.Drawing.Point(21, 32);
            this.txtXuat.Multiline = true;
            this.txtXuat.Name = "txtXuat";
            this.txtXuat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXuat.Size = new System.Drawing.Size(220, 133);
            this.txtXuat.TabIndex = 4;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(29, 275);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(256, 30);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập dữ liệu";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnInHoa
            // 
            this.btnInHoa.Location = new System.Drawing.Point(29, 322);
            this.btnInHoa.Name = "btnInHoa";
            this.btnInHoa.Size = new System.Drawing.Size(256, 30);
            this.btnInHoa.TabIndex = 2;
            this.btnInHoa.Text = "In chữ hoa";
            this.btnInHoa.UseVisualStyleBackColor = true;
            this.btnInHoa.Click += new System.EventHandler(this.btnInHoa_Click);
            // 
            // btnInThuong
            // 
            this.btnInThuong.Location = new System.Drawing.Point(29, 371);
            this.btnInThuong.Name = "btnInThuong";
            this.btnInThuong.Size = new System.Drawing.Size(256, 30);
            this.btnInThuong.TabIndex = 2;
            this.btnInThuong.Text = "In chữ thường";
            this.btnInThuong.UseVisualStyleBackColor = true;
            this.btnInThuong.Click += new System.EventHandler(this.btnInThuong_Click);
            // 
            // btnDemChuThuong
            // 
            this.btnDemChuThuong.Location = new System.Drawing.Point(29, 427);
            this.btnDemChuThuong.Name = "btnDemChuThuong";
            this.btnDemChuThuong.Size = new System.Drawing.Size(256, 30);
            this.btnDemChuThuong.TabIndex = 2;
            this.btnDemChuThuong.Text = "Đếm số ký tự thường";
            this.btnDemChuThuong.UseVisualStyleBackColor = true;
            this.btnDemChuThuong.Click += new System.EventHandler(this.btnDemChuThuong_Click);
            // 
            // btnDemChuHoa
            // 
            this.btnDemChuHoa.Location = new System.Drawing.Point(326, 275);
            this.btnDemChuHoa.Name = "btnDemChuHoa";
            this.btnDemChuHoa.Size = new System.Drawing.Size(256, 30);
            this.btnDemChuHoa.TabIndex = 2;
            this.btnDemChuHoa.Text = "Đếm số ký tự hoa";
            this.btnDemChuHoa.UseVisualStyleBackColor = true;
            this.btnDemChuHoa.Click += new System.EventHandler(this.btnDemChuHoa_Click);
            // 
            // btnDemSoTuMoiDong
            // 
            this.btnDemSoTuMoiDong.Location = new System.Drawing.Point(326, 322);
            this.btnDemSoTuMoiDong.Name = "btnDemSoTuMoiDong";
            this.btnDemSoTuMoiDong.Size = new System.Drawing.Size(256, 30);
            this.btnDemSoTuMoiDong.TabIndex = 2;
            this.btnDemSoTuMoiDong.Text = "In số từ trên mỗi dong";
            this.btnDemSoTuMoiDong.UseVisualStyleBackColor = true;
            this.btnDemSoTuMoiDong.Click += new System.EventHandler(this.btnDemSoTuMoiDong_Click);
            // 
            // btnDemSoTu
            // 
            this.btnDemSoTu.Location = new System.Drawing.Point(326, 371);
            this.btnDemSoTu.Name = "btnDemSoTu";
            this.btnDemSoTu.Size = new System.Drawing.Size(256, 30);
            this.btnDemSoTu.TabIndex = 2;
            this.btnDemSoTu.Text = "Đếm sô từ";
            this.btnDemSoTu.UseVisualStyleBackColor = true;
            this.btnDemSoTu.Click += new System.EventHandler(this.btnDemSoTu_Click);
            // 
            // btnInNguyenPhuAm
            // 
            this.btnInNguyenPhuAm.Location = new System.Drawing.Point(326, 427);
            this.btnInNguyenPhuAm.Name = "btnInNguyenPhuAm";
            this.btnInNguyenPhuAm.Size = new System.Drawing.Size(256, 30);
            this.btnInNguyenPhuAm.TabIndex = 2;
            this.btnInNguyenPhuAm.Text = "In nguyên âm, phụ âm";
            this.btnInNguyenPhuAm.UseVisualStyleBackColor = true;
            this.btnInNguyenPhuAm.Click += new System.EventHandler(this.btnInNguyenPhuAm_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(29, 476);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(553, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Kết thúc";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 509);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInNguyenPhuAm);
            this.Controls.Add(this.btnDemChuThuong);
            this.Controls.Add(this.btnDemSoTu);
            this.Controls.Add(this.btnInThuong);
            this.Controls.Add(this.btnDemSoTuMoiDong);
            this.Controls.Add(this.btnInHoa);
            this.Controls.Add(this.btnDemChuHoa);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtXuat;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnInHoa;
        private System.Windows.Forms.Button btnInThuong;
        private System.Windows.Forms.Button btnDemChuThuong;
        private System.Windows.Forms.Button btnDemChuHoa;
        private System.Windows.Forms.Button btnDemSoTuMoiDong;
        private System.Windows.Forms.Button btnDemSoTu;
        private System.Windows.Forms.Button btnInNguyenPhuAm;
        private System.Windows.Forms.Button btnThoat;
    }
}

