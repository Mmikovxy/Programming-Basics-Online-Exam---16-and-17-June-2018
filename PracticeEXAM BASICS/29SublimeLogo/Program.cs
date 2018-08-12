using System;

namespace _29SublimeLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int widthSpace = 2 * n;
            //int widthAsterix = 2;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(new string(' ', widthSpace - (n / 2)) + new string('*',widthAsterix));
            //    widthSpace-=2;
            //    widthAsterix += 2;
            //}
            //widthSpace = 2 * n;
            //widthAsterix = 2*n;
            //if(n%2==0)
            //{
            //    for (int i = widthSpace; i > n + 2; i--)
            //    {
            //        widthAsterix -= 2;
            //        Console.WriteLine(new string('*', widthAsterix));

            //    }

            //    for (int i = widthSpace; i > n+2; i--)
            //    {
            //        widthAsterix += 2;
            //        Console.WriteLine(new string('*', widthAsterix));
            //    }

            //    for (int i = widthSpace; i > n + 2; i--)
            //    {
            //        widthAsterix -= 2;
            //        widthSpace = 2*n - widthAsterix;
            //        Console.WriteLine(new string(' ', widthSpace) + new string('*', widthAsterix));

            //    }
            //    widthSpace = n*2;
            //    for (int i = widthSpace; i > n+2; i--)
            //    {

            //        widthAsterix +=2;
            //        widthSpace = (2 * n - widthAsterix);
            //        Console.WriteLine(new string(' ', widthSpace) + new string('*', widthAsterix));

            //    }
            //    widthSpace = 2;
            //    widthAsterix = 2*n;
            //    for (int i = widthAsterix; i > n; i--)
            //    {

            //        widthAsterix -= 2;
            //        Console.WriteLine(new string('*', widthAsterix) + new string(' ', widthSpace - (n / 2)));
            //        widthSpace += 2;

            //    }
            //}
            //else
            //{
            //    for (int i = widthSpace; i > n + 3; i--)
            //    {
            //        widthAsterix -= 2;
            //        Console.WriteLine(new string('*', widthAsterix));
            //    }

            //    for (int i = widthSpace; i > n + 3; i--)
            //    {
            //        widthAsterix += 2;
            //        Console.WriteLine(new string('*', widthAsterix));
            //    }
            //    widthAsterix = 2 * n;
            //    for (int i = 2*n; i > n + 3; i--)
            //    {
            //        widthAsterix -=2;
            //        widthSpace = 2 * n - widthAsterix;
            //        Console.WriteLine(new string(' ',widthSpace) + new string('*', widthAsterix));
            //    }

            //    for (int i = 2 * n; i > n + 3; i--)
            //    {
            //        widthAsterix += 2;
            //        widthSpace = 2 * n - widthAsterix;
            //        Console.WriteLine(new string(' ', widthSpace) + new string('*', widthAsterix));
            //    }

            //    widthSpace = 2;
            //    widthAsterix = 2 * n;
            //    for (int i = widthAsterix; i > n; i--)
            //    {
            //        widthAsterix -= 2;
            //        Console.WriteLine(new string('*', widthAsterix) + new string(' ', widthSpace - (n / 2)));
            //        widthSpace += 2;

            //    }
            //}

            var n = int.Parse(Console.ReadLine());

            var space = ' ';
            var star = '*';

            var spacescount = 2 * n - 2;
            var starscount = 2;

            //top

            for (int row = 0; row < n; row++)
            {
                Console.Write(new string(space, spacescount));
                Console.Write(new string(star, starscount));
                spacescount -= 2;
                starscount += 2;
                Console.WriteLine();
            }

            //middletop1

            spacescount = 2;
            starscount = 2 * n - 2;

            for (int row = 0; row < 2; row++)
            {
                Console.Write(new string(star, starscount));
                Console.Write(new string(space, spacescount));
                spacescount += 2;
                starscount -= 2;
                Console.WriteLine();
            }

            //middletop2

            spacescount = 2;
            starscount = 2 * n - 2;

            for (int row = 0; row < 2; row++)
            {
                Console.Write(new string(star, starscount));
                Console.Write(new string(space, spacescount));
                if (spacescount > 0 && starscount > 0)
                {
                    spacescount -= 2;
                    starscount += 2;
                }
                Console.WriteLine();
            }



            //middlebottom1

            spacescount = 2;
            starscount = 2 * n - 2;

            for (int row = 0; row < 2; row++)
            {
                Console.Write(new string(space, spacescount));
                Console.Write(new string(star, starscount));
                spacescount += 2;
                starscount -= 2;
                Console.WriteLine();
            }

            //middlebottom2

            spacescount = 2;
            starscount = 2 * n - 2;

            for (int row = 0; row < 2; row++)
            {
                Console.Write(new string(space, spacescount));
                Console.Write(new string(star, starscount));
                if (spacescount > 0 && starscount > 0)
                {
                    spacescount -= 2;
                    starscount += 2;
                }
                Console.WriteLine();
            }



            //bottom

            spacescount = 2;
            starscount = 2 * n - 2;

            for (int row = 0; row < n; row++)
            {
                Console.Write(new string(star, starscount));
                Console.Write(new string(space, spacescount));
                spacescount += 2;
                starscount -= 2;
                Console.WriteLine();
            }

        }
    }
}
