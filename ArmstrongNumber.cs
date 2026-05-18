using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ArmstrongNumber
    {
        //153 = 1^3 + 5^3 + 3^3 = 153
        //1634 = 1^4 + 6^4 + 3^4 + 4^4 = 1634
        //22 = 2^2 + 2^2 = 8 - Not an Armstrong Number
        public void ArmstrongNumberProgram(int n)
        {
            int input = n;
            string str = n.ToString();
            double len = str.Length;
            int rem = 0;
            int sum = 0;

            while (n > 0)
            {
                rem = n % 10; 
                sum = sum + (int)Math.Pow(rem, len);
                n = n / 10;
            }
            if (sum == input)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
        }
    }
}
