using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PrimeNumber
    {
        // 2 = 2 and 1 = isPrime
        // 3 = 3 and 1 = isPrime
        // 4 = 1, 2 and 4 = isNotPrime

        public bool PrimeNumberProgram(int n)
        {
            bool isPrime = true;

            if (n <= 1)
            {
                isPrime = false;
                return isPrime;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++) {

                if (n % i == 0) {
                    isPrime = false;
                    return isPrime;
                }            
            }
            return isPrime;
        }
    }
}
