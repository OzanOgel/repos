using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormController
{
    public partial class ButonKontrolu : Form
    {
        public ButonKontrolu()
        {
           
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "SASADSA";
            button1.Size = new Size(200, 50);
            MessageBox.Show("dünya boştur le", "Baştacısınız");
        }

        private void ButonKontrolu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MessageBox.Show("Olmazzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", "olurrrrrrrr");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = (sayi1 + sayi2).ToString();
        }
    }
}
