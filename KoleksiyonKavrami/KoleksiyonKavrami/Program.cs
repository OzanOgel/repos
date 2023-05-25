using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KoleksiyonKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("selam");
            liste.Add("Naber");
            liste.Add("iyidir");
            liste.Add("Senden Naber");
            liste.Add("Havalar Nasıl");
            liste.Insert(3, "ben geldimm");
            liste.Add(12.99);

            Personel prs = new Personel();
            prs.İsim = "Alp";
            prs.Soyİsim = "Sarıkışla";
            liste.Add(prs);
            liste.Remove("iyidir");//dizideki iyidir verisini sil
            liste.RemoveAt(1);//1.indexteki veriyi sil
            liste.RemoveRange(0, 2);//0.indexten başla 2 tane sil
                                    ////Silinen verinin bulunduğu index boş kalmaz 

            Console.WriteLine("Liste Eleman Sayısı = " + liste.Count);
            Console.WriteLine("Liste Kapasitesi = " + liste.Capacity);
            liste.TrimToSize();
            Console.WriteLine("Liste Eleman Sayısı = " +liste.Count);
            Console.WriteLine("liste kapasitesi = " + liste.Capacity);

            Console.WriteLine("Hello var mı = " + liste.Contains("hello")+ " " + liste.IndexOf("hello")) ;//liste içerisinde hello var mı
            Console.WriteLine("selam var mı = " + liste.Contains("selam") + " " + liste.IndexOf("selam"));//liste içerisinde selam var mı

            //liste.Sort();
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[i].GetType() == typeof(Personel))
                {
                    Personel p2 = (Personel)liste[i];
                    Console.WriteLine(p2.İsim + " " + p2.Soyİsim);
                }
                else
                {
                    Console.WriteLine(liste[i]);
                }
            }
            //Console.WriteLine("----------");
            //liste.Reverse();
            //for (int i = 0; i < liste.Count; i++)
            //{
            //    Console.WriteLine(liste[i]);
            //}


        }
    }
}
