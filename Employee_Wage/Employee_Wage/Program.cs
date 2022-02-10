// See https://aka.ms/new-console-template for more information
using System;

namespace Employee_Wage;

class Program
{
    static int calculate_working_hrs()

    {
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        int WorkingHr = 0;
        const int ABSENT = 0;
        const int FULLTIME = 1;
        switch (empCheck)
        {
            case ABSENT:
                WorkingHr = 0;
                // Console.WriteLine("Employee is Absent");return WorkingHr;
                return WorkingHr;
                break;

            case FULLTIME:
                WorkingHr = 8;
                // Console.WriteLine("Employee is Full Time Present");
                return WorkingHr;
                break;

            default:
                WorkingHr = 4;
                //Console.WriteLine("Employee is Part Time Present");
                return WorkingHr;
                break;

        }

    }
    public static void Main(string[] args)
    {
        int MAXDAY = 20;
        int TOTALWORKINGHRS = 100;
        int WAGEPERHRS = 20;

        int day = 0;
        int totalworkingHrs = 0;
        while (day < MAXDAY && totalworkingHrs < TOTALWORKINGHRS)
        {

            totalworkingHrs = totalworkingHrs + calculate_working_hrs();
            int empDailyWage = WAGEPERHRS * calculate_working_hrs();
            Console.WriteLine($"Employee Daily Wage is {empDailyWage}");
            day++;
        }
        Console.WriteLine($"Total Days:{day} & Total Working Hours:{totalworkingHrs}");

    }


}



