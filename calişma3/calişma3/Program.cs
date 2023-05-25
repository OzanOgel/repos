using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calişma3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            depo d = new depo();
            double toplam = 0;

            urun u = new urun();
            u.isim = "Domates"; u.birim = "KG"; u.fiyat = 12.99; u.stok = 50;

            d.ekle(u);

            urun b = new urun();
            b.isim = "Bezelye"; b.birim = "KG"; b.fiyat = 20; b.stok = 125;

            d.ekle(b);

            urun c = new urun() { isim = "Patlıcan", birim = "KG", fiyat = 25, stok = 120 };
            d.ekle(c);

            d.ekle(new urun() { isim = "Doritos", birim = "Paket", fiyat = 15, stok = 50 });

            string secenek = "e";


            string fişisim = "";
            
            while(secenek == "e")
            {
                Console.WriteLine("Toplam = " + toplam + " TL");
                d.menuyazdır();
                Console.WriteLine("almak istediğiniz ürünün numarasını yazınız");
                int no = Convert.ToInt32(Console.ReadLine());
                
                
                Console.WriteLine("kaç " + d.birimgetir(no) + " alacaksınız");
                int adet = Convert.ToInt32(Console.ReadLine());
                
                

                Console.WriteLine(d.FiyatGetir(no) * adet +"TL");

                toplam += d.SatinAl(no, adet) * adet;
                
                Console.WriteLine("alışverişe devam edilsin mi?(e/h)");

                secenek = Console.ReadLine();
                
                
                Console.Clear();
                for (int i = 0; i < d.urunlerlengt(); i++)
                {
                    if(secenek == "h")
                    {
                        fişisim += d.fişisim(no);
                    }
                }

                

            }
            







        }
    }
}
