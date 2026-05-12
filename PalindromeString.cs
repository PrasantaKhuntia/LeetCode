using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class PalindromeString
    {       
        public static string name = "madam";

        char[] ch = name.ToCharArray();
        StringBuilder sb = new StringBuilder();

        public void PalindromeStringProgram()
        {
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                sb.Append(ch[i]);
            }
            Console.WriteLine("original string - " + name);
            Console.WriteLine("reversed string - " + sb.ToString());

            if (name == sb.ToString())
            {
                Console.WriteLine("the string is palindrome");
            }
            else
            {
                Console.WriteLine("the string is not palindrome");
            }
        }
    }
}
