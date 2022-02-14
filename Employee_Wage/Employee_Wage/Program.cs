// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wage;

class Program
{

    public static void Main(string[] args)
    {
        //Constants
        int MAXDAY = 20;
        int TOTALWORKINGHRS = 100;
        int WAGEPERHRS = 20;

        //Veriables
        int day = 0;
        int totalWorkingHrs = 0;
        int empTotalWage = 0;

        Dictionary<int, int> dailywage = new Dictionary<int, int>();

        while (day < MAXDAY && totalWorkingHrs < TOTALWORKINGHRS)
        {
            int workingHrs = EmployeeWage.GetWorkingHrs();

            totalWorkingHrs = totalWorkingHrs + workingHrs;
            int empDailyWage = WAGEPERHRS * workingHrs;
            empTotalWage = empTotalWage + empDailyWage;
            dailywage[day] = empDailyWage;
            Console.WriteLine($"DAY {day + 1} Wage is {dailywage[day]}");
            day++;
        }
        Console.WriteLine($"Total Days:{day} , Total Working Hours:{totalWorkingHrs} & Total Employee Wage:{empTotalWage}");

    }


}



