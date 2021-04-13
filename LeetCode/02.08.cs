using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
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
    class Class17
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode slow = head;
            ListNode fast = head;
            ListNode point = head;
            while (fast!=null)
            {
                slow = slow.next;
                if (fast.next != null)
                {
                    fast = fast.next.next;
                }
                else
                {
                    return null;
                }
                if (fast == slow)
                {
                    while (slow != point)
                    {
                        slow = slow.next;
                        point = point.next;
                    }
                    return point;
                }
            }
            return null;

        }
        public ListNode DetectCycle1(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            Dictionary<ListNode, int> dict = new Dictionary<ListNode, int>();
            ListNode p = head;
            while (p != null)
            {
                if (dict.ContainsKey(p))
                {
                    return p;
                }
                else
                {
                    dict.Add(p,p.val);
                }
                p = p.next;
            }
            return null;
                 
        }
    }
}
