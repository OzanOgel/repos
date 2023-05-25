using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazarlamaCalisma
{
    public class Buzdolabi
    {
        public string marka;
        public string model;
        public double fiyat;
        public string enerjisınıfı;
        public String ID;

        public Buzdolabi(string marka, string model, double fiyat, string enerjisınıfı, string ıD)
        {
            this.marka = marka;
            this.model = model;
            this.fiyat = fiyat;
            this.enerjisınıfı = enerjisınıfı;
            ID = ıD;
        }
        public string Yazdir()
        {
            return $"Marka={marka} Model={model}\n Enerji Sınıfı={enerjisınıfı}\nFiyat={fiyat} ID ={ID}";
        }
    }
}
