using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{

    public class BaseGeometrikSekil()
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public virtual int AlanHesapla(int genislik, int yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
            int alan = genislik * yukseklik;
            Console.WriteLine(alan);
            return alan;

        }
    }

    public class Kare : BaseGeometrikSekil
    {
        public override int AlanHesapla(int genislik, int yukseklik)
        {
            return base.AlanHesapla(genislik, yukseklik);
        }
    }

    public class Dikdortgen : BaseGeometrikSekil
    {
        public override int AlanHesapla(int genislik, int yukseklik)
        {
            return base.AlanHesapla(genislik, yukseklik);
        }
    }

    public class Ucgen : BaseGeometrikSekil
    {
        public override int AlanHesapla(int genislik, int yukseklik)
        {
            int alan = (genislik * yukseklik) / 2;
            Console.WriteLine(alan);
            return alan;
        }
    }

}
