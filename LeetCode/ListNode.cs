using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode dummyHead = new ListNode();
                ListNode current = dummyHead;
                int carry = 0;

                while (l1 != null || l2 != null || carry != 0)
                {
                    int x = (l1 != null) ? l1.val : 0;
                    int y = (l2 != null) ? l2.val : 0;

                    int sum = x + y + carry;
                    carry = sum / 10;

                    current.next = new ListNode(sum % 10);
                    current = current.next;

                    if (l1 != null) l1 = l1.next;
                    if (l2 != null) l2 = l2.next;
                }

                return dummyHead.next;
            }
        }
        public static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }

        public static void Result()
        {
            // Criação de duas listas encadeadas representando os números
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));  // Representa o número 342
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));  // Representa o número 465
            
            // Criação de uma instância da classe Solution
            Solution solution = new Solution();

            // Chamada da função AddTwoNumbers para realizar a soma
            ListNode result = solution.AddTwoNumbers(l1, l2);

            // Exibição do resultado
            PrintList(result);
        }
    }
}
