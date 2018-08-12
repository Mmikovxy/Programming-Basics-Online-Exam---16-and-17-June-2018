using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
      static void Main(string[] args)
      {
        string formEducationBefore = Console.ReadLine();
        int enrollStudentsBefore = int.Parse(Console.ReadLine());

        string formEducationNow = Console.ReadLine();
        int enrollStudentsNow = int.Parse(Console.ReadLine());

        string formEducationLate = Console.ReadLine();
        int enrollStudentsLate = int.Parse(Console.ReadLine());
        int maxStudents = 600;
        int totalStudents = 0;
        int onlineStudents = 0;
        int onsiteStudents = 0;

        switch(formEducationBefore)
        {
            case "online": onlineStudents = enrollStudentsBefore;
                break;
            case "onsite": onsiteStudents = enrollStudentsBefore; 
                break;
        }

        switch(formEducationNow)
        {
            case "online":
               onlineStudents += enrollStudentsNow; 
                break;
            case "onsite":
                onsiteStudents += enrollStudentsNow;
                break;
        }

        switch (formEducationLate)
        {
            case "online":
                onlineStudents += enrollStudentsLate; 
                break;
            case "onsite":
                onsiteStudents += enrollStudentsLate; 
                break;
        }
        totalStudents = onlineStudents + onsiteStudents;
        
        if(onsiteStudents>=maxStudents)
        {
            onlineStudents = onlineStudents + (onsiteStudents - maxStudents);
            onsiteStudents = 600;

            Console.WriteLine("Online students: {0}",onlineStudents);
            Console.WriteLine("Onsite students: {0}",onsiteStudents);
            Console.WriteLine("Total students: {0}",totalStudents);
        }
        else
        {
            Console.WriteLine("Online students: {0}", onlineStudents);
            Console.WriteLine("Onsite students: {0}", onsiteStudents);
            Console.WriteLine("Total students: {0}", totalStudents);
        }


      
















    }
}

