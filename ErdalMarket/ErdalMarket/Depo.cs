using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ErdalMarket
{
    public class Depo
    {
        Urun[] urunler;

        public Depo()
        {
            urunler = new Urun[0];
        }

        public void Ekle(Urun eleman)
        {
            Urun[] gecici = new Urun[urunler.Length + 1];
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[gecici.Length - 1] = eleman;
            urunler = gecici;
        }
        public void MenuYazdir()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {urunler[i].isim} {urunler[i].fiyat} TL");
            }
            
        }
        
        
    }
}
