using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decentraland
{
    public class Getir
    {
        public decimal fiyatGetir(int ID, int adet)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=Decentraland; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT unitprice FROM Products where ID= " + ID;
            con.Open();
            decimal sayi = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();
            return sayi * Convert.ToDecimal(adet);


        }
        public void HerSeyiYapıcı()
        {
            
           
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SNDVL45\SQLEXPRESS; Initial Catalog=Decentraland; Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = $"select * from Category";
            con.Open();
            SqlDataReader readerCategory = cmd.ExecuteReader();
            while (readerCategory.Read())
            {
                int ID = readerCategory.GetInt32(0);
                string categoryname = readerCategory.GetString(1);
                Console.WriteLine($"{ID}) \t {categoryname}");
            }
            con.Close();
            Console.WriteLine("Ürünlerini Listelemek İStediğiniz Kategorinin numarasını yazınız");
            string no = Console.ReadLine();
            Console.Clear();
            cmd.CommandText = "SELECT ID, Category_ID,_Name,stocks,unitprice FROM Products Where Category_ID = " + no;
            con.Open();
            SqlDataReader readerUrun = cmd.ExecuteReader();
            while (readerUrun.Read())
            {
                int ID = readerUrun.GetInt32(0);
                int category_ID = readerUrun.GetInt32(1);
                string urunadi = readerUrun.GetString(2);
                
                decimal fiyat = readerUrun.GetDecimal(4);
                Console.WriteLine($"{ID}) \t {urunadi} \t {fiyat} tl");




            }
            con.Close();
        }
    }
}
