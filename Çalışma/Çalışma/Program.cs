using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-Ozan Markete Hoş Geldiniz-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("");
            depo d = new depo();
            urun u = new urun();
            u.urunno = 1; u.fiyat = 20; u.isim = "domates"; u.birim = "KG";u.stok = 50;
            d.ekle(u);
            
            urun u2 = new urun();
            u2.urunno = 2; u2.fiyat = 20; u2.isim = "biber"; u2.birim = "KG"; u2.stok = 35;

            d.ekle(u2);

            urun u3 = new urun();
            u3.urunno = 3; u3.fiyat = 14; u3.isim = "Lays";u3.birim = "paket"; u3.stok = 100;
            d.ekle(u3);
            urun u4 = new urun();
            u4.urunno = 4; u4.fiyat = 5; u4.isim = "yumurta"; u4.birim = "Adet"; u4.stok = 200;
            d.ekle(u4);
            
            string secenek = "e";
            while(secenek == "e")
            {
                Console.WriteLine("toplam = " + toplam + "TL");
                d.menuyazdir();
                Console.WriteLine("satın almak istediğiniz ürün numarasını giriniz");
                
                
                


            }
                

            
                


        }
    }
}
