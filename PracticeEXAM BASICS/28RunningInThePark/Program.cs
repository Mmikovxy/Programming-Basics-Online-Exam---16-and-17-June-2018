using System;

namespace _28RunningInThePark
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysRun = int.Parse(Console.ReadLine());
            int minutesRun ;
            double runDistance;
            string KmM;
            double totalDistance = 0.00;
            double totalMinutes = 0.00;
            double totalCals = 0.00;

            for (int i = 1; i <= daysRun; i++)
            {
               minutesRun = int.Parse(Console.ReadLine());
               runDistance = double.Parse(Console.ReadLine());
               KmM = Console.ReadLine();

                if(KmM == "m")
                {
                    runDistance = runDistance / 1000;
                }


                if (minutesRun == 20)
                {
                    totalCals += 400;
                }
                else 
                {
                    totalCals += (400 * minutesRun) / 20;
                }
                totalDistance += runDistance;
                totalMinutes += minutesRun;
            }
            Console.WriteLine("He ran {0:F2}km for {1} minutes and burned {2} calories.",totalDistance,totalMinutes,totalCals);

        }
    }
}
