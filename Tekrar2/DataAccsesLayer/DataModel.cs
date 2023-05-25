using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsesLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionString.murtazaConnection);
            cmd = con.CreateCommand();
        }
        #region TurIşlemleri
        public List<Tur> TurLıstele()
        {
            try
            {
                List<Tur> Turlist = new List<Tur>();
                cmd.CommandText = "select * from Tur";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())

                {
                    
                    Tur t = new Tur();
                    t.ID = reader.GetInt32(0);
                    t.isim = reader.GetString(1);
                    Turlist.Add(t);


                    
                    


                }
                return Turlist;
            }
            catch
            {

                return null;
            }
            finally
            {
                con.Close();
            }
            
            



        }

        #endregion
        #region IçerikIşlemleri
        public List<Içerik> IçerikListele()
        {
            try
            {
                List<Içerik> içeriklist = new List<Içerik>();
                cmd.CommandText = "select * from içerik";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader readerIçerik = cmd.ExecuteReader();
                while (readerIçerik.Read())
                {
                    Içerik i = new Içerik();
                    i.ID = readerIçerik.GetInt32(0);
                    i.Tur_ID = readerIçerik.GetInt32(1);
                    i.Isim = readerIçerik.GetString(2);
                    içeriklist.Add(i);


                }
                return içeriklist;
            }
            catch 
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }
       
        
        
       



        #endregion
    }
}
