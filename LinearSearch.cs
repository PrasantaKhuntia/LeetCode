using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LinearSearch
    {
        public void LinearSearchProgram() { 
        
            // arr = {4,5,2,1,3}; target=1; output=3;

            int[] arr = { 4, 5, 2, 1, 3 };
            int target = 5;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
