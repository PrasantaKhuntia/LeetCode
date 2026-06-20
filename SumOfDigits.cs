using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SumOfDigits
    {
        public void SumOfDigitsProgram() {

            int num = 123;//1+2+3=6 //123%10=10*12=120=mod=3
            int digit = 0;
            int sum = 0;

            while (num > 0)
            {
                digit = num % 10;//3 then 2 then 1
                sum = sum + digit; //0+3, 3+2, 5+1, 6
                num = num / 10; //123/10 = 12, 12/10 = 1, 1/10=0
            }
            Console.WriteLine(sum);


        }
    }
}
