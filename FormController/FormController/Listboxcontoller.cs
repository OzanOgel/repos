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
    public partial class Listboxcontoller : Form
    {
        public Listboxcontoller()
        {
            InitializeComponent();
        }

        private void btn_goster_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.SelectedItems.Cast<object>().ToList())
            {
                listBox1.Items.Remove(item);
            }

        }

        private void Listboxcontoller_Load(object sender, EventArgs e)
        {
            List<Marka> markalar = new List<Marka>();
            markalar.Add(new Marka() { ID = 1, Isim = "audi" });
            markalar.Add(new Marka() { ID = 2, Isim = "volvo" });
            markalar.Add(new Marka() { ID = 3, Isim = "Mercedes" });
            for(int i = 0; 1<markalar.Count; i++)
            {
                listBox1.Items.Add(markalar[i].Isim);

            }       
            

            //listBox1.DisplayMember = "Isim";
            //listBox1.ValueMember = "ID";
            //listBox1.DataSource = markalar;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {














        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tb_ekle.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
