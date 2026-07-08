using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CountChar
    {
        public void CountCharProgram() {

            // string = "programming", target = m , output m=2

            string input = "programming";
            char target = 'm';
            int count = 0;

            foreach (char c in input) {

                if (c == target)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
