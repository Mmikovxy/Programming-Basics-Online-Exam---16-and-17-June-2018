using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCats = int.Parse(Console.ReadLine());
            float gramFood;

            int smallGroup = 0;
            int midGroup = 0;
            int largeGroup = 0;
            float foodCat = 0;
            for (int i = 0; i < countCats; i++)
            {
                gramFood = float.Parse(Console.ReadLine());
                foodCat += gramFood;

                if(gramFood>=100 && gramFood < 200)
                {
                    smallGroup++;
                }
                else if(gramFood >= 200 && gramFood < 300)
                {
                    midGroup++;
                }
                else if (gramFood >= 300 && gramFood < 400)
                {
                    largeGroup++;
                }
            }

            foodCat = foodCat / 1000f;
            float foodCatDaily = foodCat * 12.45f;
            Console.WriteLine("Group 1: {0} cats.",smallGroup);
            Console.WriteLine("Group 2: {0} cats.", midGroup);
            Console.WriteLine("Group 3: {0} cats.", largeGroup);
            Console.WriteLine("Price for food per day: {0:F2} lv.",foodCatDaily);


        }
    }
}
