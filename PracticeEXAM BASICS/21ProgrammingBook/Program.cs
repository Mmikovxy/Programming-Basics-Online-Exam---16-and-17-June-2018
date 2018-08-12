using System;

namespace _21ProgrammingBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePage = double.Parse(Console.ReadLine());
            double priceCover = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            float discountConv = discount / 100f;
            double priceDesigner = double.Parse(Console.ReadLine());
            int percFinal = int.Parse(Console.ReadLine());
            float percFinalConv = percFinal / 100f;
            double priceFinal = 0;

            priceFinal = pricePage * 899 + priceCover * 2;
            priceFinal = priceFinal * (1 - discountConv);
            priceFinal += priceDesigner;
            priceFinal = priceFinal * (1 - percFinalConv);
            Console.WriteLine("Avtonom should pay {0:F2} BGN.",priceFinal);



        }
    }
}
