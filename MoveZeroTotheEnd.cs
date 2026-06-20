using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MoveZeroToTheEnd
    {
        public void MoveZeroToTheEndProgram() {

            int[] arr = {1,2,0,3,4,0,5,0}; //{1,2,3,4,5,0,0,0}

            int j = 0;

            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[j] = arr[i];
                    j++;
                }
            }// {1,2,3,4,5} j=4

            while (j < arr.Length)
            {
                arr[j] = 0;
                j++;
            }////{1,2,3,4,5,0,0,0}

            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
