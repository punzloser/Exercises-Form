namespace Bai3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFrsName = new System.Windows.Forms.Label();
            this.lblLstName = new System.Windows.Forms.Label();
            this.txtFrstName = new System.Windows.Forms.TextBox();
            this.txtLstName = new System.Windows.Forms.TextBox();
            this.btnFrstName = new System.Windows.Forms.Button();
            this.btnLstName = new System.Windows.Forms.Button();
            this.btnFullName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 94);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblName.Location = new System.Drawing.Point(133, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 32);
            this.lblName.TabIndex = 0;
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblFrsName
            // 
            this.lblFrsName.AutoSize = true;
            this.lblFrsName.Location = new System.Drawing.Point(87, 136);
            this.lblFrsName.Name = "lblFrsName";
            this.lblFrsName.Size = new System.Drawing.Size(45, 17);
            this.lblFrsName.TabIndex = 1;
            this.lblFrsName.Text = "Họ lót";
            // 
            // lblLstName
            // 
            this.lblLstName.AutoSize = true;
            this.lblLstName.Location = new System.Drawing.Point(88, 187);
            this.lblLstName.Name = "lblLstName";
            this.lblLstName.Size = new System.Drawing.Size(33, 17);
            this.lblLstName.TabIndex = 1;
            this.lblLstName.Text = "Tên";
            // 
            // txtFrstName
            // 
            this.txtFrstName.Location = new System.Drawing.Point(176, 133);
            this.txtFrstName.Name = "txtFrstName";
            this.txtFrstName.Size = new System.Drawing.Size(369, 22);
            this.txtFrstName.TabIndex = 1;
            // 
            // txtLstName
            // 
            this.txtLstName.BackColor = System.Drawing.Color.LightCoral;
            this.txtLstName.Location = new System.Drawing.Point(176, 184);
            this.txtLstName.Name = "txtLstName";
            this.txtLstName.Size = new System.Drawing.Size(369, 22);
            this.txtLstName.TabIndex = 2;
            // 
            // btnFrstName
            // 
            this.btnFrstName.Location = new System.Drawing.Point(90, 259);
            this.btnFrstName.Name = "btnFrstName";
            this.btnFrstName.Size = new System.Drawing.Size(106, 30);
            this.btnFrstName.TabIndex = 3;
            this.btnFrstName.Text = "&Họ Lót";
            this.btnFrstName.UseVisualStyleBackColor = true;
            this.btnFrstName.Click += new System.EventHandler(this.btnFrstName_Click);
            // 
            // btnLstName
            // 
            this.btnLstName.Location = new System.Drawing.Point(269, 259);
            this.btnLstName.Name = "btnLstName";
            this.btnLstName.Size = new System.Drawing.Size(106, 30);
            this.btnLstName.TabIndex = 4;
            this.btnLstName.Text = "&Tên";
            this.btnLstName.UseVisualStyleBackColor = true;
            this.btnLstName.Click += new System.EventHandler(this.btnLstName_Click);
            // 
            // btnFullName
            // 
            this.btnFullName.Location = new System.Drawing.Point(439, 259);
            this.btnFullName.Name = "btnFullName";
            this.btnFullName.Size = new System.Drawing.Size(106, 30);
            this.btnFullName.TabIndex = 5;
            this.btnFullName.Text = "Họ và tên";
            this.btnFullName.UseVisualStyleBackColor = true;
            this.btnFullName.Click += new System.EventHandler(this.btnFullName_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(244, 320);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát chương trình";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 378);
            this.Controls.Add(this.btnFullName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLstName);
            this.Controls.Add(this.btnFrstName);
            this.Controls.Add(this.txtLstName);
            this.Controls.Add(this.txtFrstName);
            this.Controls.Add(this.lblLstName);
            this.Controls.Add(this.lblFrsName);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFrsName;
        private System.Windows.Forms.Label lblLstName;
        private System.Windows.Forms.TextBox txtFrstName;
        private System.Windows.Forms.TextBox txtLstName;
        private System.Windows.Forms.Button btnFrstName;
        private System.Windows.Forms.Button btnLstName;
        private System.Windows.Forms.Button btnFullName;
        private System.Windows.Forms.Button btnClose;
    }
}

