﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = 3 * (n - 2);
            int body = l - 2 * (n - 2) - 2;

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string(' ', n) + "||" + new string('_', n - 2) + "||");
            }
            Console.WriteLine(new string(' ', n - 1) + "//" + new string(' ', n) + "\\\\");


            if (body % 2 == 0)
            {
                for (int i = 1; i <= body; i++)
                {
                    if (i == body / 2)
                    {
                        Console.WriteLine(new string(' ', n - 2) + "||" + new string(' ', n + 2) + "||" + "]");

                    }
                    else
                    {
                        Console.WriteLine(new string(' ', n - 2) + "||" + new string(' ', n + 2) + "||");
                    }
                }
            }


            if (body % 2 != 0)
            {
                for (int i = 0; i < body; i++)
                {
                    if (body == 1)
                    {
                        Console.WriteLine(new string(' ', n - 2) + "||" + new string(' ', n + 2) + "||" + "]");

                    }
                    else if (i == body / 2)
                    {
                        Console.WriteLine(new string(' ', n - 2) + "||" + new string(' ', n + 2) + "||" + "]");
                    }
                    else
                    {
                        Console.WriteLine(new string(' ', n - 2) + "||" + new string(' ', n + 2) + "||");
                    }

                }
            }

            Console.WriteLine(new string(' ', n - 1) + "\\\\" + new string(' ', n) + "//");

            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine(new string(' ', n) + "||" + new string('_', n - 2) + "||");
            }
        }
    }
}
