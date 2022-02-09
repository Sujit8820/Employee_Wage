// See https://aka.ms/new-console-template for more information
using System;

namespace Employee_Wage;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int empCheck = random.Next(0, 2);
        int WorkingHr = 0;
        int WagePerHrs = 20;
        int Absent = 0;
        if (empCheck == Absent)
        {
            WorkingHr = 0;
            Console.WriteLine("Employee is Absent");
        }
        else
        {
            WorkingHr = 8;
            Console.WriteLine("Employee is Present");
        }

        int EmpDailyWage = WagePerHrs * WorkingHr;
        Console.WriteLine($"Employee Daily Wage is {EmpDailyWage}");
    }
}