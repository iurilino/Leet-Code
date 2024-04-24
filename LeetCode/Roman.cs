using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Roman
    {
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // Se o valor do caractere atual for menor que o valor do próximo caractere, subtrai
                if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]])
                {
                    result -= romanValues[s[i]];
                }
                else
                {
                    result += romanValues[s[i]];
                }
            }

            return result;
        }
    }
}

// Fiz assim:
/*public class Solution
{
    public int RomanToInt(string s)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            char c2 = '\0';

            if (i < s.Length - 1)
            {
                c2 = s[i + 1];
            }

            string roman = c.ToString() + c2;
            if (roman == "IV")
            {
                list.Add(4);
                i += 1;
            }
            else if (roman == "IX")
            {
                list.Add(9);
                i += 1;
            }
            else if (roman == "XL")
            {
                list.Add(40);
                i += 1;
            }
            else if (roman == "XC")
            {
                list.Add(90);
                i += 1;
            }
            else if (roman == "CD")
            {
                list.Add(400);
                i += 1;
            }
            else if (roman == "CM")
            {
                list.Add(900);
                i += 1;
            }
            else
            {
                switch (c)
                {
                    case 'I':
                        list.Add(1);
                        break;
                    case 'V':
                        list.Add(5);
                        break;
                    case 'X':
                        list.Add(10);
                        break;
                    case 'L':
                        list.Add(50);
                        break;
                    case 'C':
                        list.Add(100);
                        break;
                    case 'D':
                        list.Add(500);
                        break;
                    case 'M':
                        list.Add(1000);
                        break;
                }
            }
        }

        return list.Sum();
    }
}*/
