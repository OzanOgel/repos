using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region tanımlama
            ////dizi -Array
            ////aynı türden verilerin bir arada tutulmasını sağlayan yapıya dizi denir
            //int[] sayilar = new int[5];
            ////5 elemanlı tamsayı dizisi
            //sayilar[0] = 55;
            //sayilar[1] = 48;
            //sayilar[2] = -20;
            //sayilar[3] = 22;
            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}




            #endregion

            #region tanımlama 2
            //string[] öğrenciler = new string[10];
            //öğrenciler[0] = "Hasan Hüseyin";
            //öğrenciler[1] = "Anıl";
            //öğrenciler[2] = "Abdullah";
            //öğrenciler[3] = "Merdan";
            //öğrenciler[4] = "Ozan";
            //öğrenciler[5] = "Yusuf İslam";
            //öğrenciler[6] = "Oktay";
            //öğrenciler[7] = "Hacı Mustafa";
            //öğrenciler[8] = "Melike";
            //öğrenciler[9] = "ecem";
            //// öğrenciler[10] = "alp"; yapılamaz
            //for (int i = 0; i < öğrenciler.Length; i++)
            //{
            //    Console.WriteLine(öğrenciler[i]);
            //}


            #endregion

            #region tüm elemanları yazdırınız
            int[] sayilar = { 12, 321, 43, 54, -549, 05, 48, -854, 458 };
            //for(int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion
            #region dizi içindeki pozitif sayıları yazdırınız
            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayilar[i] > 0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
            #endregion

        }
    }
}
