using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    internal class Matematik
    {
        //sayının karesini yazdıran metodu yazdırınız
        public void KareAl(int sayi)
        {
            int kare = sayi * sayi;
            Console.WriteLine("sayının karesi = " + kare);
        }
        public void ikisayitoplam(int sayi,int sayi2)
        {
            int toplam = sayi + sayi2;
            Console.WriteLine( "toplam = "+ toplam);
                
               
        }
        public int Cikarma(int s1,int s2)
        {
            int fark = s1 - s2;
            return fark;
        }
        //sayının üssünü alan metot 
        public int UsAl(int taban , int us)
        {
            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            return sonuc;
        }
        // %18 kdv dahil fiyatı döndüren metot
        public int kdvdahil(int kdvsiz)
        {
            int kdvdahil = (kdvsiz*18/100) + kdvsiz;
            return kdvdahil;
        }

    }
}
