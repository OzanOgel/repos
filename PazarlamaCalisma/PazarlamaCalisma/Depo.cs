using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PazarlamaCalisma
{
    public class Depo
    {
        CamasirMakinesi[] CamasirMakineleri;
        BulasikMakinesi[] BulasikMakineleri;
        Buzdolabi[] Buzdolaplari;

        public Depo()
        {
            CamasirMakineleri = new CamasirMakinesi[0];
            BulasikMakineleri = new BulasikMakinesi[0];
            Buzdolaplari = new Buzdolabi[0];
        }
        public void ekle(Buzdolabi buzdolabi)
        {
            Buzdolabi[] geçici = new Buzdolabi[Buzdolaplari.Length + 1];
            Array.Copy(Buzdolaplari, geçici, Buzdolaplari.Length);
            geçici[geçici.Length -1] = buzdolabi;
            Buzdolaplari = geçici;
        }
        public void ekle(CamasirMakinesi camasirMakinesi)
        {
            CamasirMakinesi[] gecici = new CamasirMakinesi[CamasirMakineleri.Length + 1];
            Array.Copy(CamasirMakineleri, gecici, CamasirMakineleri.Length);
            gecici[gecici.Length -1] = camasirMakinesi;
            CamasirMakineleri = gecici;

        }
        public void ekle(BulasikMakinesi bulasikMakinesi)
        {
            BulasikMakinesi[] gecici = new BulasikMakinesi[BulasikMakineleri.Length+1];
            Array.Copy(BulasikMakineleri,gecici, BulasikMakineleri.Length);
            gecici[gecici.Length-1] = bulasikMakinesi;
            BulasikMakineleri= gecici;

        }
        public void listelebm()
        {
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine(BulasikMakineleri[i].Yazdir());
            }
        }
        public void listelecm()
        {
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine(CamasirMakineleri[i].Yazdir());
            }
        }
        public void listelebd()
        {
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine(Buzdolaplari[i].Yazdir());
            }
        }
        public void listeleTümü()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-*-*-*-ÇAMAŞIR MAKİNELERİ-*-*-*-*-");
            Console.ResetColor();
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine(CamasirMakineleri[i].Yazdir());
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-*-*-*-*-BULAŞIK MAKİNELERİ-*-*-*-*-*-");
            Console.ResetColor();
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine(BulasikMakineleri[i].Yazdir());
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("-*-*-*-*-BUZDOLAPLARI-*-*-*-*-*-");
            Console.ResetColor();
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine(Buzdolaplari[i].Yazdir());
            }
            

        }
        public double fiyatgetir(int  ıd)
        {
            for (int i = 0; i < CamasirMakineleri.Length; i++)
            {
                if (ıd == Convert.ToInt32(CamasirMakineleri[i].ID))
                {
                    return CamasirMakineleri[i].fiyat;
                }
                
            }
            for (int i = 0; i < BulasikMakineleri.Length; i++)
            {
                if (ıd == Convert.ToInt32(BulasikMakineleri[i].ID))
                {
                    return BulasikMakineleri[i].fiyat;
                }
                

            }
            for (int i = 0; i < Buzdolaplari.Length; i++)
            {
                if (ıd == Convert.ToInt32(Buzdolaplari[i].ID))
                {
                    return Buzdolaplari[i].fiyat;
                }
               
                
            }
           return 0;
            
                    

            
        }
        
        
        
        
    }
}
