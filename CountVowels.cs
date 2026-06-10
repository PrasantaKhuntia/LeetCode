using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountVowels
    {
        public void CountVowelsProgram() {

            string input = "Sunil";
            int count = 0;
            
            foreach(char ch in input.ToLower())
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
