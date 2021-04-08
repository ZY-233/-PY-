using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
  
    class Class10
    {
        #region LinkList
        public class LinkNode<T>
        {
            private T data;
            private LinkNode<T> next;

            public T Data
            {
                get{ return data; }
                set { data = value; }
            }

            public LinkNode<T> Next
            {
                get { return next; }
                set { next = value; }
            }

            public LinkNode(T val,LinkNode<T> p)
            {
                data = val;
                next = p;
            }
            public LinkNode(T val)
            {
                data = val;
                next = null;
            }
            public LinkNode(LinkNode<T> p)
            {
                data = default(T);
                next = p;
            }
            public LinkNode()
            {
                data = default(T);
                next = null;
            }

        }

        public class LinkList<T>:IList<T>
        {
            private LinkNode<T> head;

            public LinkNode<T> Head
            {
                get { return head; }
                set { head = value; }
            }

            public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int Count => throw new NotImplementedException();

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(T item)
            {
                throw new NotImplementedException();
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            public int IndexOf(T item)
            {
                throw new NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                throw new NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
        }
        #endregion



        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
            }
        }
        public class Solution
        {
            public LinkNode<int> removeDuplicateNodes(LinkNode<int>  head)
            {
                if (head == null || head.Next == null)
                {
                    return head;
                }
                    
                LinkNode<int> p = head;    //原链表的指示器
                LinkNode<int> q = p.Next;  //新链表的指示器
                LinkList<int> vs = new LinkList<int>();
                vs.Head = head;

                while (q != null)
                {        
                    if (!vs.Contains(q.Data))//当p.Data不在新链表中
                    {
                        q.Next = p;
                        q = q.Next;
                        vs.Add(p.Data);
                    }
                    p = p.Next;
                }
                q.Next = null;
                return head;
            }
        }

        public void RemoveNode(LinkList<int> p)
        {
            if (p.Head == null||p.Head.Next==null)
            {
                return;
            }

            LinkList<int> q = new LinkList<int>();
            LinkNode<int> val = new LinkNode<int>();
            val = p.Head;
            q.Head = p.Head;

            while (val.Next != null)
            {
                if (!p.Contains(val.Next.Data))
                {
                    q.Add(val.Next.Data);
                   
                }
                val = val.Next;
            }
            
        }
    }
  

   
}
