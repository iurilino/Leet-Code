using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Palindrome
    {
        //public static bool IsPalindrome(int x)
        //{
        //    int p = x % 10;
        //    int r = x;
        //    string soma = "";

        //    while(r % 10 != 0)
        //    {
        //        soma += p;
        //        r /= 10;
        //        p = r % 10;                
        //    }

        //    int result = Convert.ToInt32(soma);

        //    return result == x;
        //}

        public static bool IsPalindrome(int x)
        {
            int r = 0, c = x;
            while (c > 0)
            {
                r = r * 10 + c % 10;
                c /= 10;
            }
            return r == x;
        }

        //public static bool IsPalindrome(int x)
        //{
        //    string p = x.ToString();
        //    char[] charArray = p.ToCharArray();
        //    Array.Reverse(charArray);
        //    string r = new string(charArray);

        //    return r == p;
        //}
    }
}
