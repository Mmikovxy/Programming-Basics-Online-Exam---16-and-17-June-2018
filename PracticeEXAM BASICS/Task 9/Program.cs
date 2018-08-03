using System;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyFood = int.Parse(Console.ReadLine());
            int gramFood;
            int totalFood = buyFood * 1000;
            int totalQuantity = 0;
            int leftFood = 0;
            for (int i = 0; i < buyFood; i++)
            {
                gramFood = int.TryParse("",Console.ReadLine());
                totalQuantity += gramFood;
                
            }
            leftFood = totalFood - totalQuantity;
            

        }
    }
}
