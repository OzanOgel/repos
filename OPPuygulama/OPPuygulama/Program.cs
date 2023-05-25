using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPuygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba[] arabalar = new araba[10];
            //Nesnesi oluşturulmamış 10 adet boş yer açar
            araba a1 = new araba();
            a1.marka = "Audi";
            a1.model = "A1";
            a1.yil = 2010;
            a1.fiyat = 500000;
            arabalar[0] = a1;

            arabalar[1] = new araba();
            arabalar[1].marka = "Audi";
            arabalar[1].model = "a3";
            arabalar[1].yil = 2010;
            arabalar[1].fiyat = 550000;

            araba pixel = new araba();
            pixel.marka = "fiat";
            pixel.model = "doblo";
            pixel.yil = 2010;
            pixel.fiyat = 700000;
            arabalar[2] = pixel;

            araba megapixel = new araba();
            megapixel.marka = "WolksVagen";
            megapixel.model = "amorak";
            megapixel.yil = 2018;
            megapixel.fiyat = 1500000;
            arabalar[3] = megapixel;

            araba hayal = new araba();
            hayal.marka = "GMC";
            hayal.model = "Truck";
            hayal.yil = 2020;
            hayal.fiyat = 5000000;
            arabalar[4] = hayal;

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(arabalar[i].marka + " " arabalar[i].model);
            //}
            


            foreach(araba item in arabalar)
            {
                if(item.fiyat >= 1000000)
                {
                    Console.WriteLine(item.marka + item.model);
                }
                    

                
            }





        }
    }
}
