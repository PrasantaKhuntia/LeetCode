using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseSentense
    {
        public void ReverseSentenceProgram() {

            string sentense = "my name is sunil"; // "sunil is name my"

            string[] arr = sentense.Split(" ");

            Array.Reverse(arr);

            string reversedSentense = string.Join(" ", arr);

            Console.WriteLine(reversedSentense);
        }
    }
}
