using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursLection = int.Parse(Console.ReadLine());
            int hoursArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());
            string dayWeek = Console.ReadLine();
            double points=0;
            if (hoursArrive < hoursLection && hoursArrive+1==hoursLection)
            {
                points += 1.5;
                if (dayWeek == "Monday" || dayWeek == "Wednesday" || dayWeek == "Friday")
                {
                    points += 0.6;
                    Console.WriteLine("{0:F2}",points);
                }
                else if (dayWeek == "Tuesday" || dayWeek == "Thursday" || dayWeek == "Saturday")
                {
                    points += 0.8;
                    Console.WriteLine("{0:F2}", points);
                }
                else
                {
                    points += 2;
                    Console.WriteLine("{0:F2}", points);
                }
            }
            else if (hoursArrive == hoursLection && minutesArrive <= 30 )
            {
                points += 1;
                
                if (dayWeek == "Monday" || dayWeek == "Wednesday" || dayWeek == "Friday")
                {
                    points += 0.6;
                    Console.WriteLine("{0:F2}", points);
                }
                else if (dayWeek == "Tuesday" || dayWeek == "Thursday" || dayWeek == "Saturday")
                {
                    points += 0.8;
                    Console.WriteLine("{0:F2}", points);
                }
                else
                {
                    points += 2;
                    Console.WriteLine("{0:F2}", points);
                }
            }
            else if (hoursArrive >= hoursLection && minutesArrive >= 30 && hoursArrive<=hoursLection+4)
            {
                points += 0.5;
                if (dayWeek == "Monday" || dayWeek == "Wednesday" || dayWeek == "Friday")
                {
                    points += 0.6;
                    Console.WriteLine("{0:F2}", points);
                }
                else if (dayWeek == "Tuesday" || dayWeek == "Thursday" || dayWeek == "Saturday")
                {
                    points += 0.8;
                    Console.WriteLine("{0:F2}", points);
                }
                else
                {
                    points += 2;
                    Console.WriteLine("{0:F2}", points);
                }
            }
        }
    }
}
