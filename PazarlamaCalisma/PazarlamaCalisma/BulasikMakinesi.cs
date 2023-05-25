using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PazarlamaCalisma
{
    public class BulasikMakinesi
    {
        public string marka;
        public string model;
        public double fiyat;
        public string enerjisınıfı;
        public int programsayisi;
        public string ID;

        public BulasikMakinesi(string _marka, string _model, double _fiyat, string _enerjisınıfı,int _programsayisi , string ıD)
        {
            marka = _marka;
            model = _model;
            fiyat = _fiyat;
            enerjisınıfı = _enerjisınıfı;
            programsayisi = _programsayisi;
                ID =ıD;

            

        }
        public string Yazdir()
        {
            return $"Marka={marka} Model={model}\nProgram Sayisi={programsayisi} Enerji Sınıfı={enerjisınıfı}\nFiyat={fiyat} ID ={ID}";
        }
    }
    
}
