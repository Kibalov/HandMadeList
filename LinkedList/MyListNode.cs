using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class MyListNode <T>
    {
        public MyListNode<T> Next;
        public MyListNode<T> Previous;
        public T value;
    }
}
