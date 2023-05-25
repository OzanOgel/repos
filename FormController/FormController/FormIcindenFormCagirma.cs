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
    public partial class FormIcindenFormCagirma : Form
    {
        public FormIcindenFormCagirma()
        {
            InitializeComponent();
        }

        private void btn_hesapmakinesi_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();

        }

        private void btn_lb_Click(object sender, EventArgs e)
        {
            Listboxcontoller frm = new Listboxcontoller();
            frm.ShowDialog();
        }
    }
}
