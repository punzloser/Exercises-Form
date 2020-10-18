using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(listBox1.Items.IndexOf(txtNhapso.Text)>=0)
            {
                listBox1.SelectedItem = txtNhapso.Text;
                txtNhapso.ResetText();
            }
            else if(txtNhapso.Text.Length>0)
            {
                listBox1.Items.Add(txtNhapso.Text);
                txtNhapso.ResetText();
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
    }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
            int n = listBox1.Items.Count;
            listBox1.Items.RemoveAt(n-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 0;i<listBox1.Items.Count;i++)
            {
                
                s += i;
            }
            txtNhapso.Text = s.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items[i] = int.Parse(listBox1.Items[i].ToString()) + 2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int a = int.Parse(listBox1.Items[i].ToString());
                if (a % 2 == 0)
                {
                    listBox1.SelectedItem = listBox1.Items[i] ;
                }
            }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.Items[i] = int.Parse(listBox1.Items[i].ToString()) * int.Parse(listBox1.Items[i].ToString());

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int a = int.Parse(listBox1.Items[i].ToString());
                if (a % 2 == 1)
                {
                    listBox1.SelectedItem = listBox1.Items[i];
                }
            }
            
        }
    }
    }
 
