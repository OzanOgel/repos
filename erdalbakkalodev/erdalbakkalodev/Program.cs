using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erdalbakkalodev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "domates", "biber", "yumurta", "ekmek", "soğan", "Doritos", "kola  " };

            double[] fiyatlar = { 9.25, 25.50, 2.30, 4, 11.45, 15.25, 21.30 };

            int[] stok = { 20, 10, 30, 4, 6, 9, 11 };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + isimler[i] + "\t" + fiyatlar[i] + "TL");

            }


            #region ödev

            
            double toplam = 0;
            string evet = "e";
            int[] kactanedizi = { 0, 0, 0, 0, 0, 0, 0 };
            while (evet == "e")
            {
                Console.WriteLine("almak istediğiniz ürün numarasını yazınız");
                int urunno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" kaç tane " + isimler[urunno - 1] + " alcaksınız ");
                
                int kactane = Convert.ToInt32(Console.ReadLine());
                kactanedizi[urunno - 1] += kactane;
                int kalanstok = stok[urunno - 1] - kactanedizi[urunno - 1];
                if (kalanstok < 0)
                    Console.WriteLine("stok bitmiştir");

                
                
                
                toplam += fiyatlar[urunno - 1] * kactane;
                Console.WriteLine("alışverişe devam edilsin mi ?");
                evet = Console.ReadLine();
                
            }
            Console.WriteLine("toplam = " + toplam + "tl");
            #endregion
        }
    }
}
