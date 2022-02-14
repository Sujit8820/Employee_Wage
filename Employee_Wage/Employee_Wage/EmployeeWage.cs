using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage
{
    class EmployeeWage
    {

        public static int GetWorkingHrs()
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
                    break;

                case FULLTIME:
                    WorkingHr = 8;
                    break;

                default:
                    WorkingHr = 4;
                    break;
            }
            return WorkingHr;
        }
    }
}
