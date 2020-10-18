namespace Module_I
{
    partial class Task1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bttSkip = new System.Windows.Forms.Button();
            this.bttDisplay = new System.Windows.Forms.Button();
            this.bttExit = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Display";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(163, 27);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // bttSkip
            // 
            this.bttSkip.Location = new System.Drawing.Point(163, 161);
            this.bttSkip.Name = "bttSkip";
            this.bttSkip.Size = new System.Drawing.Size(129, 35);
            this.bttSkip.TabIndex = 2;
            this.bttSkip.Text = "Skip";
            this.bttSkip.UseVisualStyleBackColor = true;
            this.bttSkip.Click += new System.EventHandler(this.bttSkip_Click);
            // 
            // bttDisplay
            // 
            this.bttDisplay.Location = new System.Drawing.Point(12, 161);
            this.bttDisplay.Name = "bttDisplay";
            this.bttDisplay.Size = new System.Drawing.Size(129, 35);
            this.bttDisplay.TabIndex = 2;
            this.bttDisplay.Text = "Click to Display";
            this.bttDisplay.UseVisualStyleBackColor = true;
            this.bttDisplay.Click += new System.EventHandler(this.bttDisplay_Click);
            // 
            // bttExit
            // 
            this.bttExit.Location = new System.Drawing.Point(318, 161);
            this.bttExit.Name = "bttExit";
            this.bttExit.Size = new System.Drawing.Size(129, 35);
            this.bttExit.TabIndex = 2;
            this.bttExit.Text = "Exit";
            this.bttExit.UseVisualStyleBackColor = true;
            this.bttExit.Click += new System.EventHandler(this.bttExit_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplay.Location = new System.Drawing.Point(163, 101);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(237, 32);
            this.lbDisplay.TabIndex = 3;
            this.lbDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 208);
            this.Controls.Add(this.lbDisplay);
            this.Controls.Add(this.bttDisplay);
            this.Controls.Add(this.bttExit);
            this.Controls.Add(this.bttSkip);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Using Label, Text Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button bttSkip;
        private System.Windows.Forms.Button bttDisplay;
        private System.Windows.Forms.Button bttExit;
        private System.Windows.Forms.Label lbDisplay;
    }
}