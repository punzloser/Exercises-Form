using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDetai
{
    public partial class frmMain : Form
    {
        int state;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.detai' table. You can move, or remove it, as needed.
            this.detaiTableAdapter.Fill(this.dataSet11.detai);
            loadData();
            enablePanel1();
        }
        private void loadData()
        {
            // TODO: This line of code loads data into the 'dataSet1.LoaiDT' table. You can move, or remove it, as needed.
            this.loaiDTTableAdapter.Fill(this.dataSet1.LoaiDT);
            DataSet1.detaiDataTable a = new DataSet1.detaiDataTable();
            DataSet1TableAdapters.detaiTableAdapter b = new DataSet1TableAdapters.detaiTableAdapter();
            a.Reset();
            b.Fill(a);
            dataGridView1.DataSource = a;
        }

        private void enablePanel1()
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
        }

        private void enablePanel2()
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
        }

        private void load_dulieu()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtTenDT.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                txtDiem.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                txtGVHD.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                cbLoaiDT.SelectedValue = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                txtID.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            load_dulieu();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            enablePanel2();
            state = 1;
            txtID.Clear();
            txtDiem.Clear();
            txtGVHD.Clear();
            txtTenDT.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            enablePanel2();
            state = 2;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enablePanel2();
            state = 3;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            enablePanel1();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(state == 1)
            {
                DataSet1.spud_ThemDeTaiDataTable b = new DataSet1.spud_ThemDeTaiDataTable();
                DataSet1TableAdapters.spud_ThemDeTaiTableAdapter a = new DataSet1TableAdapters.spud_ThemDeTaiTableAdapter();
                b.Reset();
                a.Fill(b, txtTenDT.Text, double.Parse(txtDiem.Text), txtGVHD.Text, int.Parse(cbLoaiDT.SelectedValue.ToString()));
                
            }
            if(state == 3)
            {
                DataSet1.spud_SuaDeTaiDataTable b = new DataSet1.spud_SuaDeTaiDataTable();
                DataSet1TableAdapters.spud_SuaDeTaiTableAdapter a = new DataSet1TableAdapters.spud_SuaDeTaiTableAdapter();
                b.Reset();
                a.Fill(b,long.Parse(txtID.Text),txtTenDT.Text, double.Parse(txtDiem.Text), txtGVHD.Text, int.Parse(cbLoaiDT.SelectedValue.ToString()));
            }
            if(state == 2)
            {
                DataSet1.spud_XoaDeTaiDataTable b = new DataSet1.spud_XoaDeTaiDataTable();
                DataSet1TableAdapters.spud_XoaDeTaiTableAdapter a = new DataSet1TableAdapters.spud_XoaDeTaiTableAdapter();
                b.Reset();
                a.Fill(b, int.Parse(txtID.Text));
            }
            loadData();
            enablePanel1();
        }

        private void cbLoaiDT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
