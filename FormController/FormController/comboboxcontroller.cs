using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormController
{
    public partial class comboboxcontroller : Form
    {
        public comboboxcontroller()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            string value = cb_markalar.SelectedValue.ToString();
            string text = cb_markalar.Text;

            MessageBox.Show("seçilen marka = " +text  +" Seçilen ID="+ value );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboboxcontroller_Load(object sender, EventArgs e)
        {
            cb_departman.Items.Add("Muhasebe");
            cb_departman.Items.Add("Satış/Pazarlama");
            cb_departman.Items.Add("Satın Alma");
            cb_departman.Items.Add("Muhasebe");
            cb_departman.Items.Add("İnsan Kaynakları");
            List<Marka> markalar = new List<Marka>();
            markalar.Add(new Marka() { ID=1,Isim="audi"});
            markalar.Add(new Marka() { ID = 2, Isim = "volvo" });
            markalar.Add(new Marka() { ID = 3, Isim = "Mercedes" });
            cb_markalar.DisplayMember = "Isim";
            cb_markalar.ValueMember = "ID";
            cb_markalar.DataSource = markalar;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
