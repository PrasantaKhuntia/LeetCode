using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MergeTwoArrays
    {
        public void MergeTwoArraysProgram() {

            int[] arr1 = {1,3,5};
            int[] arr2 = {2,4,6};

            int[] arr3 = new int[arr1.Length + arr2.Length];

            arr1.CopyTo(arr3, 0);
            arr2.CopyTo(arr3, arr1.Length);

            //Array.Sort(arr3);

            foreach( var item in arr3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
