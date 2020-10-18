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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMile = new System.Windows.Forms.TextBox();
            this.txtGallon = new System.Windows.Forms.TextBox();
            this.txtCalculator = new System.Windows.Forms.TextBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mileage Efficieny Calculator";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miles Driven:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gallons of gas used:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "efficieny (Miles/Gallons):";
            // 
            // txtMile
            // 
            this.txtMile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMile.Location = new System.Drawing.Point(150, 58);
            this.txtMile.Name = "txtMile";
            this.txtMile.Size = new System.Drawing.Size(115, 20);
            this.txtMile.TabIndex = 0;
            this.txtMile.TextChanged += new System.EventHandler(this.txtMile_TextChanged);
            this.txtMile.Validating += new System.ComponentModel.CancelEventHandler(this.txtMile_Validating);
            // 
            // txtGallon
            // 
            this.txtGallon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGallon.Location = new System.Drawing.Point(150, 91);
            this.txtGallon.Name = "txtGallon";
            this.txtGallon.Size = new System.Drawing.Size(115, 20);
            this.txtGallon.TabIndex = 1;
            this.txtGallon.TextChanged += new System.EventHandler(this.txtGallon_TextChanged);
            this.txtGallon.Validating += new System.ComponentModel.CancelEventHandler(this.txtGallon_Validating);
            // 
            // txtCalculator
            // 
            this.txtCalculator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalculator.Location = new System.Drawing.Point(150, 148);
            this.txtCalculator.Name = "txtCalculator";
            this.txtCalculator.Size = new System.Drawing.Size(115, 20);
            this.txtCalculator.TabIndex = 2;
            this.txtCalculator.TabStop = false;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculator.Location = new System.Drawing.Point(111, 194);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(85, 28);
            this.btnCalculator.TabIndex = 3;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(338, 242);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.txtCalculator);
            this.Controls.Add(this.txtGallon);
            this.Controls.Add(this.txtMile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMile;
        private System.Windows.Forms.TextBox txtGallon;
        private System.Windows.Forms.TextBox txtCalculator;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

