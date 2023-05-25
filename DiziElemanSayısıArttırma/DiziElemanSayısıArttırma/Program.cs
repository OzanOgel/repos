using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziElemanSayısıArttırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dolu dizinin eleman sayısı arttırılamaz

            //int[] sayılar = new int[10];
            //sayılar[0] = -123;

            //sayılar = new int[20];


            #endregion

            #region Peki Napcaz ?

            //int[] sayılar = new int[5];
            //sayılar[0] = 10;
            //sayılar[1] = 20;
            //sayılar[2] = 30;
            //sayılar[3] = 40;
            //sayılar[4] = 50;

            //int[] gecici = new int[sayılar.Length];
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    gecici[i] = sayılar[i];
            //}
            //sayılar = new int[6];
            //for (int i = 0; i < gecici.Length; i++)
            //{
            //    sayılar[i] = gecici[i];

            //}
            //sayılar[sayılar.Length - 1] = 60;


            #endregion

            #region konsoldan alınan isimleri diziye ekleyiniz başaramadık abi
            //string[] isimler = new string[1];
            //Console.WriteLine("isim giriniz");
            //isimler[0] = Console.ReadLine();
            //string[] gecicisim = new string[1];
            //for (int i = 0; i < 1; i++)
            //{
            //    isimler[i] = gecicisim[i];
            //}
            //int artandeger = 0;
            //string secenek = "";
            //while (secenek == "e")
            //{
            //    secenek = Console.ReadLine();
            //    artandeger++;

            //}
            //isimler = new string[artandeger];
            //for (int i = 0; i < gecicisim.Length; i++)
            //{
            //    isimler[i] = gecicisim[i];
            //}
            //isimler[isimler.Length - 1] = Console.ReadLine();



            #endregion

            #region konsoldan alınan isimleri diziye ekleyiniz
            string[] isimler = new string[0];
            string secenek = "e";
            while (secenek == "e")
            {
                Console.WriteLine("lütfen isim giriniz");
                string isim = Console.ReadLine();

                string[] gecici = new string[isimler.Length+1];
                Array.Copy(isimler, gecici, isimler.Length);
                gecici[gecici.Length - 1] = isim;

                isimler = gecici;
                Console.WriteLine("isim girilmeye devam edilsin mi ? e/h");
                secenek = Console.ReadLine();
                Console.Clear();

            }
            Console.WriteLine("Katılımcılar Listesi");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {isimler[i]}");
            }
                
            #endregion
        }
    }
}
