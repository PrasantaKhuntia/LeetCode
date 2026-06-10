using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class IntersectionOfTwoArray
    {
        public void IntersectionofTwoArrayProgram() {

            int[] arr1 = {1,2,3,4,5,6,9};
            int[] arr2 = {2,3,4,9}; //output = 2,3,4,9

            HashSet<int> set = new HashSet<int>(arr1);

            foreach(var item in arr2)
            {
                if (set.Contains(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
