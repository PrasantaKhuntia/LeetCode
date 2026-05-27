using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindMissingElement
    {
        public void FindMissingElementprogram() {

            int[] arr = {1, 2, 3, 4, 5, 7 }; // 6

            // MissingElement = ExpectedSum - ActualSum
            // n = arr.length + 1 = 4+1 = 5
            //ExpectedSum = n(n+1)/2 = 5*6/2 = 30/2 = 15
            //ActualSum = 5+3+2+1 = 11
            //MissingElement = 15 - 11 = 4

            int n = 0;
            int ExpectedSum = 0;
            int ActualSum = 0;
            int MissingElement = 0;

            n = arr.Length + 1;
            ExpectedSum = n*(n + 1) / 2;
            for(int i = 0; i<arr.Length; i++)
            {
                ActualSum += arr[i];
            }
            MissingElement = ExpectedSum - ActualSum;

            Console.WriteLine(MissingElement);
        }
    }
}
