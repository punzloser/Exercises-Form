namespace bai1
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnDemle = new System.Windows.Forms.Button();
            this.btnTongle = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnTang2 = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnGiam = new System.Windows.Forms.Button();
            this.grbMang = new System.Windows.Forms.GroupBox();
            this.grbKetqua = new System.Windows.Forms.GroupBox();
            this.txtMang = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.grbMang.SuspendLayout();
            this.grbKetqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(34, 142);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(152, 23);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Xuất mảng ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(34, 186);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(152, 23);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tính tổng giá trị mảng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnDemle
            // 
            this.btnDemle.Location = new System.Drawing.Point(34, 233);
            this.btnDemle.Name = "btnDemle";
            this.btnDemle.Size = new System.Drawing.Size(152, 23);
            this.btnDemle.TabIndex = 6;
            this.btnDemle.Text = "Đếm số phần tử lẻ";
            this.btnDemle.UseVisualStyleBackColor = true;
            this.btnDemle.Click += new System.EventHandler(this.btnDemle_Click);
            // 
            // btnTongle
            // 
            this.btnTongle.Location = new System.Drawing.Point(34, 275);
            this.btnTongle.Name = "btnTongle";
            this.btnTongle.Size = new System.Drawing.Size(152, 23);
            this.btnTongle.TabIndex = 7;
            this.btnTongle.Text = "Tổng giá trị phần tử lẻ";
            this.btnTongle.UseVisualStyleBackColor = true;
            this.btnTongle.Click += new System.EventHandler(this.btnTongle_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(270, 142);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(156, 23);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnTang2
            // 
            this.btnTang2.Location = new System.Drawing.Point(270, 186);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new System.Drawing.Size(156, 23);
            this.btnTang2.TabIndex = 10;
            this.btnTang2.Text = "Tăng mỗi phần tử mảng lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;
            this.btnTang2.Click += new System.EventHandler(this.btnTang2_Click);
            // 
            // btnTang
            // 
            this.btnTang.Location = new System.Drawing.Point(270, 233);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(156, 23);
            this.btnTang.TabIndex = 9;
            this.btnTang.Text = "Sắp mảng tăng";
            this.btnTang.UseVisualStyleBackColor = true;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnGiam
            // 
            this.btnGiam.Location = new System.Drawing.Point(270, 275);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(156, 23);
            this.btnGiam.TabIndex = 8;
            this.btnGiam.Text = "Sắp mảng giảm";
            this.btnGiam.UseVisualStyleBackColor = true;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // grbMang
            // 
            this.grbMang.Controls.Add(this.txtMang);
            this.grbMang.Location = new System.Drawing.Point(27, 13);
            this.grbMang.Name = "grbMang";
            this.grbMang.Size = new System.Drawing.Size(405, 48);
            this.grbMang.TabIndex = 12;
            this.grbMang.TabStop = false;
            this.grbMang.Text = "Mảng gốc";
            // 
            // grbKetqua
            // 
            this.grbKetqua.Controls.Add(this.txtKetqua);
            this.grbKetqua.Location = new System.Drawing.Point(27, 77);
            this.grbKetqua.Name = "grbKetqua";
            this.grbKetqua.Size = new System.Drawing.Size(405, 48);
            this.grbKetqua.TabIndex = 13;
            this.grbKetqua.TabStop = false;
            this.grbKetqua.Text = "Kết quả";
            // 
            // txtMang
            // 
            this.txtMang.Location = new System.Drawing.Point(7, 20);
            this.txtMang.Name = "txtMang";
            this.txtMang.Size = new System.Drawing.Size(392, 20);
            this.txtMang.TabIndex = 0;
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(7, 19);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(392, 20);
            this.txtKetqua.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 320);
            this.Controls.Add(this.grbKetqua);
            this.Controls.Add(this.grbMang);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnTang);
            this.Controls.Add(this.btnGiam);
            this.Controls.Add(this.btnTongle);
            this.Controls.Add(this.btnDemle);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbMang.ResumeLayout(false);
            this.grbMang.PerformLayout();
            this.grbKetqua.ResumeLayout(false);
            this.grbKetqua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnDemle;
        private System.Windows.Forms.Button btnTongle;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnTang2;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnGiam;
        private System.Windows.Forms.GroupBox grbMang;
        private System.Windows.Forms.TextBox txtMang;
        private System.Windows.Forms.GroupBox grbKetqua;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}

