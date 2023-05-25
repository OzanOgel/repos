using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllmodel
{
    public class Products
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string name { get; set; }
        public int stocks { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
