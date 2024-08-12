using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{

    public class BaseGeometrikSekil() //base class oluşturulmuştur
    {
        public double Genislik { get; set; }
        public double Yukseklik { get; set; }

        public virtual double AlanHesapla(double genislik, double yukseklik) //ana method oluşturulmuştur
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
            double alan = genislik * yukseklik;
            Console.WriteLine(alan);
            return alan;

        }
    }

    public class Kare : BaseGeometrikSekil //base classtaan miras alınarak diğer class oluşturulmuştur.
    {
        public override double AlanHesapla(double genislik, double yukseklik) //method overloading yapılmıştır
        {
            return base.AlanHesapla(genislik, yukseklik);//baseclass ile aynı şekilde döndüreceği için return base kullanılmıştır.
        }
    }

    public class Dikdortgen : BaseGeometrikSekil //base classtaan miras alınarak diğer class oluşturulmuştur.
    {
        public override double AlanHesapla(double genislik, double yukseklik)//method overloading yapılmıştır
        {
            return base.AlanHesapla(genislik, yukseklik); //baseclass ile aynı şekilde döndüreceği için return base kullanılmıştır.
        }
    }

    public class Ucgen : BaseGeometrikSekil //base classtaan miras alınarak diğer class oluşturulmuştur.
    {
        public override double AlanHesapla(double genislik, double yukseklik)//method overloading yapılmıştır
        {
            double alan = (genislik * yukseklik) / 2; //method overloading yapılırken method içerisinde yeni hesaplama yapılmıştır.
            Console.WriteLine(alan);
            return alan;
        }
    }

}
