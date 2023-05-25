using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarFunctions
{
    public class Cirak
    {
        public void selamver()
        {
            //metotlar ihtiyaç duyulduğunda çağırılmak üzere programlanan küçük program parçalarıdır
            Console.WriteLine("selam");
        }
        public void IsmeSelamVer(string isim)
        {
            //parametre alan metot
            Console.WriteLine("selam " + isim + " abi");
        }
        public void IsmeCokselamver(string isim,int adet)
        {
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine(isim + " abi ustanın çok selamı var");
            }
        }
        
    }
}
