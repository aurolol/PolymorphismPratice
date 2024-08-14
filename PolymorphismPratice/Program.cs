using PolymorphismPratice;

public class Program
{
    public static void Main(string[] args)
    {

       Kare kare = new Kare();
        kare.Genislik = 3;
        kare.Yukseklik = 3;          // Kare alan örneği
        kare.AlanSonuc();

        Console.WriteLine("------------------------------");

        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.Genislik = 2;
        dikdortgen.Yukseklik = 4;        // Dikdörtgen alan örneği
        dikdortgen.AlanSonuc();


        Console.WriteLine("------------------------------");


        DikUcgen dikUcgen = new DikUcgen();
        dikUcgen.Genislik = 2;
        dikUcgen.Yukseklik = 3;         // Dik Üçgen alan örneği
        dikUcgen.AlanSonuc();




    }
}