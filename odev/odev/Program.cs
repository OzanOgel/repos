using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = 1;
            int s2 = 1;
            int s3;
            int sayac = 0;
            while (sayac < 10)
            {
                s3 = s1 + s2;
                s1 = s2;
                s2 = s3;
                Console.WriteLine(s3);
                sayac++;
            }
        }
    }
}
