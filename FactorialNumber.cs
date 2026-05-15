using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FactorialNumber
    {
        // 5 = 5*4*3*2*1 = 120
        // 3 = 3*2*1 = 6

        public void FactorialNumberProgram(int n)
        {

            int fact = 1;

            for (int i = n; i >= 1; i--)
            {
                fact = fact * i; // 5*4*3*2*1 = 120
            }
            Console.WriteLine(fact);
        }
    }
}
