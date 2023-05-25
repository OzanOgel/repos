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
    public partial class RadioButtonKontroller : Form
    {
        public RadioButtonKontroller()
        {
            InitializeComponent();
            rb_erkek.Checked= true;
            rb_evli.Checked = true;
        }

        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            if (cb_sozlesme.Checked)
            {

                string cinsiyet = "Cinsiyet = ";
                string medenihal = "Medeni Hal = ";
                if (rb_erkek.Checked)
                {
                    cinsiyet += "Erkek";
                }
                if (rb_kadın.Checked)
                {
                    cinsiyet += "Kadın";

                }
                if (rb_evli.Checked)
                {
                    medenihal += "Evli";
                }
                if (rb_bekar.Checked)
                {
                    medenihal += "Bekar";
                }
                MessageBox.Show(cinsiyet + "\n" + medenihal);
            }
            else
            {
                MessageBox.Show("Sözleşmeyi kabut etmediniz");
            }
        }

        private void btn_tumu_Click(object sender, EventArgs e)
        {
            int elemansayi = checkedListBox1.Items.Count;
            for(int i = 0; i<elemansayi; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            int elemansayi = checkedListBox1.Items.Count;
            for (int i = 0; i < elemansayi; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                
                listBox1.Items.Add(checkedListBox1.CheckedItems[i]);
                
            }
        }
    }
}
