using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba<string> ar = new araba<string>();
            ar.Marka = "FIAT";
            ar.Model = "DOBLO";
            ar.Yil = "2009";

            araba<int> ar2 = new araba<int>();
            ar2.Marka = "VW";
            ar2.Model = "AMOROK";
            ar2.Yil = 2016;


            Console.WriteLine(DateTime.Now.Year - ar2.Yil);
            Araç<string,double> a = new Araç<string,double>();
        }
    }
    public class araba<T>
    {
        public string Marka;
        public string Model;
        public T Yil;

    }
    public class Araç<T,Y>
    {
        public T field1;
        public T field2;
        public Y field3;
    }
}
