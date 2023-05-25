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
   
    public partial class Form2 : Form
    {
        Label lbl_isim;
        TextBox tb_isim, tb_soyisim;
        public Form2()
        {
            InitializeComponent();
            lbl_isim = new Label();
            lbl_isim.Name = "lbl_isim";
            lbl_isim.Text = "Isim  ;";
            lbl_isim.Location = new Point(10, 12);
            lbl_isim.AutoSize = true;
            this.Controls.Add(lbl_isim);
            tb_isim = new TextBox();
            tb_isim.Location = new Point(70, 10);
            tb_isim.Text = "Selam Hacı";
            this.Controls.Add(tb_isim);
            tb_soyisim = new TextBox();
            tb_soyisim.Location = new Point(70, 45);
            this.Controls.Add(tb_soyisim);
            Button btn_goster = new Button();
            btn_goster.Location = new Point(10, 90);
            btn_goster.Click += Btn_goster_Click;
            btn_goster.Text = "Tıkla";
            this.Controls.Add(btn_goster);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btn_goster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_isim.Text + " " + tb_soyisim.Text);
        }
    }
}
