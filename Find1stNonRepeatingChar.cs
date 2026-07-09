using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Find1stNonRepeatingChar
    {
        public void Find1stNonRepeatingCharProgram() {

            string str = "programming"; //p=1,r=2,o=1... //output = p

            Dictionary<char,int> dict = new Dictionary<char,int>();

            foreach (char ch in str)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict[ch] = 1;
                }
            }

            foreach(char ch in str)
            {
                if(dict[ch] == 1)
                {
                    Console.WriteLine(ch);
                    return;
                }
            }
        }
    }
}
