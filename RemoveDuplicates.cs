using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class RemoveDuplicates
    {
        public void RemoveDuplicatesProgram() {

            int[] arr = {5, 6, 7, 99, 203, 5, 7 };

            //hashset = Automatically stores unique elements
            HashSet<int> list = new HashSet<int>();

            for(int i =0; i<arr.Length; i++)
            {
                list.Add(arr[i]);
            }

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        
        }
    }
}
