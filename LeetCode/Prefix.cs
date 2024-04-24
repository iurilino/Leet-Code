using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Prefix
    {
        public static string LongestCommonPrefix()
        {
            string[] strs = new string []{ "flower", "fight", "flight" };

            string shortest = strs.OrderBy(s => s.Length).First();

            for (int i = 0; i < shortest.Length; i++)
            {
                var teste = strs.Select(s => s[i]).Distinct();
                if (strs.Select(s => s[i]).Distinct().Count() > 1) return shortest[..i];
            }

            return shortest;
        }
    }
}
