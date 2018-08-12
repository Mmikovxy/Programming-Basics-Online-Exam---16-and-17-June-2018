using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFood = double.Parse(Console.ReadLine());
            double priceSuven = double.Parse(Console.ReadLine());
            double priceHotel = double.Parse(Console.ReadLine());
            double priceHotel_1 = 0.0;
            double priceHotel_2 = 0.0;
            double priceHotel_3 = 0.0;
            double totalPrice = 0.0;
            double priceFuel = (420.0 / 100.0) * 7.0;
            priceFuel = priceFuel * 1.85;
            double priceFoodSuv = 3 * priceFood + 3 * priceSuven;
            priceHotel_1 = priceHotel * 0.9;
            priceHotel_2 = priceHotel * 0.85;
            priceHotel_3 = priceHotel * 0.8;
            totalPrice = priceFuel + priceFoodSuv + priceHotel_1 + priceHotel_2 + priceHotel_3;
            Console.WriteLine("Money needed: {0:F2}", totalPrice);







        }
    }
}
