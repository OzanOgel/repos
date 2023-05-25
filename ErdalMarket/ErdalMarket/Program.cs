using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdalMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Depo d = new Depo();
            double toplam = 0;
            #region ürünleri ekle
            Urun u = new Urun();
            u.isim = "Domates"; u.birim = "kg"; u.fiyat = 12.99; u.stok = 50;
            d.Ekle(u);
            Urun b = new Urun();
            b.isim = "Bezelye"; b.birim = "KG"; b.fiyat = 20; b.stok = 125;
            d.Ekle(b);
            Urun c = new Urun()
            {
                isim = "patlıcan",
                birim = "kg",
                fiyat = 25,
                stok = 120
            };
            d.Ekle(c);
            d.Ekle(new Urun() { isim = "doritos", birim = "paket", fiyat = 15, stok = 50 });
            #endregion

            Console.WriteLine("*-*-*-*-*-*-*-*-*-*--*Erdal Markete Hoş Geldiniz-*-*-*-*-*-*-*-*-*-*-*-");
            d.MenuYazdir();
            string secenek = "e";
            while (secenek == "e")
            {

            }


        }
    }
}
