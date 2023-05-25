using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetControler.ASP
{
    public partial class DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_goster_Click(object sender, EventArgs e)
        {
            string secilen = "";
            if(ddl_dersler.SelectedItem.Value != "0")
            {
                secilen = ddl_dersler.SelectedItem.Text;
                lbl_secilen.Text = secilen;
            }
            else
            {
                lbl_secilen.Text = "lütfen seçim yapınız";
            }
        }
    }
}