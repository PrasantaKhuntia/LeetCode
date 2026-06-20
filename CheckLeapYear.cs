using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CheckLeapYear
    {
        public void CheckLeapYearProgram() {

            //year%400 or (year%4 && !year%100) = Leap Year

            int year = 2025;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
    }
}
