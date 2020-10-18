using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            foreach(String s in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(s);
            }
        }

      

        private void btnSet_Click(object sender, EventArgs e)
        {
            // var item = this.cbbColor.GetItemText(this.cbbColor.SelectedItem);
            if (cbbColor.SelectedItem == "Red")
            {
                this.BackColor = Color.Red;
            }
            else if (cbbColor.SelectedItem == "Blue")
            {
                this.BackColor = Color.Blue;
            }
            else if (cbbColor.SelectedItem == "Green")
            {
                this.BackColor = Color.Green;
            }
            else 
            {
                this.BackColor = Color.Black;
            }
          
        }
    }
}
