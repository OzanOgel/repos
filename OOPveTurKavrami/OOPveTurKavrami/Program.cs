using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPveTurKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region giriş
            ogrenci[] ogrenciler = new ogrenci[2];

            //HER SINIF AYNI ZAMANDA BİR TÜRDÜR
            //C# Tür Güvenliğine Çok Önem Veren Bir Dildir
            //ogrenci ogr1 = new ogrenci();
            //ogr1.isim = "Hacı Mustafa";
            //ogr1.soyisim = "Sarıkatipoğlu";
            //ogr1.gmsno = "05558306199";
            //ogr1.dogumyili = 1985;
            //ogrenciler[0] = ogr1;

            //ogrenci ogr2 =new ogrenci();
            //ogr2.isim = "Oktay";
            //ogr2.soyisim = "Çalışkan";
            //ogr2.gmsno = "05425450437";
            //ogr2.dogumyili = 2001;
            //ogrenciler[1] = ogr2;
            //for(int i =0; i < ogrenciler.Length; i++)
            //{
            //    Console.WriteLine(ogrenciler[i].isim);


            //}
            Müşteri_verisi[] müşteriler = new Müşteri_verisi[2];
            Müşteri_verisi m1 = new Müşteri_verisi();
            m1.isimSoyisim = "ozan ögel";
            m1.yaş = 17;
            m1.yatırım = 700;
            müşteriler[0] = m1;
            Müşteri_verisi m2 = new Müşteri_verisi();
            m2.isimSoyisim = "boşver kardeş";
            m2.yaş = 32;
            m2.yatırım = 15000;
            müşteriler[1] = m2;
            

            for (int i = 0; i <müşteriler.Length ; i++)
            {
                Console.WriteLine("-*-*-*-*-*YATIRIMCI " +(i+1) + "*-*-*-*-*-");
                Console.WriteLine("isim soy isim = " + müşteriler[i].isimSoyisim);
                Console.WriteLine("yaş = " + müşteriler[i].yaş);
                Console.WriteLine("yatırım miktarı = " + müşteriler[i].yatırım);
            }



                
          
            
            #endregion
        }
    }
}
