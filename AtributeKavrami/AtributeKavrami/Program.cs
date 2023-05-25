using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtributeKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama
            //Attibute Tenel Olarak Soyut Kavramların en belirleyici özelliğidir
            //Attribute lar sınıflara,sınıf üyelerine(Metotlar fieldlar yapıcı metotlar ),arayüzlere enumlara delegatelere uygulabiliri
            //.net üzerinde tanımlı attributelar olduğu gibi kendimizde attribute tanımlayabiliriz
            //sadece com interlop ile ilgili işlemleri kullanılan sınıfla birlikte 20 bin üzerinde nitelik tanımlanmıştır
           
            Testsinifi ts = new Testsinifi();
            ts.MetotA();
            ts.MetotB();
            ts.MetotC();
            Console.ReadKey();

            #endregion
        }
    }
    public class Testsinifi
    {
        public void MetotA()
        {
            Console.WriteLine("A metotundan Merhbaba");
        }
        [Conditional("DEBUG")]
        public void MetotB()
        {
            Console.WriteLine("B metotundan Merhbaba");
        }
        public void MetotC()
        {
            Console.WriteLine("C metotundan Merhbaba");
        }
    }
}
