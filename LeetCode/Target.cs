using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Target
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int [2];
            bool resultado = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        resultado = true;
                        break;
                    }
                }
                if (resultado)
                {
                    break;
                }
            }

            return result;
        }

        public static void Result(int[] numbers, int target)
        {
            int[] result = TwoSum(numbers, target);
            Console.Write("[");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                if (i < result.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.Write("], ");

            Console.Write("target = " + target);

        }
    }
}
