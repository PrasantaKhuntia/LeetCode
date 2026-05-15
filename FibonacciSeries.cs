using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FibonacciSeries
    {
        //n=7 , 0,1,1,2,3,5,8
        public void FibonacciSeriesprogram(int n)
        {
            int n1 = 0;
            int n2 = 1;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            int sum = 0;

            for(int i=2; i<n; i++)
            {
                sum = n1 + n2;
                Console.WriteLine(sum);

                n1 = n2;
                n2 = sum;
            }
        }
    }
}
