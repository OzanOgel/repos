using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLserialization
{
    [Serializable]
    public class Personel
    {
        public string isim { get; set; }

        public string soyad { get; set; }
        public string departman { get; set; }

        public int yas { get; set; }


    }
}
