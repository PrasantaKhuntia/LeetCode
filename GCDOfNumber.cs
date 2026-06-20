using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class GCDOfNumber
    {
        public void GCDOfNumberProgram() {

            int a = 12; // 1,2,3,4,6,12
            int b = 18; // 1,2,3,6,9,18 //output = 6 GCD

            //b = a%b
            //a = b
            int temp = 0;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine("GCD is " + a);
        }
    }
}
