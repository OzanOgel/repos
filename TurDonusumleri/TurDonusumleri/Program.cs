using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Bilinçsiz Tür Dönüşümleri
            //bit aralığı olarak küçük türlerin büyük türlere dönüşmesi olayıdır 

            //byte s1 = 100;
            //byte s2 = 200;

            //int toplam = s1 + s2;
            //Console.WriteLine(toplam);
            #endregion

            #region Bilinçli Tür Dönüşümleri
            //Bit aralığı olarak büyük verilerin küçük verilere dönüşmeye ZORLANMASI olayıdır
            //int s1 = 1587;

            //byte s2 = (byte)s1;

            //Console.WriteLine(s2);




            #endregion

            #region Uyumsuz Tür Dönüşümü
            //string strsayi1 = "12";
            //string strsayi2 = "25";

            //int sayi1= Convert.ToInt32(strsayi1);
            //int sayi2= Convert.ToInt32(strsayi2);

            //int toplam = sayi1 + sayi2;
            //Console.WriteLine(toplam);





            #endregion

            #region Console dan veri almak
            // consoldan veri almak için Console.ReadLine(); kullanılır

            //Console.WriteLine("Lütfen Bir Sayı Giriniz ");
            //string strsayi1 = Console.ReadLine();
            //int s1 = Convert.ToInt32(strsayi1);

            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int s2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = s1 + s2;
            //Console.WriteLine("toplam = " + toplam);


            #endregion

            #region Konsoldan Alınan Verinin Toplam, fark ,çarpım ,bölüm sonuçlarını yazdırın
            //Console.WriteLine("lütfen 1.sayıyı giriniz");
            //double s1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz");
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //double toplam = s1 + s2;
            //Console.WriteLine("toplam = " + toplam);
            //double fark = s1 - s2;
            //Console.WriteLine("fark = " + fark);
            //double carpim = s1 * s2;
            //Console.WriteLine("Çarpım = " + carpim);

            //double bolum = s1 / s2;
            //Console.WriteLine("Bölüm = "+ bolum);





            #endregion

            #region Konsoldan alınan 1.sınav notu 2.sınav notu ve sözlü notunun ortalamasını yazınız
            //Console.WriteLine("Lütfen 1. sınav notunu yazınız");
            //double s1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("lütfen 2. sınav notunu yazınız");
            //double s2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("lütfen sözlü notunu yazınız");
            //double s3 = Convert.ToDouble(Console.ReadLine());

            //double toplam = s1 + s2 + s3;

            //double ortalama = (toplam) / 3;

            //Console.WriteLine(" ortalama = " + ortalama);
            #endregion

            #region ÖDEV 1 Öğrencilerin vize ve Final notunu alıp ortalamasını hesaplayınız(40 a 60 kuralı)
            Console.WriteLine("lütfen vize notunu yazınız");
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("lütfen final notunu yazınız");
            double c2 = Convert.ToDouble(Console.ReadLine());

            double vize = c1 * 40 / 100;
            double final = c2 * 60 / 100;
            double sonuç = vize + final;

            Console.WriteLine(" öğrencinin vize ve final ortalaması " + sonuç);

            #endregion

            #region Konsoldan alınan sayı çift mi 

            //Console.WriteLine("Lütfen sayıyı giriniz");
            //int s1 =Convert.ToInt32(Console.ReadLine());
            //int kalan = s1 % 2;
            //bool sonuç = kalan == 0;
            //Console.WriteLine(" girilen sayı çift mi = " + sonuç);

            #endregion

            #region konsoldan alının sayı 10 dan büyükmü 
            //Console.WriteLine("lütfen sayıyı giriniz");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //bool sonuç = s1 > 10;
            //Console.WriteLine("sayı 10 dan büyük mü = " + sonuç);
            #endregion

            #region konsoldan alınan sayı 10 ile 20 arasındamı
            //Console.WriteLine("lütfen bir sayı giriniz agam ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //bool s10 = s1> 10 && s1 < 20;
            //Console.WriteLine("sayı 10 ile 20 arasındamı = " + s10);


            #endregion

            #region Konsoldan alının sayı 10 ile 20 aralığı dışında mı ?
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int s1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("sayı 10 ve 20 değerinin dışındamı =  " + !(s1 > 10 && s1 < 20));

            #endregion
            
            
            








        }
    }
}
