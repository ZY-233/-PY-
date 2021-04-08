using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class12
    {
        public class LinkNode
        {
            public int data;
            public LinkNode next;

            public LinkNode()
            {
               
                next = null;
            }
        }

        public void DeleteMidNote(LinkNode p)//简单题
        {
            LinkNode q = new LinkNode();

            q = p.next;
            p.data = q.data;
            p.next = q.next;
            return;
        }
    }
}
