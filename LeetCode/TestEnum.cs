using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TestEnum
    {
        public static void IEnu()
        {
            IEnumerable<int> list = Enumerable.Range(1, 5);
            List<int> list2 = list.Where(item =>
            {
                Console.WriteLine("Teste número: " + item);
                return item > 3;
            }).ToList();

            //foreach (int item in list2)
            //{
            //    Console.WriteLine("Resultado: " + item);
            //}

            //foreach (int item in list2)
            //{
            //    Console.WriteLine("Resultado 2: " + item);
            //}
        }
    }
}
