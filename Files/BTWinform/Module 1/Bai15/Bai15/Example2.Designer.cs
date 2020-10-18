namespace Bai15
{
    partial class Example2
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radLong = new System.Windows.Forms.RadioButton();
            this.radShort = new System.Windows.Forms.RadioButton();
            this.lblstart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(59, 68);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the day you want to travel:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 318);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radShort);
            this.panel1.Controls.Add(this.radLong);
            this.panel1.Location = new System.Drawing.Point(33, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 51);
            this.panel1.TabIndex = 3;
            // 
            // radLong
            // 
            this.radLong.AutoSize = true;
            this.radLong.Location = new System.Drawing.Point(5, 15);
            this.radLong.Name = "radLong";
            this.radLong.Size = new System.Drawing.Size(91, 21);
            this.radLong.TabIndex = 0;
            this.radLong.TabStop = true;
            this.radLong.Text = "LongDate";
            this.radLong.UseVisualStyleBackColor = true;
            this.radLong.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radShort
            // 
            this.radShort.AutoSize = true;
            this.radShort.Location = new System.Drawing.Point(121, 15);
            this.radShort.Name = "radShort";
            this.radShort.Size = new System.Drawing.Size(92, 21);
            this.radShort.TabIndex = 0;
            this.radShort.TabStop = true;
            this.radShort.Text = "Short Day";
            this.radShort.UseVisualStyleBackColor = true;
            this.radShort.CheckedChanged += new System.EventHandler(this.radShort_CheckedChanged);
            // 
            // lblstart
            // 
            this.lblstart.AutoSize = true;
            this.lblstart.Location = new System.Drawing.Point(351, 68);
            this.lblstart.Name = "lblstart";
            this.lblstart.Size = new System.Drawing.Size(46, 17);
            this.lblstart.TabIndex = 4;
            this.lblstart.Text = "label2";
            // 
            // lblend
            // 
            this.lblend.AutoSize = true;
            this.lblend.Location = new System.Drawing.Point(351, 158);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(46, 17);
            this.lblend.TabIndex = 4;
            this.lblend.Text = "label2";
            // 
            // Example2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 422);
            this.Controls.Add(this.lblend);
            this.Controls.Add(this.lblstart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Example2";
            this.Text = "Example2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radLong;
        private System.Windows.Forms.RadioButton radShort;
        private System.Windows.Forms.Label lblstart;
        private System.Windows.Forms.Label lblend;
    }
}