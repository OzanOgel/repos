using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace DecentralandV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataModel DM = new DataModel();
            List<Users> kullanıcılar = new List<Users>();
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*--*-*Decentraland Markete Hosgeldiniz-*--*-*-*-*-*-*-*-*-*-*-*-*-**-*-*-*-*-*");
            Console.WriteLine("\n");
            Console.WriteLine("Üye olmak için 1 e basınız");
            Console.WriteLine(" ");
            Console.WriteLine("Üye girişi için 2 yi tuşlayınız");
           
           
                int girissecenek = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (girissecenek == 1)
                {
                    Console.Clear();
                    Users u = new Users();
                    Console.WriteLine("Lütfen isminizi Yazınız");
                    string isim = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Lütfen Soyisminizi Yazınız");
                    string soyisim = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("E-MAİL adresinizi yazınız");
                    string mail = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Lütfen şifre oluşturunuz");
                    string şifre = Console.ReadLine();
                    Console.Clear();
                    u.Name = isim;
                    u.Surname = soyisim;
                    u.Mail = mail;
                    u.Password = şifre;
                    DM.kullaniciekle(u);
                    Console.WriteLine("Üye Olma Başarılı");

                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Bir Hata ile Karşılaşıldı");
            }




            if(girissecenek == 2)
            {

            }
        }
    }
}
