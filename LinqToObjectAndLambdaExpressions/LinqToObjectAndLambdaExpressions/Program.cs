using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjectAndLambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<araba> arabalar = new List<araba>();
            arabalar.Add(new araba() { ID=1,Marka = "Audi", Model = "A3",Fiyat = 50000});
            arabalar.Add(new araba() { ID = 1, Marka = "Ford", Model = "Focus", Fiyat = 7500000 });
            arabalar.Add(new araba() { ID = 1, Marka = "Ford", Model = "Escort", Fiyat = 900000 });
            arabalar.Add(new araba() { ID = 1, Marka = "Ford", Model = "Fusion", Fiyat = 800000 });
            arabalar.Add(new araba() { ID = 1, Marka = "Audi", Model = "A6", Fiyat = 200000 });
            arabalar.Add(new araba() { ID = 1, Marka = "Audi", Model = "A1", Fiyat = 600000 });
            arabalar.Add(new araba() { ID = 1, Marka = "hyundai", Model = "i30", Fiyat = 2500000 });
            //Linq To Object
            //SQL üzerindeki TSQL sorgu yaklaşımının c# içerisinde kullanılması olanak sağlayan yapıya linq to object denir
            //var filtreli = from x in arabalar where x.Fiyat > 500000 select x;
            //foreach(var item in filtreli)
            //{
            //    Console.WriteLine(item.Marka + " - " +  item.Model +" - " + item.Fiyat);
            //}
            #region Where
            //var filtreli2 = arabalar.Where(x => x.Fiyat > 50000);
            foreach(var a in arabalar)
            {
                Console.WriteLine(a.Marka.ToString());
            }

            #endregion

            #region max 
            double enpahali = arabalar.Max(x => x.Fiyat);
            List<araba> filtreliler =arabalar.Where(x => x.Fiyat > 50000).ToList();
            filtreliler.ForEach(x => Console.WriteLine(x.Marka + " " + x.Model));
            #endregion

        }




    }

    class araba
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }

    }
}
