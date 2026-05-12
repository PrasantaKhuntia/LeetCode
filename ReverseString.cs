using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class ReverseString
    {
        public static string name = "sunil";

        char[] ch = name.ToCharArray();
        StringBuilder sb = new StringBuilder();

        public void ReverseStringProgram()
        {
            for(int i = ch.Length-1; i>=0; i--)
            {
                sb.Append(ch[i]);
            }
            Console.WriteLine(sb.ToString());
        }



    }
}
