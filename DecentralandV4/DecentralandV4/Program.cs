using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dllmodel;


namespace DecentralandV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datamodel DM = new Datamodel();
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
                    u.password = şifre;
                    DM.KullanıcıEkle(u);
                    Console.WriteLine("Üye Olma Başarılı");

                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Bir Hata ile Karşılaşıldı");
            }




            if (girissecenek == 2)
            {
                Console.Clear();
                Console.WriteLine("Lütfen mail adresinizi yazınız");
                string mail = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Lütfen şifrenizi giriniz");
                string şifre = Console.ReadLine();
                Console.Clear();
                List<Users> kullanıcılarr = DM.KullanıciListele();
                foreach(Users item in kullanıcılarr)
                {
                    if(mail == item.Mail && şifre == item.password)
                    {
                        Console.WriteLine("Hoşgeldin " + item.Name + " " + item.Surname);
                       

                        string secenek = "e";
                        decimal toplamfiyat = 0;
                        while (secenek == "e")
                        {
                            List<Categories> Kategoriler = DM.Kategorilistele();
                            foreach (Categories cat in Kategoriler)
                            {
                                Console.WriteLine($"{cat.ID})    {cat.CategoryName}");
                            }
                            Console.WriteLine("Ürünlerini Listelemek İstediğiniz Kategorinin Numarasını Yazınız");
                            int catno = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            List<Products> CategoryIDileURUNLER = DM.KategoriIDileUrunListele(catno);
                            foreach (Products p in CategoryIDileURUNLER)
                            {
                                Console.WriteLine($"{p.ID})    {p.name}      fiyat={p.UnitPrice}   stok={p.stocks} ");
                            }
                            Console.WriteLine("Almak İstediğiniz Ürünün ID sini Yazınız");
                            int ıd = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Kaç adet alacaksınız");
                            int adet = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            decimal fiyat = DM.fiyatgetir(ıd, adet);
                            toplamfiyat += fiyat;



                                Console.WriteLine(fiyat + " TL lik ürüm sepete eklendi kalan stok = " + DM.GüncelStokGetir(ıd, adet));
                            Console.WriteLine("Sepetteki Ürün Tutarı = " + toplamfiyat);
                            
                                Console.WriteLine("Alışverişe Devam Etmek İstiyormusunuz");
                                secenek = Console.ReadLine();
                            Console.Clear();
                            if (secenek != "e")
                            {
                                Console.WriteLine("Toplam Tutar = " + toplamfiyat);
                            }
                            
                               
                            
                        }

                    }
                }

            }
        }
    }
}
