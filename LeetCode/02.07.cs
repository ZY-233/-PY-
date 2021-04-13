using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class16
    {

        //链表反转

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //public class Solution
        //{
        //    public ListNode ReverseList(ListNode head)
        //    {
        //        ListNode p = head;
        //        ListNode q = null;

        //        while (p != null)
        //        {
        //            if (q == null)
        //            {
        //                p.next = null;
        //                q = p;
        //            }
        //            if (q != null)
        //            {
        //                p.next = q;
        //                q = p;
        //            }
        //            p = p.next;
        //        }
        //        return q;
        //    }
        //    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        //    {
        //        if (headA == null || headB == null)
        //        {
        //            return null;
        //        }

        //        ListNode p = ReverseList(headA);
        //        ListNode q = ReverseList(headB);

        //        if (p != q)
        //        {
        //            return null;
        //        }
        //        while (p != null && q != null)
        //        {
        //            if (p != q)
        //            {
        //                return p;
        //            }
        //            p = p.next;
        //            q = q.next;
        //        }
        //        return null;
        //    }
        //}
        //public class Solution
        //{
        //    ListNode ReverseList(ListNode head)
        //    {
        //        ListNode p = head;
        //        ListNode q = null;

        //        while (p != null)
        //        {
        //            if (q == null)
        //            {
        //                p.next = null;
        //                q = p;
        //            }
        //            if (q != null)
        //            {
        //                p.next = q;
        //                q = p;
        //            }
        //            p = p.next;
        //        }
        //        return q;
        //    }
        //    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        //    {

        //        if (headA == null || headB == null)
        //        {
        //            return null;
        //        }

        //        ListNode p = ReverseList(headA);
        //        ListNode q = ReverseList(headB);

        //        if (p != q)
        //        {
        //            return null;
        //        }
        //        while (p != null && q != null)
        //        {
        //            if (p != q)
        //            {
        //                return p;
        //            }
        //            p = p.next;
        //            q = q.next;
        //        }
        //        return null;              
        //    }
        //}

        //public class Solution
        //{
        //    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)//超时
        //    {
        //        if (headA == null || headB == null)
        //        {
        //            return null;
        //        }
        //        Dictionary<ListNode,int> dict = new System.Collections.Generic.Dictionary<ListNode,int>();
        //        ListNode q = headB;

        //        for(ListNode node =headA;node!=null;node = node.next)
        //        {
        //            dict.Add(node, node.val);
        //        }

        //        while (q != null)
        //        {
        //            if(dict.TryGetValue(q, out q.val))
        //            {
        //                return q;
        //            }
        //        }
        //        return null;

        //    }
        //}
        public class Solution
        {
            public ListNode GetIntersectionNode(ListNode headA, ListNode headB)//超时
            {
                if (headA == null || headB == null)
                {
                    return null;
                }
                ListNode la = headA;
                ListNode lb = headB;
                while (la != lb)
                {
                    //到达链表末尾时，重新走另一条链表的路
                    la = la == null ? headB : la.next;
                    lb = lb == null ? headA : lb.next;
                }
                return la;
            }
        }
    }
}

