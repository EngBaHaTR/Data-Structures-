using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Test<T> : MyLinkedList<T> 
    {
        public void pop () 
        {
          RemoveLast ();
        }
        public void push (T i) 
        {
            AddLastItem(i);  
            
        }
       
          public void PrintList() 
        {
          IsEmpty();
        }


    }
}
