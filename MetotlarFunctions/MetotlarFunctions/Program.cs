using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region cırak
            //Cirak alp = new Cirak();
            //alp.selamver();
            //alp.IsmeSelamVer("murat");


            //Console.WriteLine("isim yazınız");
            //string veri = Console.ReadLine();

            //alp.IsmeSelamVer(veri);
            //alp.IsmeCokselamver(veri,7);
            #endregion
            #region matematik  
            Matematik mat = new Matematik();
            mat.KareAl(4);
            mat.ikisayitoplam(4, 8);
            int sonuc = mat.Cikarma(20, 5);
            Console.WriteLine("sonuç = " + sonuc);

            Console.WriteLine(mat.UsAl(2,5));
            Console.WriteLine(mat.kdvdahil(50));
            #endregion

        }
    }
}
