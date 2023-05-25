using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenerikKoleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            p1.İsim = "Alp";
            p1.Soyad = "sarıkışla";
            p1.TelefonNumarasi = "0530324454432";
            p1.Yaş = 26;

            Personel p2 = new Personel();
            p2.İsim = "Şuayip";
            p2.Soyad = "Karaoğlu";
            p2.TelefonNumarasi = "05398454432";
            p2.Yaş = 38;

            List<Personel> personeller = new List<Personel>();
            personeller.Add(p1);
            personeller.Add(p2);
            Console.WriteLine("Elemen Sayısı = " + personeller.Count);
            for (int i = 0; i < personeller.Count; i++)
            {
                Console.WriteLine(personeller[i].İsim + " "+ personeller[i].Soyad);
            }
        }
    }
}
