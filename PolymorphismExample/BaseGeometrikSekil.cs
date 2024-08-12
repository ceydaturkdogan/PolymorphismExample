using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{

    public class BaseGeometrikSekil() //base class oluşturulmuştur
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public virtual int AlanHesapla(int genislik, int yukseklik) //ana method oluşturulmuştur
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
            int alan = genislik * yukseklik;
            Console.WriteLine(alan);
            return alan;

        }
    }

    public class Kare : BaseGeometrikSekil //base classtaan miras alınarak diğer class oluşturulmuştur.
    {
        public override int AlanHesapla(int genislik, int yukseklik) //method overloading yapılmıştır
        {
            return base.AlanHesapla(genislik, yukseklik);//baseclass ile aynı şekilde döndüreceği için return base kullanılmıştır.
        }
    }

    public class Dikdortgen : BaseGeometrikSekil //base classtaan miras alınarak diğer class oluşturulmuştur.
    {
        public override int AlanHesapla(int genislik, int yukseklik)//method overloading yapılmıştır
        {
            return base.AlanHesapla(genislik, yukseklik); //baseclass ile aynı şekilde döndüreceği için return base kullanılmıştır.
        }
    }

    public class Ucgen : BaseGeometrikSekil //base classtaan miras alınarak diğer class oluşturulmuştur.
    {
        public override int AlanHesapla(int genislik, int yukseklik)//method overloading yapılmıştır
        {
            int alan = (genislik * yukseklik) / 2; //method overloading yapılırken method içerisinde yeni hesaplama yapılmıştır.
            Console.WriteLine(alan);
            return alan;
        }
    }

}
