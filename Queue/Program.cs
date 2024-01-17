using LinkedList;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace Queue
{
     class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Queue<int> queue = new Queue<int>();
            queue.push(1);
            queue.push(2);
            queue.push(3);
            queue.push(4);
            queue.push(5);
            queue.push(6);
            queue.push(7);
            queue.print();
            Console.WriteLine("------");
            queue.pop();
            queue.print();
            Console.WriteLine("------------undo-----");
            queue.IsEmpty();

            Test<int> t = new Test<int>();
            t.push(1);
            t.push(2);
            t.push(3);
            t.Size();
            t.PrintList();
            Console.WriteLine(t.IsEmpty());


        }
    }
  
   
}
