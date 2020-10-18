namespace Bai14
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
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnAllRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAllLeft = new System.Windows.Forms.Button();
            this.btnDelLeft = new System.Windows.Forms.Button();
            this.btnDelRight = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnHếtDsSangLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáDanhSáchLớpAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoáDanhSáchLớpBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên SV:";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(148, 33);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(191, 22);
            this.txtTenSV.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(362, 25);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(93, 38);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 16;
            this.lbLeft.Location = new System.Drawing.Point(34, 77);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLeft.Size = new System.Drawing.Size(158, 180);
            this.lbLeft.TabIndex = 3;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.ItemHeight = 16;
            this.lbRight.Location = new System.Drawing.Point(329, 77);
            this.lbRight.Name = "lbRight";
            this.lbRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRight.Size = new System.Drawing.Size(158, 180);
            this.lbRight.TabIndex = 4;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(223, 77);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnAllRight
            // 
            this.btnAllRight.Location = new System.Drawing.Point(223, 106);
            this.btnAllRight.Name = "btnAllRight";
            this.btnAllRight.Size = new System.Drawing.Size(75, 23);
            this.btnAllRight.TabIndex = 6;
            this.btnAllRight.Text = ">>";
            this.btnAllRight.UseVisualStyleBackColor = true;
            this.btnAllRight.Click += new System.EventHandler(this.btnAllRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(223, 205);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 7;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAllLeft
            // 
            this.btnAllLeft.Location = new System.Drawing.Point(223, 234);
            this.btnAllLeft.Name = "btnAllLeft";
            this.btnAllLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAllLeft.TabIndex = 8;
            this.btnAllLeft.Text = "<<";
            this.btnAllLeft.UseVisualStyleBackColor = true;
            this.btnAllLeft.Click += new System.EventHandler(this.btnAllLeft_Click);
            // 
            // btnDelLeft
            // 
            this.btnDelLeft.Location = new System.Drawing.Point(34, 274);
            this.btnDelLeft.Name = "btnDelLeft";
            this.btnDelLeft.Size = new System.Drawing.Size(107, 30);
            this.btnDelLeft.TabIndex = 9;
            this.btnDelLeft.Text = "Xoá Lớp A";
            this.btnDelLeft.UseVisualStyleBackColor = true;
            this.btnDelLeft.Click += new System.EventHandler(this.btnDelLeft_Click);
            // 
            // btnDelRight
            // 
            this.btnDelRight.Location = new System.Drawing.Point(380, 274);
            this.btnDelRight.Name = "btnDelRight";
            this.btnDelRight.Size = new System.Drawing.Size(107, 30);
            this.btnDelRight.TabIndex = 11;
            this.btnDelRight.Text = "Xoá lớp B";
            this.btnDelRight.UseVisualStyleBackColor = true;
            this.btnDelRight.Click += new System.EventHandler(this.btnDelRight_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(223, 278);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Kết thúc";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtLớpAToolStripMenuItem,
            this.cậpNhậtLớpBToolStripMenuItem,
            this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem,
            this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem,
            this.chuyểnHếtDsSangLớpAToolStripMenuItem,
            this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem,
            this.xoáDanhSáchLớpAToolStripMenuItem,
            this.xoáDanhSáchLớpBToolStripMenuItem});
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.kếtThúcToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // cậpNhậtLớpAToolStripMenuItem
            // 
            this.cậpNhậtLớpAToolStripMenuItem.Name = "cậpNhậtLớpAToolStripMenuItem";
            this.cậpNhậtLớpAToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.cậpNhậtLớpAToolStripMenuItem.Text = "Cập nhật lớp A";
            this.cậpNhậtLớpAToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtLớpAToolStripMenuItem_Click);
            // 
            // cậpNhậtLớpBToolStripMenuItem
            // 
            this.cậpNhậtLớpBToolStripMenuItem.Name = "cậpNhậtLớpBToolStripMenuItem";
            this.cậpNhậtLớpBToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.cậpNhậtLớpBToolStripMenuItem.Text = "Cập nhật lớp B";
            this.cậpNhậtLớpBToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtLớpBToolStripMenuItem_Click);
            // 
            // chuyểnPhầnTửChọnSangLớpAToolStripMenuItem
            // 
            this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpAToolStripMenuItem";
            this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp A";
            this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem.Click += new System.EventHandler(this.chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click);
            // 
            // chuyểnPhầnTửChọnSangLớpBToolStripMenuItem
            // 
            this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Name = "chuyểnPhầnTửChọnSangLớpBToolStripMenuItem";
            this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Text = "Chuyển phần tử chọn sang lớp B";
            this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem.Click += new System.EventHandler(this.chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click);
            // 
            // chuyểnHếtDsSangLớpAToolStripMenuItem
            // 
            this.chuyểnHếtDsSangLớpAToolStripMenuItem.Name = "chuyểnHếtDsSangLớpAToolStripMenuItem";
            this.chuyểnHếtDsSangLớpAToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.chuyểnHếtDsSangLớpAToolStripMenuItem.Text = "Chuyển hết ds sang lớp A";
            this.chuyểnHếtDsSangLớpAToolStripMenuItem.Click += new System.EventHandler(this.chuyểnHếtDsSangLớpAToolStripMenuItem_Click);
            // 
            // chuyểnHếtDanhSáchSangLớpBToolStripMenuItem
            // 
            this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Name = "chuyểnHếtDanhSáchSangLớpBToolStripMenuItem";
            this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Text = "Chuyển hết danh sách sang lớp B";
            this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem.Click += new System.EventHandler(this.chuyểnHếtDanhSáchSangLớpBToolStripMenuItem_Click);
            // 
            // xoáDanhSáchLớpAToolStripMenuItem
            // 
            this.xoáDanhSáchLớpAToolStripMenuItem.Name = "xoáDanhSáchLớpAToolStripMenuItem";
            this.xoáDanhSáchLớpAToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.xoáDanhSáchLớpAToolStripMenuItem.Text = "Xoá danh sách lớp A";
            this.xoáDanhSáchLớpAToolStripMenuItem.Click += new System.EventHandler(this.xoáDanhSáchLớpAToolStripMenuItem_Click);
            // 
            // xoáDanhSáchLớpBToolStripMenuItem
            // 
            this.xoáDanhSáchLớpBToolStripMenuItem.Name = "xoáDanhSáchLớpBToolStripMenuItem";
            this.xoáDanhSáchLớpBToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.xoáDanhSáchLớpBToolStripMenuItem.Text = "Xoá danh sách lớp B";
            this.xoáDanhSáchLớpBToolStripMenuItem.Click += new System.EventHandler(this.xoáDanhSáchLớpBToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 324);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelRight);
            this.Controls.Add(this.btnDelLeft);
            this.Controls.Add(this.btnAllLeft);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnAllRight);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(545, 371);
            this.MinimumSize = new System.Drawing.Size(545, 371);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnAllRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAllLeft;
        private System.Windows.Forms.Button btnDelLeft;
        private System.Windows.Forms.Button btnDelRight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnPhầnTửChọnSangLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnPhầnTửChọnSangLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnHếtDsSangLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnHếtDanhSáchSangLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáDanhSáchLớpAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoáDanhSáchLớpBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
    }
}

