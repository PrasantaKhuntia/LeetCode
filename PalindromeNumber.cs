using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PalindromeNumber
    {
        int rem = 0;
        int rev = 0;
        int ori = 0;
        public void PalindromeNumerProgram(int n)
        {
            ori = n;
            while (n > 0) //121
            {
                rem = n % 10; //121%10 = 1 //12%10 = 2 //1%10 = 1
                rev = rem + rev * 10; //1+ 0*10 = 1 //2 + 1*10 = 12 //1 + 12*10 = 121
                n = n / 10;//121/10 = 12 //12/10 = 1 //1/10 = 0
            }
            Console.WriteLine("original value - " + ori);
            Console.WriteLine("reversed value - " + rev);

            if(ori == rev)
            {
                Console.WriteLine("The number is a palindrome");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome");
            }

        }
    }
}
