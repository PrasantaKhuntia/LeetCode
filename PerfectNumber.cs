using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PerfectNumber
    {
        public void PerfectNumberProgram() { 
        
        
            int num = 7; // 1+2+3=6 // sum of all the divisor excluding the number itself
            int sum = 0;

            for(int i=1; i<num; i++)
            {
                if(num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("This is a perfect number");
            }
            else
            {
                Console.WriteLine("This is not a perfect number");
            }

        }
    }
}
