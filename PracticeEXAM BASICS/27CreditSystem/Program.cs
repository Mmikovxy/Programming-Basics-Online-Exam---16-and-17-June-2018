using System;

namespace _27CreditSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int enrollCourses = int.Parse(Console.ReadLine());
            int creditsMarks;
            double totalCredits = 0.0;
            double averageMark = 0.0;
            double totalMarks = 0.0;
            
            for (int i = 1; i <= enrollCourses; i++)
            {
                creditsMarks = int.Parse(Console.ReadLine());
                int mark = creditsMarks  % 10;
                double credits = (creditsMarks - mark) / 10;
                totalMarks += mark;

              
                if (mark == 3)
                {
                    credits = credits * 0.5;
                    totalCredits = totalCredits + credits;
                }
                else if(mark==4)
                {
                    credits =  credits * 0.7;
                    totalCredits = totalCredits + credits;
                }
                else if(mark == 5)
                {
                    credits = credits * 0.85;
                    totalCredits = totalCredits + credits;
                }
                else if (mark == 6)
                {
                   
                    totalCredits += credits;
                }
                else
                {
                    credits = 0;
                    totalCredits += credits;
                }
                
            }
            Console.WriteLine("{0:F2}",totalCredits);
            averageMark = totalMarks / enrollCourses;
            Console.WriteLine("{0:F2}",averageMark);
        }
    }
}
