using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinkedList
{

    public class MyLinkedList<T>
    {
        private Node<T> Tail;
        private Node<T> Head;
        public int count;

        public MyLinkedList()
        {
            Tail = null;
            Head = null;
            count = 0;
        }

        public void AddLastItem(T value)
        {
            Node<T> newItem = new Node<T>(value);

            if (Head == null)
            {
                Head = newItem;
                Tail = newItem;
            }
            else
            {
                Tail.Next = newItem;
                Tail = newItem;
            }

            count++;
        }

        public void PrintList()
        {
            Node<T> node = Head;

            if (Head == null)
            {
                Console.WriteLine("List is empty.");
            }
            else
            {
                while (node != null)
                {
                    Console.WriteLine(node.Data);
                    node = node.Next;
                }
            }
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void RemoveFirst()
        {
            if (Head != null)
            {
                Head = Head.Next;
                count--;
            }
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Node<T> node = Head;
                while (node.Next != Tail)
                {
                    node = node.Next;
                }

                node.Next = null;
                Tail = node;
            }

            count--;
        }

        public void Clear()
        {
            Head = Tail = null;
            count = 0;
        }

        public void InsertAfter(Node<T> node, T value)
        {

            Node<T> newNode = new Node<T>(value);
            if (Find(value) == null)
            {
                Console.WriteLine("not Fund 404");
                return;
            }

            newNode.Next = node.Next;
            node.Next = newNode;
            count++;
        }

        public void AddFirst(T value)
        {
            Node<T> newItem = new Node<T>(value);

            if (Head == null)
            {
                Head = newItem;
                Tail = newItem;
            }
            else
            {
                newItem.Next = Head;
                Head = newItem;
            }

            count++;
        }

        public Node<T> Find(T value)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }
    }
}
