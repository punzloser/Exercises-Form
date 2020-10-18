namespace WindowsFormsApp1
{
    partial class Task2
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
            this.bttClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttClick
            // 
            this.bttClick.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttClick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bttClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClick.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttClick.ForeColor = System.Drawing.Color.Red;
            this.bttClick.Location = new System.Drawing.Point(51, 42);
            this.bttClick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttClick.Name = "bttClick";
            this.bttClick.Size = new System.Drawing.Size(245, 114);
            this.bttClick.TabIndex = 0;
            this.bttClick.Text = "Click Me";
            this.bttClick.UseVisualStyleBackColor = false;
            this.bttClick.Click += new System.EventHandler(this.bttClick_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.bttClick);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Task2";
            this.Text = "Simple Event Example";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttClick;
    }
}