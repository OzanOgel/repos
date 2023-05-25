using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongulerline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama 

            //Bir döngünün sağlıklı bir biiçmde oluşması için 
            //başlangıç değeri 
            //koşul(döngüyü kırabilmek için)
            //artış miktarı(iterasyon)

            //int sayi = 10;
            //while (sayi == 10)
            //{
            //    Console.WriteLine("çalıştı");

            //}
            //Console.WriteLine("döngü alanı dışı bölge");

            #endregion

            #region 0-10 arasındaki sayıları yazdırın
            //int sayac = 0;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine(sayac);
            //    //sayac = sayac + 1;
            //    //sayac += 1;
            //    sayac++;
            //}
            //Console.WriteLine("tamamlandı");
            #endregion

            #region 0-10 arasındaki çift sayıları yazdırınız
            //int sayac = 0;
            //while (sayac <= 10)
            //{

            //    if(sayac % 2 == 0)
            //    {
            //        Console.WriteLine(sayac);
            //    }      
            //    sayac++;
            #endregion
            #region 0-10 arasındaki pozitif sayılır
            //int sayi = 0;
            //while(sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;

            //}


            #endregion

            #region 0 - 100 arasındaki 4 e kalansız bölünebilen sayılar
            //int sayi = 0;
            //while (sayi <= 100)
            //{
            //    if (sayi % 4 == 0)
            //    {
            //        Console.WriteLine(sayi);

            //    }
            //    sayi++;
            //}

            #endregion

            #region çarpım tablosunun 3 ler basamağını yazdırın
            //int sayi = 0;
            //while(3 * sayi <= 27)
            //{
            //    Console.WriteLine("3 x " + sayi + "=" + (3 * sayi));
                
            //    sayi++;
            //}
            #endregion

            #region ÖDEVLER
            #region 0 - 100 arasında 4 e kalansız bölünen kaç sayı var 

            //int sayac = 0;
            //int kactane = 0;
            //while(sayac <= 100)
            //{
            //    if(sayac % 4 == 0)
            //        {
            //        kactane++;
            //    }
            //    sayac++;
            //}
            //Console.WriteLine(kactane);


            #endregion
            #region çarpım tablosunun kullanıcıdan alınan basamağını yazdırın
            Console.WriteLine("lütfen basamak değerini giriniz");
            int basamak = Convert.ToInt32(Console.ReadLine());
            int sayac = 1;
            while(sayac <= 10)
            {
                Console.WriteLine(basamak + " x " + " = " + (basamak + sayac));
                sayac++;
            }



            #endregion
                #region fibonatci serisinin başından 20 ye kadar yazdırın 
                //olay şu her sonuç kendinden önceki iki sayının toplamı 
                #endregion
                #endregion




        }
    }
}
