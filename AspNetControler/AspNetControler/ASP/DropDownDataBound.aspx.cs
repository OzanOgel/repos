using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetControler.ASP
{
    public partial class DropDownDataBound : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select CategoryID,CategoryName from Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ddl_kategoriler.Items.Add(new ListItem(reader.GetString(1), reader.GetInt32(0).ToString()));
                }
            }
        }

        protected void ddl_kategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_secilen.Text = ddl_kategoriler.SelectedItem.Value + " - " + ddl_kategoriler.SelectedItem.Text; 
        }
    }
}