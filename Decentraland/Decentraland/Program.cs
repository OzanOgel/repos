using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decentraland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Getir getir = new Getir();
            Console.WriteLine("\t  \t                             Decentraland markete hoşgeldiniz");
            Console.WriteLine("1)Üye girişi için 1 e basınız");
            Console.WriteLine(" ");
            Console.WriteLine("2)Kayıt olmak için 2 ye basınız");
            int GirisSecenek = Convert.ToInt32(Console.ReadLine());
            if (GirisSecenek == 2)
            {
                Console.Clear();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=Decentraland; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                Console.WriteLine("İsim Giriniz");
                string isim = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Soyad giriniz");
                string Soyad = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("E-posta giriniz");
                string ePosta = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Şifre giriniz");
                string şifre = Console.ReadLine();
                Console.Clear();

                cmd.CommandText = $"INSERT INTO Users(mail,_password,_Name,_Surname) VALUES('{ePosta}','{şifre}','{isim}','{Soyad}')";
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("Kaydınız Başarıyla Tamamlandı");
            }
            if(GirisSecenek == 1)
            {
                Console.Clear();
                SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=Decentraland; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = $"select mail,_password,_Name,_Surname from Users";
                Console.WriteLine("Lütfen e posta giriniz");
                string eposta = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("lütfen şifre giriniz");
                string şifre = Console.ReadLine();
                Console.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string mail = reader.GetString(0);
                    string password = reader.GetString(1);
                    string name = reader.GetString(2);
                    string surname = reader.GetString(3);
                    if(eposta == mail  && şifre == password)
                    {
                        con.Close();
                        Console.WriteLine("hoşgeldin " + name + " " + surname);

                        cmd.CommandText = $"select * from Category";
                        con.Open();
                        SqlDataReader readerCategory = cmd.ExecuteReader();
                        string secenek = "e";
                       
                           

                            
                            con.Close();
                            decimal toplam = 0;
                            while(secenek == "e")
                            {
                                getir.HerSeyiYapıcı();
                                Console.WriteLine("Almak istediğiniz ürünün numarasını yazınız");
                                int URUNID = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Kaç adet alcaksınız");
                                int adet = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine( getir.fiyatGetir(URUNID,adet) + "TL tutarında ürün sepete eklendi ");
                                toplam += getir.fiyatGetir(URUNID, adet);
                                Console.WriteLine("Alışverişe Devam etmek istermisiniz(e/h)");
                                secenek = Console.ReadLine();
                                
                                Console.Clear();
                                Console.WriteLine("Sepet = " + toplam);
                               



                            }
                            
                        




                    }
                   
                }
            }


        }
        


        
    }
}
