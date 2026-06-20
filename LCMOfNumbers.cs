using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LCMOfNumbers
    {
        public void LCMOfNumbersProgram() {

            int a = 12; // 1,2,3,4,6,12
            int b = 18; // 1,2,3,6,9,18 //output = 6 GCD

            //12 = 12, 24, 36, 48
            //18 = 18, 36, 54

            //output = 36

            int num1 = a;
            int num2 = b;

            //b = a%b
            //a = b
            int temp = 0;
            int GCD = 0;

            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            GCD = a;

            // LCM = a*b/GCD
            Console.WriteLine(num1 * num2 / GCD);
        }
    }
}
