﻿using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceBed = decimal.Parse(Console.ReadLine());
            var toiletMonthPrice = decimal.Parse(Console.ReadLine());

            var priceFood = toiletMonthPrice + toiletMonthPrice * 0.25m;
            var priceToys = priceFood - priceFood * 0.50m;
            var priceMonthVet = priceToys + priceToys * 0.10m;
            var totalMonthPrice = toiletMonthPrice + priceFood + priceToys + priceMonthVet;
            var totalPrice = totalMonthPrice * 0.05m;
            var totalYearPrice = totalMonthPrice * 12 + priceBed + totalPrice * 12;
            Console.WriteLine("{0:F2} lv.", totalYearPrice);
            
        }
    }
}
