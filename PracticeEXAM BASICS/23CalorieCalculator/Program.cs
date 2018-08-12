using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            char gender = char.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string phys_active = Console.ReadLine();

            double level_metabolism_man = 66 + (13.7 * weight) + (5 * height * 100) - (6.8 * age);
            double level_metabolism_woman = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);

            if (phys_active == "sedentary" && gender == 'm')
            {
                level_metabolism_man *= 1.2;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_man));

            }
            else if (phys_active == "lightly active" && gender == 'm')
            {
                level_metabolism_man *= 1.375;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_man));
            }
            else if (phys_active == "moderately active" && gender == 'm')
            {
                level_metabolism_man *= 1.55;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_man));
            }
            else if (phys_active == "very active" && gender == 'm')
            {
                level_metabolism_man *= 1.725;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_man));
            }


            if (phys_active == "sedentary" && gender == 'f')
            {
                level_metabolism_woman *= 1.2;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_woman));
            }
            else if (phys_active == "lightly active" && gender == 'f')
            {
                level_metabolism_woman *= 1.375;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_woman));
            }
            else if (phys_active == "moderately active" && gender == 'f')
            {
                level_metabolism_woman *= 1.55;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_woman));
            }
            else if (phys_active == "very active" && gender == 'f')
            {
                level_metabolism_woman *= 1.725;
                Console.WriteLine("To maintain your current weight you will need {0} calories per day.", Math.Ceiling(level_metabolism_woman));
            }


        }
    }
}
