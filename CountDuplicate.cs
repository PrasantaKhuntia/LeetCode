using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountDuplicate
    {
        public void CountDuplicateProgram() {

            int[] arr = {2, 5, 6, 33, 2, 6, 8 , 33};//3

            var list = arr.GroupBy(x => x) //2 = 2, 5 = 1, 6 = 2, 33 = 2......
                .Where(y => y.Count() > 1).ToList();

            Console.WriteLine(list.Count());
        }
    }
}
