using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace calişma3
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
            Array.Copy(urunler, gecici, urunler.Length);
            gecici[gecici.Length - 1] = eleman;
            urunler = gecici;

        }
        public void menuyazdır()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
               if (urunler[i].stok > 0)
                {
                    
                    Console.WriteLine((i+1)+") " + urunler[i].isim + "\t" + urunler[i].fiyat + " TL\t- stok = " + urunler[i].stok);
                }
                else
                {
                    Console.WriteLine((i + 1) + ") " + urunler[i].isim + "\t" + urunler[i].fiyat + " TL\t- stok = " + "STOK BİTMİŞTİR");
                }
            }


        }
        public double FiyatGetir(int uruno)
        {
            double fiyat = 0;
            if (urunler[uruno-1].stok >= 0 )
            {
                 fiyat = urunler[uruno - 1].fiyat;
            }
            else
            {
                fiyat = 0;
            }
            return fiyat;
            
            
                
            
            
        }

        public string birimgetir(int urunno)
        {
            return urunler[urunno - 1].birim;
        }
        public double SatinAl(int uruno, int adet)
        {
            double fiyat = 0;
            if (urunler[uruno - 1].stok >= adet)
            {
                fiyat = urunler[uruno - 1].fiyat;
                urunler[uruno - 1].stok -= adet;
            }
            else
            {
                Console.WriteLine("Stok Yetersiz");
            }
            return fiyat;

        }
        public int urunlerlengt()
        {
            int urunlerlengt = urunler.Length;
            return urunlerlengt;
        }
        public string fişisim(int urunno)
        {
            string isim = urunler[urunno - 1].isim;
            return isim;
        }
       
       
        

    }
    
    

    
}
