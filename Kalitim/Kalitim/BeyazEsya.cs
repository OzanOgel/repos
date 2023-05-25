using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class BeyazEsya
    {
        public string Marka;
        public string Model;
        public double Fiyat;

        public virtual string yazdir()
        {
            return $"Marka = {Marka} model = {Model} fiyat = {Fiyat}";
        }

    }

}
