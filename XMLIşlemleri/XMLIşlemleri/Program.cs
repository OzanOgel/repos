using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLIşlemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region XML Nedir?
            /*Türkçe Açılımı Genişletilebilir işaretleme dili anlamına gelen (Extensible Marcup Language),
            insanlar ve bilgi işlem sistemleri için kolayca okunabilcek veri dökümanı yani veri tabanı oluşturmaya yarayan W3C tarafından tanımlanmış bir standarttır
            XML dosya tipinin en önemli özelliği veri saklama görevinin yanı sıra, farklı sistemlerde oluşturulmuş programlar arasında veri alışverişi yaptırmaktır
            Kısaca XML ile farklı platformlar(Masaüstü web mobil) için farklı programlama dilleri(asp.net,C#,PHP,Java) ile yazılan uygulamalar arasında çok kolaylıkla veri transferi yapabilirsiniz
            */

            #endregion

            #region xMl okuma Personeller
            //XDocument xDoc = XDocument.Load("../../personeller.xml");
            // XElement root = xDoc.Root;
            //foreach(XElement item in root.Elements())
            //{
            //    string id = item.Attribute("id").Value;
            //    string isim = item.Element("isim").Value;
            //         string soyad = item.Element("soyad").Value;
            //    string telefon = item.Element("telefon").Value;
            //    string mail = item.Element("mail").Value;
            //    Console.WriteLine($" İD = {id}\n isim = {isim}\n soyad = {soyad}\n telefon = {telefon}\n mail = {mail}\n");
            //}
            #endregion

            #region Veri Ekleme
            //try
            //{
            //    XDocument xDoc = XDocument.Load("../../personeller.xml");
            //    XElement root = xDoc.Root;
            //    XElement newElement = new XElement("personel");
            //    XAttribute idAttribute = new XAttribute("id", 3);
            //    XElement isimElement = new XElement("isim", "Murtaza");
            //    XElement soyadElement = new XElement("soyad", "onlargiller");
            //    XElement telefonElement = new XElement("telefon", "530 xxx xx xx");
            //    XElement mailElement = new XElement("mail", "Murtaza@gmail.com");
            //    newElement.Add(idAttribute, isimElement, soyadElement, telefonElement, mailElement);
            //    root.Add(newElement);
            //    xDoc.Save("../../personeller.xml");
            //    Console.WriteLine("personel eklendi");
            //}
            //catch
            //{
            //    Console.WriteLine("hada godu gırkbir");
            //}


            #endregion

            #region Veri Güncelleme
            //try
            //{
            //    XDocument xDoc = XDocument.Load("../../personeller.xml");
            //    XElement root = xDoc.Root;
            //    foreach (XElement item in root.Elements())
            //    {
            //        if (item.Attribute("id").Value == "1")
            //        {
            //            item.Element("isim").Value = "ibrahim alp";
            //            break;
            //        }
            //    }
            //    xDoc.Save("../../personeller.xml");
            //    Console.WriteLine("başarılı");
            //}
            //catch
            //{
            //    Console.WriteLine("Başarısız");
            //}

            #endregion

            #region Veri Silme
            //try
            //{
            //    XDocument xDoc = XDocument.Load("../../personeller.xml");
            //    XElement root = xDoc.Root;
            //    foreach (XElement item in root.Elements())
            //    {
            //        if(item.Attribute("id").Value == "3")
            //        {
            //            item.Remove();
            //            break;
            //        }
            //    }
            //    xDoc.Save("../../personeller.xml");
            //    Console.WriteLine("Başarılı");
            //}
            //catch
            //{
            //    Console.WriteLine("Başarısız");
            //}
            #endregion

            #region Merkez Bankası Döviz Kurları
            XDocument xDoc = XDocument.Load("https://www.tcmb.gov.tr/kurlar/today.xml");
               XElement root = xDoc.Root;
            string tarih = root.Attribute("Tarih").Value;
            Console.WriteLine($"Tarih = {tarih}");
            Console.WriteLine("-*-*-*-*-Tarihli Döviz Kurları");
            foreach(XElement item in root.Elements())
            {
                string kod = item.Attribute("Kod").Value;
                string isim = item.Element("Isim").Value;
                string alis = item.Element("ForexBuying").Value;
                string satis = item.Element("ForexSelling").Value;
                Console.WriteLine($"{kod}-{isim}");
                Console.WriteLine($"Alış = {alis} TL-Satış = {satis} TL ");
            }
            

            #endregion
        }
    }
}
