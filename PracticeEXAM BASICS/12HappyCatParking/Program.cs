using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursDays = int.Parse(Console.ReadLine());
            double daysSumEven = 0;
            double daysSumOdd = 0;
            double totalSumEven = 0;
            double totalSumOdd = 0;

            for (int i = 1; i <= days; i++)
            {
                if (i % 2 == 0)
                {
                    
                    daysSumEven = 0;
                    for (int j = 1; j <= hoursDays; j++)
                    {

                        if (j % 2 != 0)
                        {
                            daysSumEven += 2.50;
                            totalSumEven += 2.50;
                        }
                        else
                        {
                            daysSumEven += 1.0;
                            totalSumEven += 1.0;
                        }
                      

                    }
                    Console.WriteLine("Day: {0} - {1:F2} leva", i, daysSumEven);
                
               
            }
                else
                {
                
                    
                    daysSumOdd = 0;
                    for (int j = 1; j <= hoursDays; j++)
                    {

                        if (j % 2 == 0)
                        {
                            daysSumOdd += 1.25;
                            totalSumOdd += 1.25;

                        }
                        else
                        {
                            daysSumOdd += 1.0;
                            totalSumOdd += 1.0;
                    }
                    
                }
                    Console.WriteLine("Day: {0} - {1:F2} leva", i, daysSumOdd);
                
                }


            }

        Console.WriteLine("Total: {0:F2} leva", totalSumOdd + totalSumEven);


    }
    }

