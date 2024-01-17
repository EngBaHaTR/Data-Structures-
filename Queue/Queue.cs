using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T> : MyLinkedList<T>
    {
        public T item { get; set; }
        public MyLinkedList<T> q = new MyLinkedList<T>();

        public void push(T item)
        {
            q.AddLastItem(item);
        }
        public void pop()
        {
            q.RemoveFirst();
        }
        public int Size()
        {
            return q.Size();
        }
        public T Front()
        {
            return q.Head.Data;
        }
        public T Bake()
        {
            return q.Tail.Data;
        }
        public void print()
        {
            q.PrintList();
        }





    }
}
