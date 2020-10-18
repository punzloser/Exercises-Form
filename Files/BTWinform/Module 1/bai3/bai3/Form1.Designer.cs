namespace bai3
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
            this.pnl_hoten = new System.Windows.Forms.Panel();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_holot = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.btn_holot = new System.Windows.Forms.Button();
            this.btn_ten = new System.Windows.Forms.Button();
            this.btn_hoten = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnl_hoten.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_hoten
            // 
            this.pnl_hoten.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_hoten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_hoten.CausesValidation = false;
            this.pnl_hoten.Controls.Add(this.lbl_hoten);
            this.pnl_hoten.ForeColor = System.Drawing.Color.Transparent;
            this.pnl_hoten.Location = new System.Drawing.Point(0, 0);
            this.pnl_hoten.Name = "pnl_hoten";
            this.pnl_hoten.Size = new System.Drawing.Size(431, 58);
            this.pnl_hoten.TabIndex = 0;
            this.pnl_hoten.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_hoten_Paint);
            this.pnl_hoten.DoubleClick += new System.EventHandler(this.pnl_hoten_DoubleClick);
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hoten.AutoEllipsis = true;
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.Location = new System.Drawing.Point(119, 19);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(0, 24);
            this.lbl_hoten.TabIndex = 0;
            this.lbl_hoten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_hoten.DoubleClick += new System.EventHandler(this.lbl_hoten_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ lót";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // txt_holot
            // 
            this.txt_holot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_holot.Location = new System.Drawing.Point(148, 82);
            this.txt_holot.Name = "txt_holot";
            this.txt_holot.Size = new System.Drawing.Size(167, 24);
            this.txt_holot.TabIndex = 3;
            // 
            // txt_ten
            // 
            this.txt_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten.Location = new System.Drawing.Point(148, 122);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(167, 24);
            this.txt_ten.TabIndex = 4;
            // 
            // btn_holot
            // 
            this.btn_holot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_holot.Location = new System.Drawing.Point(48, 168);
            this.btn_holot.Name = "btn_holot";
            this.btn_holot.Size = new System.Drawing.Size(75, 23);
            this.btn_holot.TabIndex = 5;
            this.btn_holot.Text = "Họ lót";
            this.btn_holot.UseVisualStyleBackColor = true;
            this.btn_holot.Click += new System.EventHandler(this.btn_holot_Click);
            // 
            // btn_ten
            // 
            this.btn_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ten.Location = new System.Drawing.Point(169, 168);
            this.btn_ten.Name = "btn_ten";
            this.btn_ten.Size = new System.Drawing.Size(75, 23);
            this.btn_ten.TabIndex = 6;
            this.btn_ten.Text = "Tên";
            this.btn_ten.UseVisualStyleBackColor = true;
            this.btn_ten.Click += new System.EventHandler(this.btn_ten_Click);
            // 
            // btn_hoten
            // 
            this.btn_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hoten.Location = new System.Drawing.Point(283, 168);
            this.btn_hoten.Name = "btn_hoten";
            this.btn_hoten.Size = new System.Drawing.Size(84, 23);
            this.btn_hoten.TabIndex = 7;
            this.btn_hoten.Text = "Họ & Tên";
            this.btn_hoten.UseVisualStyleBackColor = true;
            this.btn_hoten.Click += new System.EventHandler(this.btn_hoten_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(148, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Thoát chương trình";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 281);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_hoten);
            this.Controls.Add(this.btn_ten);
            this.Controls.Add(this.btn_holot);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.txt_holot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_hoten.ResumeLayout(false);
            this.pnl_hoten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_holot;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button btn_holot;
        private System.Windows.Forms.Button btn_ten;
        private System.Windows.Forms.Button btn_hoten;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl_hoten;
    }
}

