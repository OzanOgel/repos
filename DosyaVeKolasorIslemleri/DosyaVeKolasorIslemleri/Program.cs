using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaVeKolasorIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KlasorYol = "C://Dosyalar/abc/deneme";
            string dosyayol = "C://Dosyalar/abc/deneme/deneme.txt";
            #region Klasör Oluşturma
            //DirectoryInfo Klasor = new DirectoryInfo(KlasorYol);
            //if (Klasor.Exists)
            //{
            //    Klasor.Create();
            //}
            #endregion

            #region Dırectory Info
            //DirectoryInfo di = new DirectoryInfo(KlasorYol);
            //Console.WriteLine("exist = " + di.Exists);
            //Console.WriteLine("Fullname = " + di.FullName);
            //Console.WriteLine("name = " + di.Name);
            //Console.WriteLine("parent = " + di.Parent);
            //Console.WriteLine("Oluşturma Zamanı = " + di.CreationTime);
            //Console.WriteLine("Root +" + di.Root);
            #endregion

            #region File Info
            //FileInfo fi = new FileInfo(dosyayol);
            //Console.WriteLine("Exist = " + fi.Exists);
            ////fi.Create();
            //Console.WriteLine("full name = " + fi.FullName);
            //Console.WriteLine("name = " + fi.Name);
            //Console.WriteLine("Extension = " + fi.Extension);
            //Console.WriteLine("Oluşturma Tarihi = " + fi.CreationTime);


            #endregion

            #region Dosyaları Ve Klasörleri Listeleme
            //string path = "C://";

            //DirectoryInfo di = new DirectoryInfo(path);
            //DirectoryInfo[] klasorler = di.GetDirectories();
            //foreach(DirectoryInfo item in klasorler)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //FileInfo[] dosyalar = di.GetFiles();
            //foreach(FileInfo item in dosyalar)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region stream Writer 
            //StreamWriter sw = new StreamWriter(dosyayol,true);
            //sw.WriteLine("Ben Flashtan önce eklendim");
            //sw.Flush();//Stream Üzerinde bekleyen işlemleri dosya üzerine yansıtır
            //sw.WriteLine("Ben Flashtan sonra eklendim");
            ////sw.Close();
            #endregion

            #region Stream Reader
            StreamReader reader = new StreamReader(dosyayol);
            //Console.WriteLine(reader.ReadLine());//satır satır okur;
          


            Console.WriteLine(reader.ReadToEnd());//hepsini okur

            #endregion
        }
    }
}
