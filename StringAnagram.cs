using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class StringAnagram
    {
        public void StringAnagramProgram() {

            //listen = 6
            //silent = 6

            string str1 = "listen";
            string str2 = "silent";

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1); // opt
            Array.Sort(arr2); // opt

            string str3 = new string(arr1);
            string str4 = new string(arr2);

            if (str3 == str4)
            {
                Console.WriteLine("It is Anagram");
            }
            else {
                Console.WriteLine("It is not Anagram");
            }
        }
    }
}
