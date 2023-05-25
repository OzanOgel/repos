using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetControler.ASP
{
    public partial class ButtonController : System.Web.UI.Page
    {
       //Sayfa Yüklenirken yapılacak olan işlemlerin yazıldığı event(olay)
        protected void Page_Load(object sender, EventArgs e)
        {
            btn_tikla.Text = "Napin Hüseyin?";
        }

        protected void btn_tikla_Click(object sender, EventArgs e)
        {
            //Butona basıldığında postback gerçekleşir
            //post back gerçekleşince pageLoad tekrar çalışır
            btn_tikla.Text = "hüseyin tıkladı";
        }

        protected void Button_gonder_Click(object sender, EventArgs e)
        {
            Button_gonder.Text = "hadi ben kaçtım";
        }

        protected void lbtn_tikla_Click(object sender, EventArgs e)
        {

        }

        protected void lbtn_gidiyom_click_Click(object sender, EventArgs e)
        {
            Response.Write("<script> alert('Melike Nolurr geri dön);</ script>");
        }
    }
}