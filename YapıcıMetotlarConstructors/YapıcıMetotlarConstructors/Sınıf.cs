using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetotlarConstructors
{
    internal class Sınıf
    {
        public string isim;
        public string Dersadi;
        private int kontenjan;
        public Sınıf(int kont)
        {
            kontenjan = kont;
        }
        public string yazdır()
        {
            return isim +" " + Dersadi + "  " + kontenjan;
        }
    }
}
