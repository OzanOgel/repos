using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PazarlamaCalisma
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Depo d = new Depo();
            #region ÜRÜN EKLEME
            #region ürün ekleme ÇamaşırMakinesi
            CamasirMakinesi cm = new CamasirMakinesi("vestel" , "ve100" , 12000, "c" , 20, "1" );
            d.ekle(cm);

            CamasirMakinesi cm2 = new CamasirMakinesi("bosch ", "boş13", 9999, "a+" , 10, "2");
            d.ekle(cm2);



            #endregion

            #region ürün ekleme BulaşıkMakinesi
            BulasikMakinesi bm = new BulasikMakinesi("tokiyato", "haşima3000", 17850, "a", 15, "3");
            d.ekle(bm);
            BulasikMakinesi bm2 = new BulasikMakinesi("beko" , "be3000" , 19500 , "b " , 20, "4");
            d.ekle(bm2);
            #endregion

            #region ürün ekleme Buzdolabi
            Buzdolabi bd = new Buzdolabi("makiyato", "espresso3000", 67965, "d", "5");
            d.ekle(bd);
            Buzdolabi bd2 = new Buzdolabi("decentraland", "mana", 25000, "a++++", "6");
            d.ekle(bd2);
            #endregion
            #endregion

            double toplam = 0;
            string secenek2 = "e";
            while (secenek2 == "e")
            {
                Console.WriteLine("1)Bulaşık Makineleri için 1 e basınız");
                Console.WriteLine("2)Çamaşır Makineleri için 2 ye basınız");
                Console.WriteLine("3) buzdolapları için 3 e basınız");
                Console.WriteLine("4) tümünü görmek için 4 e basınız");
                int secenek = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                
                Console.Clear();
                if (secenek == 1)
                {

                    d.listelebm();
                    Console.WriteLine("almak istediğniz ürünün ID sini yazınız");
                    int ID = Convert.ToInt32(Console.ReadLine());
                   if(d.fiyatgetir(ID) != 0)
                    {
                        toplam += d.fiyatgetir(ID);
                        Console.WriteLine("ürün sepete eklendi alışverişe devam etmek istermisiniz e/h");

                        secenek2 = Console.ReadLine();
                        Console.Clear();
                        
                    }
                   else
                    {
                        Console.WriteLine("yanlış ürün ID si girdiniz");
                        Console.Clear();

                    }
                    Console.Clear();
                    

                }
                else if (secenek == 2)
                {
                    d.listelecm();
                    Console.WriteLine("almak istediğniz ürünün ID sini yazınız");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    if(d.fiyatgetir(ID) != 0)
                    {
                        toplam += d.fiyatgetir(ID);
                        Console.WriteLine("ürün sepete eklendi alışverişe devam etmek istermisiniz e/h");
                        secenek2 = Console.ReadLine();
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.WriteLine("Yanlış ürün ID si girdiniz");
                        Console.Clear();
                    }
                }
                else if (secenek == 3)
                {
                    d.listelebd();
                    Console.WriteLine("almak istediğniz ürünün ID sini yazınız");
                    int ID = Convert.ToInt32(Console.ReadLine());
                   if( d.fiyatgetir(ID) != 0)
                    {
                        toplam += d.fiyatgetir(ID);
                        Console.WriteLine("ürün sepete eklendi alışverişe devam etmek istermisiniz e/h");
                        secenek2 = Console.ReadLine();
                        Console.Clear();
                        
                    }
                    else
                    {
                        Console.WriteLine("Yanlış ürün ID si girdiniz");
                        Console.Clear();
                    }
                }
                else if (secenek == 4)
                {
                    d.listeleTümü();
                    Console.WriteLine("almak istediğniz ürünün ID sini yazınız");
                    int ID = Convert.ToInt32(Console.ReadLine());
                   if(d.fiyatgetir(ID) != 0)
                    {
                        toplam += d.fiyatgetir(ID);
                        Console.WriteLine("ürün sepete eklendi alışverişe devam etmek istermisiniz e/h");
                        secenek2 = Console.ReadLine();
                        Console.Clear();
                        
                    }
                   else
                    {
                        Console.WriteLine("Yanlış ürün ID si girdiniz");
                        Console.Clear();

                    }

                    
                }
                Console.WriteLine("toplam = " + toplam);




            }
            
                    
                      

            
            

        }
    }
}
