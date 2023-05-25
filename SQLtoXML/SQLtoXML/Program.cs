using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SQLtoXML
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Oluşturma
            XDocument xDoc = new XDocument();
            string filepath = "personeller.xml";
            if (File.Exists(filepath) == false)
            {
                try
                {
                    FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate);

                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    sb.AppendLine("<Urunler>");
                    sb.AppendLine("</Urunler>");
                    fs.Close();
                    File.AppendAllText(filepath, sb.ToString());
                    xDoc = XDocument.Load(filepath);
                    Console.WriteLine("Dosya Oluşturuldu ve yüklendi");
                }
                catch
                {
                    Console.WriteLine("dosya oluşturma başarısız");
                }

            }
            else
            {
                xDoc = XDocument.Load(filepath);
                Console.WriteLine("Dosya Yüklendi");
            }
            #endregion

            #region Veri tabanından veri çekme 
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source =.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT ProductID,ProductName,UnitsInStock,UnitPrice from Products where Discontinued=0";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                XElement root = xDoc.Root;
                while (reader.Read())
                {
                    XElement urun = new XElement("urun");
                    XAttribute idattribute = new XAttribute("ID", reader.GetInt32(0).ToString());
                    XElement isimelement = new XElement("Isim", reader.GetString(1));
                    XElement stokeleman = new XElement("Stok", reader.GetInt16(2).ToString());
                    XElement fiyatelement = new XElement("Fiyat", reader.GetDecimal(3).ToString());
                    urun.Add(idattribute, isimelement, stokeleman, fiyatelement);
                    root.Add(urun);


                }
                xDoc.Save(filepath);
                Console.WriteLine("xml Dosyasına Ürünler eklendi");
                con.Close();
            }
            catch
            {
                Console.WriteLine("olmadı");
            }
            #endregion







        }
    }
}
