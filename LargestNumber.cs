using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LargestNumber
    {
        public void LargestNumberProgram()
        {
            int [] arr = {1,7,4,8,9,5,10,3,45,2};
            int largest = 0;

            for(int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            Console.WriteLine(largest);

        }
    }
}
