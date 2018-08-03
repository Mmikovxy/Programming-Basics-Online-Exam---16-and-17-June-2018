using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesWalkDay = int.Parse(Console.ReadLine());
            int countWalksDaily = int.Parse(Console.ReadLine());
            int CalsCatDaily = int.Parse(Console.ReadLine());

            int walksDaily = minutesWalkDay * countWalksDaily;
            int burnedCalories = walksDaily * 5;
            float CatCals = CalsCatDaily * 0.5f;

            if(burnedCalories>CatCals)
            {
                Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0}.",burnedCalories);

            }
            else
            {
                Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0}.", burnedCalories);
            }
           
        }
    }
}
