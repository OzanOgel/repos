using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DecentralandV3
{
    public class Products
    {
        public int CategoryID { get; set; }
        public string name { get; set; }
        public int Stocks { get; set; }
        public int UnitPrice { get; set; }
    }
}
