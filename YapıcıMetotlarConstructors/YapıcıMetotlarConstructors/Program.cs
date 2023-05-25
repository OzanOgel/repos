using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetotlarConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tanımlama

            //Sınıfın Nesnesi tanımlandığı anda otomatik olarak çalışan metotlara Constructor denir
            //Constructorlar ın geri dönüş türü olmaz
            //Constructor adı mutlaka ait olduğu sınıf adıyla aynı olmalıdır.

            #endregion


            #region kitaplar
            //Kitap k = new Kitap();
            //k.isim = "nefis yemek tarifleri";
            //k.yazar = "anonim";
            //k.fiyat = 500;

            //Console.WriteLine(k.isim + " " + k.OlusturmaTarihi + " " + k.durum);

            //Kitap kk = new Kitap();
            //kk.isim = "enfes yemek tarifleri";
            //kk.yazar = "Fuzili";
            //kk.fiyat = 500;
            //kk.durum = "Satışta Değil";

            //Console.WriteLine(kk.isim + " " + kk.OlusturmaTarihi + " " + kk.durum);
            #endregion

            #region sinif
            Sınıf s = new Sınıf(20);
            s.isim = "302";
            s.Dersadi = "web yazılım uzmanlığı";
            Console.WriteLine(s.yazdır());
            Sınıf ss = new Sınıf(50);
            ss.isim = "101";
            ss.Dersadi = "matematik";
            Console.WriteLine(ss.yazdır());

            #endregion

        }
    }
}
