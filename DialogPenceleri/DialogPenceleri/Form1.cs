using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogPenceleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf";
            saveFileDialog1.Filter = "Zengin Metin Biçimi|*.rtf";

        }
        string path = "";

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_yeni_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void TSMI_ac_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void TSMI_kaydey_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
           
        }

        private void TSMI_farklikaydet_Click(object sender, EventArgs e)
        {
            if(path != "")
            {
                richTextBox1.SaveFile(path);
            }
            else
            {
                path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void TSMI_kapat_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
