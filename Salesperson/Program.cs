using System;

namespace Salesperson
{
    class Program
    {
        static void Main(string[] args)
        {
            GirlScout Amelia = new GirlScout("Amelia ", "Martinez");
            Amelia.SalesSpeech();
            Amelia.MakeSale(5);
            Amelia.MakeSale(10);
            Amelia.MakeSale(20);
            Console.WriteLine("Total of box of cookies sold: {0}", Amelia.BoxesSold);

            Console.WriteLine("");

            RealEstateSalesPerson Karla = new RealEstateSalesPerson("Karla ", "Guzman");
            Karla.SalesSpeech();
            Karla.MakeSale(150000);
            Karla.MakeSale(100000);
            Console.WriteLine("My total comission for the houses I sold with a %5 commission rate is ${0}", Karla.TotalComm);
        }
    }
}
