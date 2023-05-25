using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XMLserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Bir nesnedeki veya koleksiyondaki verilerin bir yerde depolanması ve ağ ortamından bir yerden bir yere gönderilmesi gerektiği
            //durumlarda uygun formata dönüştürülmesi işlemine serileştirme denir.
            #endregion

            #region Binary Serialization
            //byte[] serilestirilmis = BinarySerialization("Guberetleri Guplatmayın");
            //foreach(byte item in serilestirilmis)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();


            //Console.WriteLine("*-*-*-*-*-*-*--*--*-*-*-*-*-*-*-*-*-*-");
            //object gelenveri = BinarydeSeralize(serilestirilmis);
            //Console.WriteLine(gelenveri.ToString());

            #endregion

            #region Json Serialization
            //string serilestirilmis = JsonSeralize("merhaba napinüz");
            //Console.WriteLine(serilestirilmis);


            //Personel p2 = new Personel();
            //p2.isim = "Hüseyin";
            //p2.soyad = "badak";
            //p2.departman = "IT";
            //p2.yas = 5;
            //List<Personel> personeller = new List<Personel>();
            //personeller.AddRange(new Personel[] { p, p2 });
            //string serilestirilmis = JsonSeralize(personeller);
            //Console.WriteLine(serilestirilmis);
            #endregion

            #region SoapSerialition
            //Personel p = new Personel();
            //p.isim = "Alp";
            //p.soyad = "Sarıkıpşla";
            //p.departman = "komi";
            //p.yas = 26;
            //string serilestirilmis = Soapserialize(p);
            //Console.WriteLine(serilestirilmis);
            #endregion

            #region xMLsERİALZİR
            Personel p = new Personel();
            p.isim = "Alp";
            p.soyad = "Sarıkıpşla";
            p.departman = "komi";
            p.yas = 26;
             string serileştirilmiş = XMlserializer(p);
            Console.WriteLine(serileştirilmiş);


            #endregion



        }
        public static byte[] BinarySerialization(object data)
        {
            var stream = new MemoryStream();
            var formater = new BinaryFormatter();
            formater.Serialize(stream, data);
            return stream.ToArray();
        }
        public static object BinarydeSeralize(byte[] data)
        {
            var stream = new MemoryStream(data);
            var formater = new BinaryFormatter();
            return formater.Deserialize(stream);
        }

        public static string JsonSeralize(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
        public static object JsonDeSeralize(string data)
        {
            return JsonConvert.DeserializeObject(data);
        }

        public static string Soapserialize(object data)
        {
            MemoryStream ms = new MemoryStream();
            var formatter = new SoapFormatter();
            formatter.Serialize(ms, data);
            return Encoding.UTF8.GetString(ms.GetBuffer(),0,(int)ms.Position);

        }
        public static object SoapDeSerialize(string data)
        {
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(data));
            var formatter = new SoapFormatter();
            return formatter.Deserialize(ms);

        }
        public static string XMlserializer(object data)
        {
            XmlSerializer serilestirici = new XmlSerializer(typeof(Personel));
            TextWriter tw = new StringWriter();
            serilestirici.Serialize(tw, data);
            return tw.ToString();

        }
        public static Personel XMLDeSerialize(string data)
        {
            XmlSerializer serilestirici = new XmlSerializer(typeof(Personel));
            StringReader sr = new StringReader(data);
            XmlReader xr = new XmlTextReader(sr);
            Personel p = new Personel();
            if (serilestirici.CanDeserialize(xr))
            {
                p = (Personel)serilestirici.Deserialize(xr);
            }
            return p;
        }

    }
}
