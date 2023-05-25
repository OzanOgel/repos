using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calişma2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            depo d = new depo();
            //isim,birim,fiyat,stok
            urun urun1 = new urun("Domates", "KG", 20, 50);
            
            d.ekle(urun1);
            urun urun2 = new urun("Biber", "KG", 25, 80);
            d.ekle(urun2);
            urun urun3 = new urun("Lays", "Paket", 15, 150);
            d.ekle(urun3);
            d.menuyazdir();
            
            
        }
    }
}
