using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtTenSV.Text != "")
            {
                lbLeft.Items.Add(txtTenSV.Text);
            }
            txtTenSV.Clear();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lbLeft, lbRight);
            
        }
        // Move selected items from one ListBox to another.
        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo)
        {
            while (lstFrom.SelectedItems.Count > 0)
            {
                string item = (string)lstFrom.SelectedItems[0];
                lstTo.Items.Add(item);
                lstFrom.Items.Remove(item);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(lbRight, lbLeft);
        }
        private void MoveAllItems(ListBox from, ListBox to)
        {
            while(from.Items.Count > 0)
            {
                string item = (string)from.Items[0];
                to.Items.Add(item);
                from.Items.Remove(item);
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            MoveAllItems(lbLeft, lbRight);
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            MoveAllItems(lbRight, lbLeft);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelLeft_Click(object sender, EventArgs e)
        {
            lbLeft.Items.Clear();
        }

        private void btnDelRight_Click(object sender, EventArgs e)
        {
            lbRight.Items.Clear();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Họ tên: Sonadezi \n MSSV: 001 \n Lop: K11CNTT");
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cậpNhậtLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCapNhat_Click(sender, e);
        }

        private void cậpNhậtLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text != "")
            {
                lbRight.Items.Add(txtTenSV.Text);
            }
            txtTenSV.Clear();
        }

        private void chuyểnPhầnTửChọnSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLeft_Click(sender, e);
        }

        private void chuyểnPhầnTửChọnSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRight_Click(sender, e);
        }

        private void chuyểnHếtDsSangLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAllLeft_Click(sender, e);
        }

        private void chuyểnHếtDanhSáchSangLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAllRight_Click(sender, e);
        }

        private void xoáDanhSáchLớpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelLeft_Click(sender, e);
        }

        private void xoáDanhSáchLớpBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelRight_Click(sender, e);
        }
    }
}
