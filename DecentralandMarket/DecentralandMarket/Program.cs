using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentralandMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region urunekle
            Depo d = new Depo();
            Urun u = new Urun();
            u.isim = "su"; u.fiyat = 3; u.birim = "şişe";u.stok = 500;
            d.ekle(u);
            Urun u2 = new Urun();
            u2.isim = "kola";u2.fiyat = 25; u2.birim = "şişe"; u2.stok = 55;
            d.ekle(u2);
            Urun u3 = new Urun();
            u3.isim = "ekmek"; u3.birim = "adet"; u3.fiyat = 4; u3.stok = 95;
            d.ekle(u3);






            #endregion
            Console.WriteLine("-*-*-*-*-*-*-Decentraland Markete Hoşgeldiniz-*--*-*-*-*--*-");
            string secenek = "e";
           while(secenek =="e")
            {
                d.MenüYazdir();
            }
        }
    }
}
