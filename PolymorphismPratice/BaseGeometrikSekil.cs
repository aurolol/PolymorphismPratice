using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismPratice
{
    public class BaseGeometrikSekil
    {
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }

        public virtual double AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
        public virtual void AlanSonuc()
        {
            Console.WriteLine("Alan hesaplanıldı.");
        }
    }
        public class Kare : BaseGeometrikSekil
        {
            public override double AlanHesapla()
            {
                return Yukseklik * Yukseklik;
            }
            public override void AlanSonuc()
            {
                Console.WriteLine($"Karenin Alanı: {AlanHesapla()}");
            }

        }
        public class Dikdortgen : BaseGeometrikSekil
        {
            public override double AlanHesapla()
            {
                return base.AlanHesapla();
            }
            public override void AlanSonuc()
            {
                Console.WriteLine($"Dikdörtgenin Alanı: {AlanHesapla()}");
            }
        }
        public class DikUcgen : BaseGeometrikSekil
        {
            public override double AlanHesapla()
            {
                return (Yukseklik * Genislik) / 2;
            }
            public override void AlanSonuc()
            {
                Console.WriteLine($"Dik Üçgenin Alanı: {AlanHesapla()}");
            }
        }




     }
