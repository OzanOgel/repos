using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfDeveloperLTD
{
    public partial class PersonelKayitForm : Form
    {
        public PersonelKayitForm()
        {
            InitializeComponent();
            bool secili = chb_devamediyor.Checked;
            lbl_cikis.Visible = dtp_cikis.Visible = !secili;
        }

        private void PersonelKayitForm_Load(object sender, EventArgs e)
        {
            personelgetir();
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string kimlikno = "";
                if (mtb_tc.Text != "")
                {
                    kimlikno = mtb_tc.Text;
                    string path = "Personeller/" +kimlikno + ".txt";
                    StreamWriter sw = new StreamWriter(path);
                    sw.WriteLine("deneme");
                    sw.WriteLine(tb_ad.Text);
                    sw.WriteLine(tb_soyad.Text);
                    sw.WriteLine(mtb_tc.Text);
                    sw.WriteLine(mtb_telno.Text);
                    sw.WriteLine(dtp_dogum.Value.ToShortTimeString());
                    sw.WriteLine(cb_dogumyeri.SelectedItem.ToString());
                    sw.WriteLine(rb_erkek.Checked ? "Erkek" : "Kadın");
                    sw.WriteLine(rb_evli.Checked ? "Evli" : "Bekar");
                    sw.WriteLine(nud_cocusayi.Value.ToString());
                    sw.WriteLine(cb_sehir.SelectedItem.ToString());
                    sw.WriteLine(tb_adres.Text);
                    sw.WriteLine(cb_departman.SelectedItem.ToString());
                    sw.WriteLine(dtp_isegiris.Value.ToShortTimeString());
                    sw.WriteLine(chb_devamediyor.Checked);
                    string ehliyetler = "";
                    foreach (var ıtem in clb_ehliyet.CheckedItems)
                    {
                        ehliyetler += ",";
                    }
                    if (chb_devamediyor.Checked)
                    {
                        sw.WriteLine(dtp_cikis.Value.ToShortDateString());
                    }
                    sw.Close();
                    personelgetir();
                    MessageBox.Show("Kayıt Başarılı");




                }
            }
            catch
            {
                MessageBox.Show("Kayıt Başarısız");
            }


        }

        private void cb_devamediyor_CheckedChanged(object sender, EventArgs e)
        {
            bool secili = chb_devamediyor.Checked;
            lbl_cikis.Visible =dtp_cikis.Visible =! secili;

            
        }
        public void personelgetir()
        {
            string path = "Personeller";
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] dosyalar = di.GetFiles();
            listBox1.Items.Clear();
            foreach (FileInfo item in dosyalar)
            {
                listBox1.Items.Add(item.Name);
            }
        }
        
    }
}
