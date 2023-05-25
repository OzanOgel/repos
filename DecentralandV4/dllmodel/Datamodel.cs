using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace dllmodel
{
    public class Datamodel
    {
        SqlConnection con; SqlCommand cmd;

        public Datamodel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }


        #region Users Metotları
        public void KullanıcıEkle(Users U)
        {

            cmd.CommandText = "insert into Users(mail,_password,_Name,_Surname) values(@npn234,@zlmHyr12,@Şuayip,@Kızılkalkan)";
            cmd.Parameters.AddWithValue("@npn234", U.Mail);
            cmd.Parameters.AddWithValue("@zlmHyr12", U.password);
            cmd.Parameters.AddWithValue("@Şuayip", U.Name);
            cmd.Parameters.AddWithValue("@Kızılkalkan", U.Surname);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public List<Users> KullanıciListele()
        {
            List<Users> Kullanıcılar = new List<Users>();
            try
            {
                cmd.CommandText = "select * from Users";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Users u = new Users();
                    u.ID = reader.GetInt32(0);
                    u.Mail = reader.GetString(1);
                    u.password = reader.GetString(2);
                    u.Name = reader.GetString(3);
                    u.Surname = reader.GetString(4);
                    Kullanıcılar.Add(u);
                }
                return Kullanıcılar;
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

        #region Kategori-Ürün Metotları
        public List<Categories> Kategorilistele()
        {
            List<Categories> Kategoriler = new List<Categories>();
            try
            {
                cmd.CommandText = "select * from Category";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader readercategory = cmd.ExecuteReader();
               while(readercategory.Read())
                {
                    Categories cat = new Categories();
                    cat.ID = readercategory.GetInt32(0);
                    cat.CategoryName = readercategory.GetString(1);
                    Kategoriler.Add(cat);
                }
               return Kategoriler;

            }
            catch
            {
                return null ;
            }
            finally
            {
                con.Close ();
            }

            
        }
        public int GüncelStokGetir(int urunID, int ADET)
        {
            cmd.CommandText = "select stocks from Products where ID =@klm";
            cmd.Parameters.AddWithValue("@klm", urunID);
            con.Open();
            int stok = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            int YeniStok = stok - ADET;
            

            cmd.CommandText = "update Products  set stocks =@mmm  where ID =@sss";
            cmd.Parameters.AddWithValue("@sss", urunID);
            cmd.Parameters.AddWithValue("mmm", YeniStok);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            return YeniStok;

        }
        public decimal fiyatgetir(int urunID , int adet)
        {
            cmd.CommandText = "select unitprice from Products where ID =@unitprice";
            cmd.Parameters.AddWithValue("@unitprice", urunID);
            con.Open();
            decimal fiyat = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();
            return fiyat*adet;
        }

        public List<Products>KategoriIDileUrunListele(int catno)
        {
            List<Products> Ürünler = new List<Products> ();
            try
            {
                cmd.CommandText = "select * from Products where Category_ID =@ABC";
                cmd.Parameters.AddWithValue("@ABC", catno);
                con.Open();
                SqlDataReader urunreader = cmd.ExecuteReader();
                while(urunreader.Read())
                {
                    Products p = new Products();
                    p.ID = urunreader.GetInt32(0);
                    p.CategoryID = urunreader.GetInt32(1);
                    p.name = urunreader.GetString(2);
                    p.stocks = urunreader.GetInt32 (3);
                    p.UnitPrice = urunreader.GetDecimal(4);
                    Ürünler.Add(p);

                }
                return Ürünler;
                
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
