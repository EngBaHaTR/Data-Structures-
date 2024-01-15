using LinkedList;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        MyLinkedList<int> test = new MyLinkedList<int>();

        test.AddLastItem(5);
        test.AddLastItem(2);
        test.AddLastItem(3);
        test.AddFirst(0);
        test.InsertAfter(test.Find(4), 100);

        test.PrintList();

        Console.WriteLine("List count: " + test.count);

        test.RemoveFirst();
        test.RemoveLast();

        test.PrintList();

        test.Clear();

        Console.WriteLine("List count: " + test.count);

        Console.ReadLine();
    }
}