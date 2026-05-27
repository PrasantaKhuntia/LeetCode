using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SmallestNumber
    {
        public void SmallestNumberProgram() {

            int[] arr = {7, 4, 8, 9, 5, 10, 3, 45};
            int smallest = arr[0];

            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i]; 
                }
            }
            Console.WriteLine(smallest);
        }
    }
}
