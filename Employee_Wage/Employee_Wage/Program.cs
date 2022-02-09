// See https://aka.ms/new-console-template for more information
using System;

namespace Employee_Wage;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        int WorkingHr = 0;
        int WagePerHrs = 20;
        const int Absent = 0;
        const int FullTime = 1;
        switch (empCheck)
        {
            case Absent:
                WorkingHr = 0;
                Console.WriteLine("Employee is Absent");
                break;

            case FullTime:
                WorkingHr = 8;
                Console.WriteLine("Employee is Full Time Present");
                break;

            default:
                WorkingHr = 4;
                Console.WriteLine("Employee is Part Time Present");
                break;
        }

        int EmpDailyWage = WagePerHrs * WorkingHr;
        Console.WriteLine($"Employee Daily Wage is {EmpDailyWage}");
    }
}