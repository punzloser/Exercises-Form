using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManagement
{
    public partial class frmXemThoiKhoaBieu : Form
    {
        public frmXemThoiKhoaBieu()
        {
            InitializeComponent();
            displayGridview();
        }

        public void displayGridview()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DataSet1.TKBDataTable b = new DataSet1.TKBDataTable();
            DataSet1TableAdapters.TKBTableAdapter a = new DataSet1TableAdapters.TKBTableAdapter();
            b.Reset();
            a.XemTKB(b, DateTime.Parse(dtpBatDau.Text), DateTime.Parse(dtpKetThuc.Text));
            dataGridView1.DataSource = b;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmXemThoiKhoaBieu_Load(object sender, EventArgs e)
        {

        }
    }
}
