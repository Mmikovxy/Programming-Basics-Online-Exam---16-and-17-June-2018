using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annualsalary
{
    class Program
    {
        static void Main(string[] args)
        {

            int years_exp = int.Parse(Console.ReadLine());
            string profession = Console.ReadLine();
            double salary = 0.0;
            if (profession == "C# Developer" && years_exp <= 5)
            {
                salary = 5400 - 5400.0 * (65.8 / 100);
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "Java Developer" && years_exp <= 5)
            {
                salary = 5700 - 5700 * (65.8 / 100);
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "UX / UI Designer" && years_exp <= 5)
            {
                salary = 3100 - 3100 * (65.8 / 100);
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "Front-End Web Developer" && years_exp <= 5)
            {
                salary = 4100 - 4100 * (65.8 / 100);
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "Game Designer" && years_exp <= 5)
            {
                salary = 3600 - 3600 * (65.8 / 100);
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }


            if (profession == "C# Developer" && years_exp > 5)
            {
                salary = 5400;
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "Java Developer" && years_exp > 5)
            {
                salary = 5700;
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "UX / UI Designer" && years_exp > 5)
            {
                salary = 3100;
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "Front-End Web Developer" && years_exp > 5)
            {
                salary = 4100;
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
            else if (profession == "Game Designer" && years_exp > 5)
            {
                salary = 3600;
                Console.WriteLine("Total earned money: {0:F2} BGN ", salary * 12);
            }
        }
    }
}
