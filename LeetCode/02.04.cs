using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class13
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

        public ListNode PartitionList(ListNode head,int x)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode left = new ListNode(-1);
            ListNode right = new ListNode(-1);
            ListNode p = left;
            ListNode q = right;

            while (head != null)
            {
                ListNode t = head.next;
                head.next = null;
                if (head.val < x)
                {
                    p.next = head;
                    p = p.next;
                }
                else
                {
                    q.next = head;
                    q = q.next;
                }
                head = t;
            }

            p.next = right.next;
            return left.next;
        }

    }

}
