using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DecentralandV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("\t  \t                             Decentraland markete hoşgeldiniz");
            Console.WriteLine("1)Üye girişi için 1 e basınız");
            Console.WriteLine(" ");
            Console.WriteLine("2)Kayıt olmak için 2 ye basınız");
            int GirisSecenek = Convert.ToInt32(Console.ReadLine());
            if (GirisSecenek == 2)
            {
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
            if (GirisSecenek == 1)
            {
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
             

                while(reader.Read())
                {
                  

                    string mail = reader.GetString(0);
                    string password = reader.GetString(1);
                    string name = reader.GetString(2);
                    string surname = reader.GetString(3);
                    if(mail == eposta && password == eposta)
                    {
                       
                        con.Close();
                        Console.WriteLine("hoşgeldin " + name + " " + surname);
                        break;
                    }
                    

                }
                

            }
        }
    }
}
