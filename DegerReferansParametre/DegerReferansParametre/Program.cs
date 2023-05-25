using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerReferansParametre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KrediKarti Worldkart = new KrediKarti();
            Worldkart.KartNo = "1234";
            Worldkart.bakiye = 500;

            KrediKarti Bonuskart = new KrediKarti();
            Bonuskart.KartNo = "9876";
            Bonuskart.bakiye = 20000;

            Console.WriteLine("-------Başlangıç bilgileri------");
            Console.WriteLine("World kart");
            Console.WriteLine("kart no = " + Worldkart.KartNo);
            Console.WriteLine("bakiye = " + Worldkart.bakiye);
            Console.WriteLine("--Bonus kart ---");
            Console.WriteLine("Kart NO = " + Bonuskart.KartNo);
            Console.WriteLine("Bakiye = " + Bonuskart.bakiye);

            Worldkart.bakiye = 1500;


            Console.WriteLine("-----world kart bakiye 1500-----");
            Console.WriteLine("World kart");
            Console.WriteLine("kart no = " + Worldkart.KartNo);
            Console.WriteLine("bakiye = " + Worldkart.bakiye);
            Console.WriteLine("--Bonus kart ---");
            Console.WriteLine("Kart NO = " + Bonuskart.KartNo);
            Console.WriteLine("Bakiye = " + Bonuskart.bakiye);

            Worldkart.bakiye = Bonuskart.bakiye;
            //bonuskart.kartno = "1111"
            Console.WriteLine("--------değer ataması yapıldı---------");
            Console.WriteLine("World kart");
            Console.WriteLine("kart no = " + Worldkart.KartNo);
            Console.WriteLine("bakiye = " + Worldkart.bakiye);
            Console.WriteLine("--Bonus kart ---");
            Console.WriteLine("Kart NO = " + Bonuskart.KartNo);
            Console.WriteLine("Bakiye = " + Bonuskart.bakiye);

            Worldkart = Bonuskart;
            Bonuskart.KartNo = "1111";
            Console.WriteLine("---------referans ataması yapıldı--------");
            Console.WriteLine("World kart");
            Console.WriteLine("kart no = " + Worldkart.KartNo);
            Console.WriteLine("bakiye = " + Worldkart.bakiye);
            Console.WriteLine("--Bonus kart ---");
            Console.WriteLine("Kart NO = " + Bonuskart.KartNo);
            Console.WriteLine("Bakiye = " + Bonuskart.bakiye);

            #region erdal bakkalı opp ile kullanın

            #endregion

        }
    }
}
