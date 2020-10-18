namespace bai4
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
            this.txtNamduong = new System.Windows.Forms.TextBox();
            this.btnDoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmlich = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm dương lịch";
            // 
            // txtNamduong
            // 
            this.txtNamduong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNamduong.Location = new System.Drawing.Point(197, 28);
            this.txtNamduong.Name = "txtNamduong";
            this.txtNamduong.Size = new System.Drawing.Size(100, 20);
            this.txtNamduong.TabIndex = 1;
            // 
            // btnDoi
            // 
            this.btnDoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoi.Location = new System.Drawing.Point(161, 76);
            this.btnDoi.Name = "btnDoi";
            this.btnDoi.Size = new System.Drawing.Size(75, 23);
            this.btnDoi.TabIndex = 2;
            this.btnDoi.Text = "Thực hiện đổi";
            this.btnDoi.UseVisualStyleBackColor = true;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm âm lịch";
            // 
            // txtAmlich
            // 
            this.txtAmlich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmlich.Location = new System.Drawing.Point(177, 128);
            this.txtAmlich.Name = "txtAmlich";
            this.txtAmlich.ReadOnly = true;
            this.txtAmlich.Size = new System.Drawing.Size(145, 20);
            this.txtAmlich.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 201);
            this.Controls.Add(this.txtAmlich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.txtNamduong);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamduong;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmlich;
    }
}

