using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseNumber
    {
        public void ReverseNumberProgram() {

            int num = 153;
            int rev = 0;
            int rem = 0;

            while(num > 0)
            {
                rem = num % 10; //153%10 = 3 // 15%10=5 // 1%10 = 1
                rev = (rev * 10) + rem; // 0+3 = 3 // 3*10+5 = 35 // 35*10+1=351
                num = num / 10; //153/10 = 15 // 15/10= 1 //1/10 =0
            }
            Console.WriteLine(rev);
        }
    }
}
