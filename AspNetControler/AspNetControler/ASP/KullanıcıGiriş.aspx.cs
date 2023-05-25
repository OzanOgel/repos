using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetControler.ASP
{
    public partial class KullanıcıGiriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                if (tb_kullaniciAdi.Text == "admin" && tb_sifre.Text == "1234")
                {
                    lbl_mesaj.Text = "Hoşgeldin Admin";
                }
                else
                {
                    lbl_mesaj.Text = "Kullanıcı Adı veya şifre Hatalı";
                }
            }
            else
            {
                lbl_mesaj.Text = "Kullanıcı Adı Veya Şİfre Boş Bırakılamaz";
            }
        }
    }
}