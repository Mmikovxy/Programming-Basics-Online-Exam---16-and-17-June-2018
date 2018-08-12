using System;

namespace _11CatShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyFoodKG = int.Parse(Console.ReadLine());
            int buyFoodGRAM = buyFoodKG * 1000;
            int totalFood = 0;

           while (true)
            {

                string calories = Console.ReadLine();
                if(calories=="Adopted")
                {
                    break;

                }
                else
                {
                    
                    totalFood += int.Parse(calories);
                }
            }
        
           if(buyFoodGRAM>=totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {buyFoodGRAM - totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - buyFoodGRAM} grams more.");
            }
               
        }
    }
}
