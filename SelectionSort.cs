using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SelectionSort
    {
        public void SelectionSortProgram()
        {

            int[] arr = { 64, 25, 12, 22, 11 };

            for (int i = 0; i < arr.Length - 1; i++)
            {

                int tempIndex = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[tempIndex])
                    {
                        tempIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[tempIndex];
                arr[tempIndex] = temp;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
