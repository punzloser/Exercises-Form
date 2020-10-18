using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        List<Label> labelAdded = new List<Label>();
        int gia = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 40;
            int y = -20;
            for (int i = 0; i<15; i++)
            {
                if(i%5 == 0)
                {
                    y += 55;
                    x = 40;
                }
                Label lb = new Label();
                lb.BackColor = System.Drawing.Color.White;
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                lb.ForeColor = System.Drawing.Color.Green;
                lb.Location = new System.Drawing.Point(x, y);
                lb.Name = "Ghe"+ (i + 1).ToString();
                lb.Size = new System.Drawing.Size(50, 50);
                lb.TabIndex = 0;
                lb.Text = (i+1).ToString();
                lb.Click += (s, m) => {
                    if(lb.BackColor == Color.Yellow)
                    {
                        MessageBox.Show("Ghế này đã có người mua!");
                    }
                    else if (lb.BackColor == Color.White)
                    {
                        lb.BackColor = Color.Blue;
                        lb.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        lb.ForeColor = System.Drawing.Color.Green;
                        lb.BackColor = Color.White;
                    }
                };
                panel1.Controls.Add(lb);
                labelAdded.Add(lb);
                x += 55;
            }   
            

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int ok =0;
            for(int i = 0; i< labelAdded.Count; i++)
            {
                if (labelAdded[i].BackColor == Color.Blue)
                {
                    ok ++;
                    labelAdded[i].BackColor = Color.Yellow;
                    labelAdded[i].ForeColor = System.Drawing.Color.Green;
                }
            }
            txtThanhTien.Text = (ok * gia).ToString();
            if (ok == 0)
                MessageBox.Show("Vui lòng chọn 1 ghế!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labelAdded.Count; i++)
            {
                if (labelAdded[i].BackColor == Color.Blue)
                {
                    
                    labelAdded[i].BackColor = Color.White;
                    labelAdded[i].ForeColor = System.Drawing.Color.Green;
                    txtThanhTien.Text = "0";
                }
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có muốn đóng?",
                                  "warning",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }
    }
}
