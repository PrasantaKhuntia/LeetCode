using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RotateArrayRight
    {
        public void RotateArrayRightProgram()
        {

            int[] arr = {1,2,3,4,5};
            int n = 2; // 5,1,2,3,4 // 4,5,1,2,3

            for(int i=0; i<n; i++)
            {
                int temp = arr[arr.Length-1];

                for(int j=arr.Length-1; j>0; j--)
                {
                    arr[j] = arr[j-1]; //5,1,2,3,4
                }
                arr[0] = temp; // 5,1,2,3,4 // 4,5,1,2,3
            }
            foreach(var item in arr)
            {
                Console.WriteLine(item); // 4,5,1,2,3
            }
        }
    }
}
