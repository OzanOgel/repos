using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdasaddsaadasadsdsadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binaryString = "01000255255255255100000006100010771011141049798971089711411";
            string asciiString = "";

            // Dizgiyi dönüştürürken boşlukları temizle
            binaryString = binaryString.Trim();

            for (int i = 0; i < binaryString.Length; i += 8)
            {
                string binaryChar = binaryString.Substring(i, 8);
                int asciiCode = Convert.ToInt32(binaryChar, 2);
                asciiString += (char)asciiCode;
            }

            Console.WriteLine(asciiString);



        }
    }
}
