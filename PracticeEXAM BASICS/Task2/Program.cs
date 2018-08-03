using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int procentFats = int.Parse(Console.ReadLine()); //Процент на мазнините - цяло число в интервала [0…100]
            int procentProteins = int.Parse(Console.ReadLine()); //Процент на протеините - цяло число в интервала[0…100]
            int procentCarbs = int.Parse(Console.ReadLine()); //цяло число Процент на въглехидратите - цяло число в интервала [0…100]
            int totalCalories = int.Parse(Console.ReadLine()); //цяло число Общ брой калории - цяло число в интервала [1000…15000]
            int procentWater = int.Parse(Console.ReadLine()); //цяло число Процент на съдържанието на вода - цяло число в интервала [0…100]

            float procentFatsConv = procentFats / 100f;
            float procentProteinsConv = procentProteins / 100f;
            float procentCarbsConv = procentCarbs / 100f;

            float totalCalsFats = (procentFatsConv * totalCalories) / 9f;
            float totalCalsProteins = (procentProteinsConv * totalCalories) / 4f;
            float totalCalsCarbs = (procentCarbsConv * totalCalories) / 4f;
            float totalFoodWeight = (totalCalsCarbs + totalCalsProteins + totalCalsFats);
            float kcalFoodGram = totalCalories / totalFoodWeight;
            float totalCals = kcalFoodGram *(1-(procentWater/100f));
            Console.WriteLine("{0:F4}",totalCals);






        }
    }
}
