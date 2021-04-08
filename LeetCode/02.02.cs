using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Class11    //函数的参数只有头节点head
    {
        #region LinkList
        public class LinkNode<T>
        {
            private T data;
            private LinkNode<T> next;

            public T Data
            {
                get { return data; }
                set { value = data; }
            }
            public LinkNode<T> Next
            {
                get { return next; }
                set { next = value; }
            }
        }
        public class LinkList<T> : IList<T>
        {
            private LinkNode<T> head;

            public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public LinkNode<T> Head
            {
                get { return head; }
                set { head = value; }
            }

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
        public LinkNode<int> EndofList(LinkList<int> p, int k)//当给了一个链表时
        {
            if (k < 0 || k > p.Count)
            {
                Console.WriteLine("k Out Range");
                return default(LinkNode<int>);
            }

            int flag = 0;
            LinkNode<int> q = new LinkNode<int>();
            q = p.Head;
            while ((q.Next != null) && (flag < p.Count - k))
            {
                q = q.Next;
            }
            if (flag == p.Count - k)
            {
                return q;
            }
            return null;
        }
          

        //当只给头节点时；用两个步差为k的指示器  
        //当前面的指示器指向null时，后面的指示器指向倒数k个结点

        public int EndofList1(LinkNode<int>head,int k)
        {
            LinkNode<int> p = new LinkNode<int>();
            LinkNode<int> q = new LinkNode<int>();
            p = head;
            q = head;
            for(int i = 0; i < k; i++)
            {
                p = p.Next;
            }
            while (p.Next != null)
            {
                p = p.Next;
                q = q.Next;
            }
            if (p.Next == null)
            {
                return q.Data;
            }
            return q.Data;
        }
    }
}
