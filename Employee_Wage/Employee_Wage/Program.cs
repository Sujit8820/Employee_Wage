// See https://aka.ms/new-console-template for more information
using System;

namespace Employee_Wage;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int empCheck = random.Next(0, 2);

        int Absent = 0;
        if (empCheck == Absent)
        {
            Console.WriteLine("Employee is Absent");
        }
        else
        {
            Console.WriteLine("Employee is Present");
        }
    }
}
