using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreliSorgular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select CategoryID,CategoryName,Description FROM Categories";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                string aciklama = reader.GetString(2);
                Console.WriteLine($"{id}) {isim} {aciklama}");

            }
            con.Close();
            Console.WriteLine("Ürünleri Lİstelemek istediğiniz Kategori numarası yazınız");
            string KatNo = Console.ReadLine();
            cmd.CommandText = "Select ProductID,ProductName from Products WHERE CategoryID = @abc";
            cmd.Parameters.AddWithValue("@abc", KatNo);
            con.Open();
            SqlDataReader urunreader = cmd.ExecuteReader();
            Console.Clear();
            while(urunreader.Read())
            {
                int id = urunreader.GetInt32(0);
                string isim = urunreader.GetString(1);
                Console.WriteLine($"{id}) {isim}");

                 
            }

        }
    }
}
