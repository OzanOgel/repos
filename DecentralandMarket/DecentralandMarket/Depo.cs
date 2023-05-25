using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentralandMarket
{
    public class Depo
    {
        Urun[] urunler;

        public Depo()
        {
            urunler = new Urun[0];
        }
        public void ekle(Urun urun)
        {
            Urun[] gecici = new Urun[urunler.Length + 1 ];
            Array.Copy(urunler,gecici,urunler.Length);
            gecici[urunler.Length-1] = urun;
            urunler = gecici;


        }
        public void MenüYazdir()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{i + 1} {urunler[i].isim}\t{urunler[i].fiyat} TL\t- Stok = {urunler[i].stok}");
            }
        }
        public double fiyatgetir( int urunno)
        {
            double fiyat = urunler[urunno - 1].fiyat;

            return fiyat;


        }
        public string birimgetir(int urunno)
        {
            return urunler[urunno - 1].birim;
        }

        

        

        
    }
}
