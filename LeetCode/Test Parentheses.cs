using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Test_Parentheses
    {
        public static bool IsValid(string s)
        {
            var stack = new char[s.Length];
            int p = -1;
            var dict = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'{', '}'},
                {'[', ']'}
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    p++;
                    stack[p] = dict[s[i]];                    
                }
                else if (p >= 0 && p < s.Length && stack[p] == s[i])
                {
                    p--;
                }
                else
                    return false;
            }

            //if (p != 0) return false;
            return p == -1;
        }
    }
}
