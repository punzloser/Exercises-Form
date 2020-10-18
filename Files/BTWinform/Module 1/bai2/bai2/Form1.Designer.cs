namespace bai2
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
            this.btn_Clickme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Clickme
            // 
            this.btn_Clickme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Clickme.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clickme.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Clickme.Location = new System.Drawing.Point(129, 69);
            this.btn_Clickme.Name = "btn_Clickme";
            this.btn_Clickme.Size = new System.Drawing.Size(208, 79);
            this.btn_Clickme.TabIndex = 0;
            this.btn_Clickme.Text = "Click Me!";
            this.btn_Clickme.UseVisualStyleBackColor = true;
            this.btn_Clickme.Click += new System.EventHandler(this.btn_Clickme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 248);
            this.Controls.Add(this.btn_Clickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Clickme;
    }
}

