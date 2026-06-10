using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BinarySearch
    {
        // arr = {1,2,3,4,5} target=4; output=3;       

        public void BinarySearchProgram()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int target = 4;

            int left = 0;
            int right = numbers.Length - 1;
            int result = -1;

            while(left <= right)
            {
                int mid = left + right - left / 2;

                if (numbers[mid] == target)
                {
                    result = mid;
                    break;
                }
                else if (numbers[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
            Console.WriteLine(result);
        }
    }
}
