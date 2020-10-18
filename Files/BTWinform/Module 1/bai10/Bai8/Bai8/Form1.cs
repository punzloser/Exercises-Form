using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        List<Button> buttonsAdded = new List<Button>();
        int y = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (y < 0)
            {
                MessageBox.Show("Full Stack!");
            
                return;
            }
            Button btn = new Button();
            btn.Text = "Element " + buttonsAdded.Count().ToString();
            btn.Location = new Point(200, y);
            btn.Click += (s, m) => { lblState.Text = "Status " + btn.Text + " is Clicked!"; };
            y -= 20;
            Controls.Add(btn);
            buttonsAdded.Add(btn);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(buttonsAdded.Count() > 0)
            {
                Button btn2remove = buttonsAdded[buttonsAdded.Count()-1];
                buttonsAdded.Remove(btn2remove);
                Controls.Remove(btn2remove);
                y += 20;
            }
            else
            {
                MessageBox.Show("Nothing to Remove!");
            }
            
        }
    }
}
