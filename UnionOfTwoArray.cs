using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class UnionOfTwoArray
    {
        public void UnionOfTwoArrayProgram() {

            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 2, 5, 6, 4 };

            //union arr3 = {1,2,3,4,5,6}

            HashSet<int> set = new HashSet<int>();

            foreach(var item in arr1)
            {
                set.Add(item);
            }

            foreach (var item in arr2)
            {
                set.Add(item);
            }

            foreach(var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
