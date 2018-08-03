using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string catType = Console.ReadLine();
            char genderCat = char.Parse(Console.ReadLine());

            int yearsToMonths;
            int catMonths;

            if(genderCat=='m')
            {
                switch (catType)
                {

                    case "British Shorthair":yearsToMonths = 13 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Siamese":
                        yearsToMonths = 15* 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Persian":
                        yearsToMonths = 14 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Ragdoll":
                        yearsToMonths = 16 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "American Shorthair":
                        yearsToMonths = 12 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Siberian":
                        yearsToMonths = 11 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                        default: Console.WriteLine($"{catType} is invalid cat!"); break;
                }
            }
            else
            {
                switch (catType)
                {


                    case "British Shorthair":
                        yearsToMonths = 14 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Siamese":
                        yearsToMonths = 16 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Persian":
                        yearsToMonths = 15 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Ragdoll":
                        yearsToMonths = 17 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "American Shorthair":
                        yearsToMonths = 13 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                    case "Siberian":
                        yearsToMonths = 12 * 12; catMonths = yearsToMonths / 6;
                        Console.WriteLine($"{catMonths} cat months"); break;
                        default: Console.WriteLine($"{catType} is invalid cat!"); break;
                }
            }
            


        }
    }
}
