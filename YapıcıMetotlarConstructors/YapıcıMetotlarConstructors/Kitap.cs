using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YapıcıMetotlarConstructors
{
    internal class Kitap
    {
        public string isim;
        public string yazar;
        public DateTime OlusturmaTarihi;
        public double fiyat;
        public string durum;

        public Kitap()
        {
            OlusturmaTarihi = DateTime.Now;
            durum = "satışta";
        }
    }
}
