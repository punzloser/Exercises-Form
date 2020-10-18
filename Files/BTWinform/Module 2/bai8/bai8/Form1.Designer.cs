namespace bai8
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnbd2 = new System.Windows.Forms.Button();
            this.btnkt2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnbd1 = new System.Windows.Forms.Button();
            this.btnkt1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtbd1 = new System.Windows.Forms.TextBox();
            this.txtkt1 = new System.Windows.Forms.TextBox();
            this.txtbd2 = new System.Windows.Forms.TextBox();
            this.txtkt2 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.txtbd2);
            this.panel2.Controls.Add(this.txtkt2);
            this.panel2.Controls.Add(this.btnbd2);
            this.panel2.Controls.Add(this.btnkt2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 78);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(94, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dừng chương trình";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(73, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Máy 2";
            // 
            // btnbd2
            // 
            this.btnbd2.Location = new System.Drawing.Point(82, 5);
            this.btnbd2.Name = "btnbd2";
            this.btnbd2.Size = new System.Drawing.Size(75, 23);
            this.btnbd2.TabIndex = 1;
            this.btnbd2.Text = "Bắt đầu";
            this.btnbd2.UseVisualStyleBackColor = true;
            this.btnbd2.Click += new System.EventHandler(this.btnbd2_Click);
            // 
            // btnkt2
            // 
            this.btnkt2.Location = new System.Drawing.Point(82, 46);
            this.btnkt2.Name = "btnkt2";
            this.btnkt2.Size = new System.Drawing.Size(75, 23);
            this.btnkt2.TabIndex = 3;
            this.btnkt2.Text = "Kết thúc";
            this.btnkt2.UseVisualStyleBackColor = true;
            this.btnkt2.Click += new System.EventHandler(this.btnkt2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtkt1);
            this.panel3.Controls.Add(this.txtbd1);
            this.panel3.Controls.Add(this.btnbd1);
            this.panel3.Controls.Add(this.btnkt1);
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 78);
            this.panel3.TabIndex = 0;
            // 
            // btnbd1
            // 
            this.btnbd1.Location = new System.Drawing.Point(82, 5);
            this.btnbd1.Name = "btnbd1";
            this.btnbd1.Size = new System.Drawing.Size(75, 23);
            this.btnbd1.TabIndex = 0;
            this.btnbd1.Text = "Bắt đầu ";
            this.btnbd1.UseVisualStyleBackColor = true;
            this.btnbd1.Click += new System.EventHandler(this.btnbd1_Click);
            // 
            // btnkt1
            // 
            this.btnkt1.Location = new System.Drawing.Point(82, 46);
            this.btnkt1.Name = "btnkt1";
            this.btnkt1.Size = new System.Drawing.Size(75, 23);
            this.btnkt1.TabIndex = 2;
            this.btnkt1.Text = "Kết thúc";
            this.btnkt1.UseVisualStyleBackColor = true;
            this.btnkt1.Click += new System.EventHandler(this.btnkt1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(73, 69);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Máy 1";
            // 
            // txtbd1
            // 
            this.txtbd1.Location = new System.Drawing.Point(163, 7);
            this.txtbd1.Name = "txtbd1";
            this.txtbd1.ReadOnly = true;
            this.txtbd1.Size = new System.Drawing.Size(119, 20);
            this.txtbd1.TabIndex = 5;
            // 
            // txtkt1
            // 
            this.txtkt1.Location = new System.Drawing.Point(163, 49);
            this.txtkt1.Name = "txtkt1";
            this.txtkt1.ReadOnly = true;
            this.txtkt1.Size = new System.Drawing.Size(119, 20);
            this.txtkt1.TabIndex = 6;
            // 
            // txtbd2
            // 
            this.txtbd2.Location = new System.Drawing.Point(163, 8);
            this.txtbd2.Name = "txtbd2";
            this.txtbd2.ReadOnly = true;
            this.txtbd2.Size = new System.Drawing.Size(119, 20);
            this.txtbd2.TabIndex = 7;
            // 
            // txtkt2
            // 
            this.txtkt2.Location = new System.Drawing.Point(163, 46);
            this.txtkt2.Name = "txtkt2";
            this.txtkt2.ReadOnly = true;
            this.txtkt2.Size = new System.Drawing.Size(119, 20);
            this.txtkt2.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnbd1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(328, 254);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbd2;
        private System.Windows.Forms.TextBox txtkt2;
        private System.Windows.Forms.Button btnbd2;
        private System.Windows.Forms.Button btnkt2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtkt1;
        private System.Windows.Forms.TextBox txtbd1;
        private System.Windows.Forms.Button btnbd1;
        private System.Windows.Forms.Button btnkt1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

