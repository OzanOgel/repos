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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void topla_Click(object sender, EventArgs e)
        {
            
            tb_sonuc.Text = (nud_1.Value + nud2.Value).ToString();
        }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            
            tb_sonuc.Text = (nud_1.Value - nud2.Value).ToString();
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            tb_sonuc.Text = (nud_1.Value / nud2.Value).ToString();
        }

        private void btn_carp_Click(object sender, EventArgs e)
        {
            tb_sonuc.Text = (nud_1.Value * nud2.Value).ToString();
        }

        
    }
}
