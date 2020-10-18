using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList arrWord;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void initArrayWord()
        {
            arrWord = new System.Collections.ArrayList();
            arrWord.Add(new Word("hello", "xin chào"));
            arrWord.Add(new Word("dog", "chó"));
            arrWord.Add(new Word("cat", "mèo"));
            arrWord.Add(new Word("duck", "vịt"));
            arrWord.Add(new Word("pig", "heo"));
            arrWord.Add(new Word("chickend", "gà"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initArrayWord();
            for (int i = 0; i < arrWord.Count; i++){
                lstboxEn.Items.Add(((Word)arrWord[i]).English);
            }
            var source = new AutoCompleteStringCollection();
            source.AddRange(lstboxEn.Items.Cast<string>().ToArray());
            txtEn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtEn.AutoCompleteCustomSource = source;
        }

        private void lstboxEn_SelectedIndexChanged(object sender, EventArgs e)
        {
            String en = lstboxEn.SelectedItem.ToString();
            for (int i = 0; i < arrWord.Count; i++)
            {
                if (((Word)arrWord[i]).English == en)
                {
                    txtVi.Text = ((Word)arrWord[i]).Vietnamese;
                }
            }
        }



        private void txtEn_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtEn_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < arrWord.Count; i++)
            {
                if (((Word)arrWord[i]).English == txtEn.Text)
                {
                    txtVi.Text = ((Word)arrWord[i]).Vietnamese;
                }
            }
        }
    }
}
