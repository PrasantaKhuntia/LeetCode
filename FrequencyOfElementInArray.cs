using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FrequencyOfElementInArray
    {
        public void FrequencyOfElementInArrayProgram() {

            int[] arr = { 1, 2, 3, 44, 1, 5, 2, 1, 44 };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var item in arr)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
        }
    }
}
