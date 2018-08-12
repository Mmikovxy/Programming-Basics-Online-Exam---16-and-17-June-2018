using System;

namespace _26FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            if ((age >= 5 && age <= 105) && (price >= 10 && price < 1000))
            {
                switch (sport)
                {
                    case "Gym":
                        if (price >= 42 && gender == 'm')
                        {

                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);

                        }
                        else if (price >= 35 && gender == 'f')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);
                        }

                        else
                        {
                            if (age <= 19 && gender == 'm')
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (42 - 42 * 0.2) - price);
                            }
                            else if (age <= 19 && gender == 'f')
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (35 - 35 * 0.2) - price);
                            }
                            else if (gender == 'm') 
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 42 - price);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 35 - price);
                            }
                        }
                        break;
                    case "Boxing":
                        if (price >= 41 && gender == 'm')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);

                        }
                        else if (price >= 37 && gender == 'f')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);
                        }
                        else
                        {
                            if (age <= 19 && gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (41 - 41 * 0.2) - price);
                            }
                            else if (age <= 19 && gender == 'f' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (37 - 37 * 0.2) - price);
                            }
                            else if (gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 41 - price);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 37 - price);
                            }

                        }
                        break;
                    case "Yoga":
                        if (price >= 45 && gender == 'm')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);

                        }
                        else if (price >= 42 && gender == 'f')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);
                        }

                        else
                        {
                            if (age <= 19 && gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (45 - 45 * 0.2) - price);
                            }
                            else if (age <= 19 && gender == 'f' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (42 - 42 * 0.2) - price);
                            }
                            else if (gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 45 - price);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 42 - price);
                            }

                        }
                        break;
                    case "Zumba":
                        if (price >= 34 && gender == 'm')
                        {

                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);

                        }
                        else if (price >= 31 && gender == 'f')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);
                        }
                        else
                        {
                            if (age <= 19 && gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (34 - 34 * 0.2) - price);
                            }
                            else if (age <= 19 && gender == 'f' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (31 - 31 * 0.2) - price);
                            }
                            else if (gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 34 - price);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 31 - price);
                            }

                        }
                        break;

                    case "Dances":
                        if (price >= 51 && gender == 'm')
                        {

                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);

                        }
                        else if (price >= 53 && gender == 'f')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);
                        }

                        else
                        {
                            if (age <= 19 && gender == 'm')
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (51 - 51 * 0.2) - price);
                            }
                            else if (age <= 19 && gender == 'f')
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (53 - 53 * 0.2) - price);
                            }
                            else if (gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 51 - price);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 53 - price);
                            }

                        }
                        break;

                    case "Pilates":
                        if (price >= 39 && gender == 'm')
                        {

                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);

                        }
                        else if (price >= 37 && gender == 'f')
                        {
                            Console.WriteLine("You purchased a 1 month pass for Gym.", sport);
                        }

                        else
                        {
                            if (age <= 19 && gender == 'm')
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (39 - 39 * 0.2) - price);
                            }
                            else if (age <= 19 && gender == 'f' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", (37 - 37 * 0.2) - price);
                            }
                            else if (gender == 'm' )
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 39 - price);
                            }
                            else
                            {
                                Console.WriteLine("You don't have enough money! You need ${0:F2} more.", 37 - price);
                            }

                        }
                        break;
                    default: Console.WriteLine("Invalid input"); break;

                }
            }
        }
    }
}
