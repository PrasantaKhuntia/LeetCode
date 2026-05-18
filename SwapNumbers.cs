using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SwapNumbers
    {
        public void Swapnumbersprogram(int a, int b) //10, 20
        {

            a = a + b; // a = 30
            b = a - b; // b = 30 - 20 = 10
            a = a - b; // a = 30 - 10 = 20

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        
            
    }
}
