using System;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCats = int.Parse(Console.ReadLine());
            string smallName;
            string familyName;
            int lastBirthDigits;
            for (int i = 0; i < countCats; i++)
            {
                smallName = Console.ReadLine();
                familyName = Console.ReadLine();
                lastBirthDigits = int.Parse(Console.ReadLine());

                char charSmallFirst = smallName[0];
                char charFamFirst = familyName[0];

                Console.WriteLine("{0}{1}{2}{3}",lastBirthDigits,(int)charSmallFirst,(int)charFamFirst,i+1);
            }
        }
    }
}
