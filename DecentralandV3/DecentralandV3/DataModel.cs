using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace DecentralandV3
{
    internal class DataModel
    {
        SqlConnection con; SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-SNDVL45\SQLEXPRESS;Initial Catalog=Decentraland;Integrated Security=True");
            cmd = con.CreateCommand();
        }

        #region Users Metotları
        public void kullaniciekle(Users U)
        {

                cmd.CommandText = "insert into Users(mail,_password,_Name,_Surname) values(@npn234,@zlmHyr12,@Şuayip,@Kızılkalkan)";
                cmd.Parameters.AddWithValue("@npn234", U.Mail);
                cmd.Parameters.AddWithValue("@zlmHyr12", U.Password);
                cmd.Parameters.AddWithValue("@Şuayip", U.Name);
                cmd.Parameters.AddWithValue("@Kızılkalkan", U.Surname);
                con.Open();
                cmd.ExecuteNonQuery();
            con.Close();
            
        }
        
        

        
        
        #endregion
    }
}
