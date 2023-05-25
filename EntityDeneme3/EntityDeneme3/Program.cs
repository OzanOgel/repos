using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EntityDeneme3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            
           Products p = new Products();
            p.ProductName = "Entity Urun";
            p.CategoryID = 8;
            p.SupplierID = 5;
            p.UnitPrice = 50;
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Tamamlandı");
            Console.ReadLine();
            List<Products> urunler = db.Products.ToList();
            foreach(Products item in urunler)
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}
