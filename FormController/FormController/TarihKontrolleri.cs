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
    public partial class TarihKontrolleri : Form
    {
        string klasorYol = "C://Dosyalar/odev";
        public TarihKontrolleri()
        {
            InitializeComponent();
        }

        private void TarihKontrolleri_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // label4.Text = dtp_tarih.Text;
            DateTime secilen = dtp_tarih.Value;
            label4.Text = secilen.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }
    }
    }

