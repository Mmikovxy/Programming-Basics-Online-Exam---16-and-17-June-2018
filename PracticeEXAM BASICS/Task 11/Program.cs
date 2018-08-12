using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFoodMeow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int space = n;
            Console.Write(new string('.', n - 1) + "|");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("|" + new string('.', n - 1));

            Console.WriteLine();

            Console.Write(new string('.', n - 1) + "|");
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("~");
            }
            Console.Write("|" + new string('.', n - 1));

            for (int i = 1; i <= n; i++) // redove
            {
                Console.WriteLine();


                Console.Write(new string('.', n - 1) + "|");
                Console.Write(new string(' ', i - 1));
                for (int j = i; j <= n; j++)
                {
                    Console.Write("{}");
                }
                Console.Write(new string(' ', i - 1));
                Console.Write("|" + new string('.', n - 1));

            }

            Console.WriteLine();


            Console.Write(new string('.', n - 1) + "|" + new string(' ', n - 2) + "MEOW" + new string(' ', n - 2) + "|" + new string('.', n - 1));
            Console.WriteLine();
            Console.Write(new string('.', n - 1) + "|" + new string(' ', n - 2) + "FOOD" + new string(' ', n - 2) + "|" + new string('.', n - 1));


            for (int i = 0; i < n; i++) // redove
            {
                Console.WriteLine();


                Console.Write(new string('.', n - 1) + "|");
                Console.Write(new string(' ', space - 1));

                space--;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{}");
                }
                Console.Write(new string(' ', space));
                Console.Write("|" + new string('.', n - 1));



            }
            Console.WriteLine();



            Console.Write(new string('.', n - 1) + "|");
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("~");
            }
            Console.Write("|" + new string('.', n - 1));

            Console.WriteLine();
            Console.Write(new string('.', n - 1) + "|");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.Write("|" + new string('.', n - 1));

            Console.WriteLine();


        }
    }
}
