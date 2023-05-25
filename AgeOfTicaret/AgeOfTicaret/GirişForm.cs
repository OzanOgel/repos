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
   
    public partial class GirişForm : Form
    {
        DataModel dm = new DataModel();
        bool girisvar = false;
        public GirişForm()
        {
            InitializeComponent();
           
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciadi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                Employee model = dm.emoployeelogin(tb_kullaniciadi.Text, tb_sifre.Text);
                if(model.UserName != null)
                {
                    helpers.GirisYapanKullanici = model;
                    girisvar = true;
                    this.Close();
                    
                }

                
            }
            
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre boş olamaz");
            }
        }

        private void GirişForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisvar)
            {
                Application.Exit();
            }
        }
    }
}
