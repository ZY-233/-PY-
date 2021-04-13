using System;
using System.Collections.Generic;
using System.Text;


namespace LeetCode
{
    class Class15
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
        #region 失败的尝试
        //public bool ReserveList(ListNode head)
        //{
        //    if (head == null)
        //    {
        //        return false;
        //    }
        //    else if (head.next == null)
        //    {
        //        return true;
        //    }
        //    ListNode p = head.next;
        //    int[] flag = new int[256];

        //    while (head != null)
        //    {
        //        flag[(int)head.val] += 1; 
        //    }
        //    int car = 0;
        //    for(int i = 0; i < 256; i++)
        //    {
        //        if (flag[i] % 2 != 0)
        //        {
        //            car++;
        //        }
        //    }
        //    if (car > 1)
        //    {
        //        return false;
        //    }
        //    return true;

        //}

        //public bool ReverseList(ListNode head)//超出内存限制
        //{
        //    if (head == null)
        //    {
        //        return true;
        //    }

        //    List<int> p = new List<int>();

        //    while (head != null)
        //    {
        //        p.Add(head.val);           
        //    }
        //    for(int i = 0; i < p.Count/2; i++)
        //    {
        //        if(p[i] != p[p.Count - 1])
        //        {
        //            return false;
        //        }

        //    }
        //    return true;
        //}
        #endregion
        //推荐解法
        public ListNode FindMidNode(ListNode head)//寻找链表中间结点
        {

            var slowNode = head;
            for(var node = head;node.next!=null&&node.next.next!=null;node = node.next.next)
            {
                slowNode = slowNode.next;
            }
            return slowNode;
        }

        public ListNode ReverseList(ListNode head)//链表反转
        {
            ListNode p = head;
            ListNode q = null;

            while (p != null)
            {
                if (q == null)
                {
                    p.next = null;//head.next第一个节点放在末尾
                    q = p;//q = p;即q 指向当前p的结点，p=p.next后，将p指向q即可完成反转
                }
                else
                {
                    p.next = q;
                    q = p;
                }
                p = p.next;
            }
            return q;
        }

        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return true;
            }
            ListNode midList = FindMidNode(head);
            ListNode secondList = ReverseList(midList.next);

            ListNode cur1 = head;
            ListNode cur2 = secondList;

            bool palindrome = true;

            while (palindrome && cur2 != null)
            {
                if (cur1.val != cur2.val)
                {
                    palindrome = false;
                }
                cur1 = cur1.next;
                cur2 = cur2.next;
            }

            return palindrome;
        } 
    }
}
