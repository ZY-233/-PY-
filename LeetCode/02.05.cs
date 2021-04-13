using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class14
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int m)
            {
                val = m;
                next = null;
            }
        }

        public ListNode TwoNumsSum(ListNode l1, ListNode l2)
        {
			int carray = 0;//进位
			ListNode head = new ListNode(-1);
			ListNode pre = head;
			while (l1 != null || l2 != null || carray != 0)//carray!=0意味着 如果两个链表都遍历完之后还有进位，把这个进位加上
			{
				int sum = carray;
				if (l1 != null)
				{
					sum += l1.val;
					l1 = l1.next;
				}
				if (l2 != null)
				{
					sum += l2.val;
					l2 = l2.next;
				}
				pre.next = new ListNode(sum % 10);//将和存到新链表中
				pre = pre.next;//pre指向下一个节点
				carray = sum / 10;//进位

			}
			return head.next;
		}

    }
}
