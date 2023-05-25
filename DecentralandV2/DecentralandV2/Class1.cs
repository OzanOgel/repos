using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentralandV2
{
    public class Class1
    {
        public decimal fiyatGetir(int ID , int adet)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=Decentraland; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT unitprice FROM Products where ID= " + ID;
            con.Open();
            decimal sayi = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();
            return sayi*Convert.ToDecimal(adet);


        }

    }
}
