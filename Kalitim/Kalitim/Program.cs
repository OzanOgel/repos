using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CamasirMakinesi cm = new CamasirMakinesi();
            cm.Marka = "Ariston";
            cm.Model = "Ar45";
            cm.Fiyat = 5000;
            cm.YikamaKapasitesi = 7;
            cm.Kurutma = true;
            
        }
    }
}
