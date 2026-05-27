using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SecondLargest
    {
        public void SecondLargestProgram() {

            int[] arr = {2, 45, 36, 6, 4 }; //36

            int largest = int.MinValue;
            int secondlargest = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    secondlargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > secondlargest && arr[i] != largest)
                {
                    secondlargest = arr[i];
                }
            }
            Console.WriteLine(secondlargest);
        }
    }
}
