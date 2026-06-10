using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BubbleSort
    {
        public void BubbleSortProgram() {


            int[] input = { 7, 5, 52, 96, 2, 44};

            for(int i = 0; i < input.Length-1; i++)
            {
                for(int j = 0; j < input.Length-1-i; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }

            foreach(var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
