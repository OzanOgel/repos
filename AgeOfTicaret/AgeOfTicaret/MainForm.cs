using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfTicaret
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GirişForm frm = new GirişForm();
            frm.ShowDialog();
            Employee model = helpers.GirisYapanKullanici;
            tssl_kullanici.Text = model.FullName;
            
           
        }

        private void TSMI_kategoriİslemleri_Click(object sender, EventArgs e)
        {
           
            bool acikmi = false;
            Form[] acikformlar = this.MdiChildren;
            foreach (Form item in acikformlar)
            {
                if(item.GetType() == typeof(Kategoriİslemleri))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if(acikmi == false)
            {
                Kategoriİslemleri frm = new Kategoriİslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
           
        }

        private void ürünİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool acikmi = false;
            Form[] acikformlar = this.MdiChildren;
            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(Urunİslemleri))
                {
                    acikmi = true;
                    item.Activate();
                }
            }
            if (acikmi == false)
            {
                Urunİslemleri frm = new Urunİslemleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
