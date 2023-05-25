using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Çalışma
{
    public class depo
    {
        urun[] urunler;
        public depo()
        {
            urunler = new urun[0];
        }
        public void ekle(urun eleman)
        {
            urun[] gecici = new urun[urunler.Length + 1];
            Array.Copy(urunler,gecici,urunler.Length);
            gecici[gecici.Length - 1] = eleman;
            urunler = gecici;

        }
        public void menuyazdir()
        {

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunno +")" + urunler[i].isim + "  \t " + urunler[i].fiyat );
            }
            
        }
        

    }
}
