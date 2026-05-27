using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SecondSmallest
    {
        public void SecondSmallestProgram() {

            int[] arr = { 4, 66, 70, 8, 2};//4

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondSmallest && arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                }
            }
            Console.WriteLine(secondSmallest);
        }
    }
}
