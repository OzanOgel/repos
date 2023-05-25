using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calişma2
{
    public class urun
    {
       public string isim;
        public string birim;
        public double fiyat;
        public int stok;
        public urun(string _isim,string _birim,double _fiyat , int _stok)
        {
            isim = _isim;
            birim = _birim;
            fiyat = _fiyat;
            stok = _stok;
        }
    }
}
