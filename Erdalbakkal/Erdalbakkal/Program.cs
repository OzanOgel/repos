using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Erdalbakkal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "domates", "biber", "yumurta", "ekmek", "soğan", "Doritos", "kola  " };

            double[] fiyatlar = { 9.25, 25.50, 2.30, 4, 11.45, 15.25, 21.30 };

            string[] Miktar = { "kilo", "kilo", "adet", "adet", "kilo", "adet", "şişe" };

            for (int i =0; i < isimler.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + isimler[i] + "\t" + fiyatlar[i] + "TL");
                    
            }
            #region uygulama 1 
            ////kaç ürün alıcaksın
            ////satın almak istediğiniz ürünün numarasını yazın
            ////toplam
            //double urun2 = 0;
            //Console.WriteLine("kaç tane ürün alcaksanız");
            //int kacurun = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < kacurun; i++)
            //{
            //    Console.WriteLine("satın almak istediğiniz ürün numarasını giriniz");
            //    int urun = Convert.ToInt32(Console.ReadLine());
            //    urun2 += fiyatlar[urun - 1];

            //}
            //Console.WriteLine("toplam = " + urun2 + "TL");



            #endregion

            #region Uygulama 2 
            //string secenek = "e";
            //double toplam = 0;
            //while(secenek == "e")
            //{
            //    Console.WriteLine("almak istediğiniz ürünün numarasını yazınız");
            //    int urunno = Convert.ToInt32(Console.ReadLine());

            //    toplam += fiyatlar[urunno - 1];

            //    Console.WriteLine("alışverişe devam edilsin mi ? e / h");
            //    secenek = Console.ReadLine();
            //}
            //Console.WriteLine("toplam = " + toplam + " tl ");
            #endregion

            #region uygulama 3 

            //double toplam = 0;
            //string evet = "e";
            //while (evet == "e")
            //{
            //    Console.WriteLine("almak istediğiniz ürün numarasını yazınız");
            //    int urunno = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("kaç tane almak istiyorsunuz");
            //    int kactane = Convert.ToInt32(Console.ReadLine());
            //    toplam += fiyatlar[urunno - 1] * kactane;
            //    Console.WriteLine("alışverişe devam edilsin mi ?");
            //    evet = Console.ReadLine();

            //}
            //Console.WriteLine("toplam = " + toplam + "tl");
            #endregion

            #region uygulama 4 
            //double toplam = 0;
            //string evet = "e";
            //while (evet == "e")
            //{
            //    Console.WriteLine("almak istediğiniz ürün numarasını yazınız");
            //    int urunno = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" kaç tane " + isimler[urunno - 1] + " alcaksınız ");
            //    int kactane = Convert.ToInt32(Console.ReadLine());
            //    toplam += fiyatlar[urunno - 1] * kactane;
            //    Console.WriteLine("alışverişe devam edilsin mi ?");
            //    evet = Console.ReadLine();

            //}
            //Console.WriteLine("toplam = " + toplam + "tl");
            #endregion

            #region ödev 1 miktar belirtme 
            //double toplam = 0;
            //string evet = "e";
            //while (evet == "e")
            //{
            //    Console.WriteLine("almak istediğiniz ürün numarasını yazınız");
            //    int urunno = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(" kaç  " + Miktar[urunno - 1] + " " + isimler[urunno - 1] + " alcaksınız ");
            //    int kactane = Convert.ToInt32(Console.ReadLine());
            //    toplam += fiyatlar[urunno - 1] * kactane;
            //    Console.WriteLine("alışverişe devam edilsin mi ?");
            //    evet = Console.ReadLine();

            //}
            //Console.WriteLine("toplam = " + toplam + "tl");

            #endregion

            #region dizi içerisindeki çift sayıların ortalaması
            //int[] sayılar = { 12, 25, 500, 323, 380, 15, 22, 16, 87 };
            //int cıfttoplam = 0;
            //int kacsayi = 0;
            //for(int j = 0; j < sayılar.Length;j++ )
            //{
            //    if(sayılar[j] % 2 == 0)
            //    {
            //        kacsayi++;
            //    }
            //    if (sayılar[j] % 2 == 0)
            //    {
            //        cıfttoplam += sayılar[j];
            //    }
            //}
            //Console.WriteLine("çift sayı ortalaması = " +(cıfttoplam / kacsayi));
            #endregion


        }
    }
}
