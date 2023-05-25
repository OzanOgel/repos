using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PazarlamaCalisma
{
    public class CamasirMakinesi
    {
        public string marka;
        public string model;
        public double fiyat;
        public string enerjisınıfı;
        public int yıkamakapasitesi;
        public string ID;
        public CamasirMakinesi(string marka , string model, double fiyat, string enerjisınıfı, int yıkamakapasitesi, string ıD)
        {
            this.marka = marka;
            this.model = model;
            this.fiyat = fiyat;
            this.enerjisınıfı = enerjisınıfı;
            this.yıkamakapasitesi = yıkamakapasitesi;
            ID = ıD;
        }
        public string Yazdir()
        {
            return $"Marka={marka} Model={model}\nYıkama kapasitesi={yıkamakapasitesi} Enerji Sınıfı={enerjisınıfı}\nFiyat={fiyat} ID ={ID}";
        }
    }
}
