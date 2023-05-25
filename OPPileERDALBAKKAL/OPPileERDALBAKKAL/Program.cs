using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OPPileERDALBAKKAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun[] urunler = new Urun[7];
            Urun u1 = new Urun();
            u1.isimler = "Domates";
            u1.miktar = "kilo";
            u1.fiyat = 9.25;
            urunler[0] = u1;
            Urun u2 = new Urun();
            u2.isimler = "biber";
            u2.miktar = "kilo";
            u2.fiyat = 25.50;
            urunler[1] = u2;
            Urun u3 = new Urun();
            u3.fiyat = 2.30;
            u3.miktar = "adet";
            u3.isimler = "yumurta";
            urunler[2] = u3;
            Urun u4 = new Urun();
            u4.fiyat = 4;
            u4.isimler = "ekmek";
            u4.miktar = "adet";
            urunler[3] = u4;
            Urun u5 = new Urun();
            u5.isimler = "soğan";
            u5.fiyat = 11.45;
            u5.miktar = "kilo";
            urunler[4] = u5;
            Urun u6 = new Urun();
            u6.fiyat = 15.25;
            u6.miktar = "adet";
            u6.isimler = "doritos";
            urunler[5] = u6;
            Urun u7 = new Urun();
            u7.isimler = "kola";
            u7.miktar = "şişe";
            u7.fiyat = 21.30;
            urunler[6] = u7;
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + urunler[i].isimler + " \t " + urunler[i].fiyat + "TL");


            }


            double toplam = 0;
            string evet = "e";
            while (evet == "e")
            {
                Console.WriteLine("almak istediğiniz ürün numarasını yazınız");
                int urunno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" kaç  " + urunler[urunno - 1].miktar + " " + urunler[urunno - 1].isimler + " alcaksınız ");
                int kactane = Convert.ToInt32(Console.ReadLine());
                toplam += urunler[urunno - 1].fiyat * kactane;
                Console.WriteLine("alışverişe devam edilsin mi ?");
                evet = Console.ReadLine();

            }
            Console.WriteLine("toplam = " + toplam + "tl");







        }
    }
}
