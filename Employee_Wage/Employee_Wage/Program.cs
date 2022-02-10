﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Employee_Wage;

class Program
{
    static int calculate_working_hrs()

    {
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        //Veriables
        int WorkingHr = 0;

        //Constants
        const int ABSENT = 0;
        const int FULLTIME = 1;

        switch (empCheck)
        {
            case ABSENT:
                WorkingHr = 0;
                // Console.WriteLine("Employee is Absent");return WorkingHr;
                break;

            case FULLTIME:
                WorkingHr = 8;
                // Console.WriteLine("Employee is Full Time Present");
                break;

            default:
                WorkingHr = 4;
                //Console.WriteLine("Employee is Part Time Present");
                break;

        }
        return WorkingHr;


    }
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

            totalWorkingHrs = totalWorkingHrs + calculate_working_hrs();
            int empDailyWage = WAGEPERHRS * calculate_working_hrs();
            empTotalWage = empTotalWage + empDailyWage;
            dailywage[day] = empDailyWage;
            Console.WriteLine($"DAY {day + 1} Wage is {dailywage[day]}");
            day++;
        }
        Console.WriteLine($"Total Days:{day} , Total Working Hours:{totalWorkingHrs} & Total Employee Wage:{empTotalWage}");

    }


}



