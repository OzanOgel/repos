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
    public partial class Odev : Form
    {
        public Odev()
        {
            InitializeComponent();
            rb_erkek.Checked = true;
            rb_bekar.Checked = true;
        }

        private void cb_departman_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Odev_Load(object sender, EventArgs e)
        {
            
            nud_cocuk.Visible = false;
            label10.Visible = false;
            cb_departman.Items.Add("Muhasebe");
            cb_departman.Items.Add("Satış/Pazarlama");
            cb_departman.Items.Add("Satın Alma");
            cb_departman.Items.Add("Muhasebe");
            cb_departman.Items.Add("İnsan Kaynakları");
            if (rb_evli.Checked)
            {
                nud_cocuk.Visible = true;
                label10.Visible = true;
            }
            else
            {
                nud_cocuk.Visible = false;
                label10.Visible = false;
            }
        }

        private void rb_evli_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_evli.Checked)
            {
                nud_cocuk.Visible = true;
                label10.Visible = true;
            }
            else
            {
                nud_cocuk.Visible = false;
                label10.Visible = false;
            }
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
          
        }
    }
}
