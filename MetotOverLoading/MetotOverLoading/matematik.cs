using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotOverLoading
{
    internal class matematik
    {
        public void topla(int s1 , int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("toplam = " +toplam);

        }
        public void topla(string s1 , string s2)
        {
            int sayi1 = Convert.ToInt32(s1);
            int sayi2 = Convert.ToInt32(s2);
            int toplam = sayi1 + sayi2;
            Console.WriteLine("toplam = " + toplam);
        }
        public void topla(double s1, double s2)
        {
            double toplam = s1 + s2;
            Console.WriteLine("toplam = " + toplam);
        }
        public void topla(int sayi1,int sayi2,int sayi3)
        {
            int toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine("toplam = " + toplam);
        }
        public void topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }
            Console.WriteLine("toplam = " + toplam);
        }
    }
}
