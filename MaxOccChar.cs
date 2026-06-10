using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaxOccChar
    {
        public void MaxOccCharProgram()
        {
            string str = "ssssssssssuniiillllll";

            var result = str.GroupBy(x => x)
                .OrderByDescending(y => y.Count())
                .First();

            Console.Write(result.Key + " - " + result.Count());
        }
    }
}
