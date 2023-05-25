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
    public partial class MenuKullanimi : Form
    {
        public MenuKullanimi()
        {
            InitializeComponent();
        }

        private void bastacısınkapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniPersonelFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           PersonelForm frm = new PersonelForm();
            frm.MdiParent = this;   
            frm.Show();
        }
    }
}
