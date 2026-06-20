using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RotateArrayLeft
    {
        public void RotateArrayLeftProgram() {

            int[] arr = {1,2,3,4,5}; // 3,4,5,1,2
            int n = 2;
            
            for(int i=0; i<n; i++)
            {
                int temp = arr[0];
                for(int j=0; j<arr.Length-1; j++)
                {
                    arr[j] = arr[j+1];//2,3,4,5,1 // 3,4,5,1,2
                }
                arr[arr.Length-1] = temp;
            }
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
