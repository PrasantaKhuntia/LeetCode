using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class CountWords
    {
        public void CountWordsProgram() {

            string input = "my name is sunil and I stay in pune";

            string[] words = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }
    }
}
