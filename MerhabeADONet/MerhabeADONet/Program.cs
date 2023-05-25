using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerhabeADONet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Kategori Sayısı çekelim
            ////1 Bağlantı

            //SqlConnection baglanti = new SqlConnection();

            ////2 Bağlantı yolu
            //baglanti.ConnectionString = @"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True";

            ////Komut
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti;
            ////Komut Metni
            //komut.CommandText = "SELECT COUNT(*) FROM Categories";

            ////Bağlantı Aç
            //baglanti.Open();

            ////Sorgu Çalıştır
            ////Sorgudan geriye 1 hücre dönecek ise ExecuteScalar()
            //int adet = Convert.ToInt32(komut.ExecuteScalar());

            ////Bağlantı Kapat
            //baglanti.Close();

            //Console.WriteLine("Kategori Sayısı = "+adet);

            #endregion

            #region Ürün Sayısı Çekelim
            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT COUNT(*) FROM Products";
            //con.Open();
            //int sayi = Convert.ToInt32(cmd.ExecuteScalar());
            //con.Close();
            //Console.WriteLine("Ürün Sayısı = " + sayi );

            #endregion

            #region Kategori Ekleyelim
            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();
            //Console.WriteLine("Kategori Adı Giriniz");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kategori Açıklama Giriniz");
            //string aciklama = Console.ReadLine();

            //cmd.CommandText = $"INSERT INTO Categories(CategoryName, Description) VALUES('{isim}','{aciklama}')";
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            //Console.WriteLine("ürün eklendi");



            #endregion

            #region Kategorileri Listeleyelim
            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            //SqlCommand cmd = con.CreateCommand();
            //cmd.CommandText = "SELECT CategoryID,Description,CategoryName From Categories";
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    int id = reader.GetInt32(0);
            //    string name = reader.GetString(2);
            //    string aciklama = reader.GetString(1);
            //    Console.WriteLine($"{id} {name} {aciklama}");
            //}
            
            #endregion

            #region Kategori Seçerek Ürün Listeleyelim
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT CategoryID,Description,CategoryName From Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(2);
                string aciklama = reader.GetString(1);
                Console.WriteLine($"{id} {name} {aciklama}");
            }
            con.Close();
            Console.WriteLine("Ürünlerini Listelemek İStediğiniz Kategorinin numarasını yazınız");
            string no = Console.ReadLine();
            cmd.CommandText = "SELECT ProductID ,ProductName,UnitPrice,UnitsInStock FROM Products Where Category_ID = " + no;
            con.Open();
            SqlDataReader readerUrun = cmd.ExecuteReader();
            while(readerUrun.Read())
            {
                int id = readerUrun.GetInt32(0);
                string isim = readerUrun.GetString(1);
                decimal fiyat = readerUrun.GetDecimal(2);
                short stok = readerUrun.GetInt16(3);
                Console.WriteLine($"{id} {isim} {stok} {fiyat} tl");
            }
            con.Close();

            


            #endregion
        }
    }
}
