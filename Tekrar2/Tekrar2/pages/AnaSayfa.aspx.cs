using DataAccsesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tekrar2.pages
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_anasayfa.DataSource = dm.IçerikListele();
            lv_anasayfa.DataBind();

        }

        protected void lbtn_sil_Click(object sender, EventArgs e)
        {

        }
    }
}