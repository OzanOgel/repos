using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetControler.ASP
{
    public partial class TextBoxController : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_yazdir_Click(object sender, EventArgs e)
        {
            lbl_isim.Text="Gelen veri = " + TB_isim.Text;
        }
    }
}