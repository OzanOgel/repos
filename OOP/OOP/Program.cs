using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Gerçek hayatın simülize edilebilmesini sağlıyan yapıdır
            //Sınıflar içinde veri tutabilmek için Field lar barındırır
            //sınıfın nesnesi oluşmadığı sürece RAM üzerinde hiç var olmasz

            #endregion
            
            #region Sınıfın Nesnesini Tanımlama
            //ogrenci sınıfından referans alan ogr isminde nesne tanımlandı

            Ogrenci ogr = new Ogrenci();
            ogr.isim = "alp";
            ogr.soyisim = "sarıkışla";
            #endregion

            #region araba sınıfının nesnesini tanımlayalım
            araba oto = new araba();
            oto.marka = "ford";
            oto.model = "focus";
            oto.fiyat = 50000;
            Console.WriteLine(oto.marka +" " + oto.model + " " + oto.fiyat + " Dolar");
            #endregion
        }
        class Ogrenci
        {
            
            //Field
            //Public diğer sınıflardan erişilebilir Field lar oluşturur
            public string isim;
            public string soyisim;
            private int yaş;
            //private sadece ait olduğu alandan erişilebilir fieldlar oluşturur oluşturur
        }
    }
}
