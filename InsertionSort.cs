using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class InsertionSort
    {
        public void InsertionSortProgram() {

            int[] arr = { 5, 3, 4, 1, 2 };

            for(int i=1; i<arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j>=0 && arr[j] < key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }

                arr[j+1] = key;
            }

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
