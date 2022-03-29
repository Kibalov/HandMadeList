using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class MyList<T>
    {
        public IEnumerable<T> this [int key]
        {
            get
            {
                return GetAll();
            }
        }
        MyListNode<T> first;
        public int Count { get; protected set; } = 0;
        public void AddBefore(T item, int index)
        {
            MyListNode<T> CurrentNode = GetByIndex(index);
            MyListNode<T> AddingNode = new MyListNode<T>();
            AddingNode.value = item;

            if (index != 0)
                AddingNode.Previous = CurrentNode.Previous;
            AddingNode.Next = CurrentNode;
            if (index != 0)
                CurrentNode.Previous.Next = AddingNode;
            CurrentNode.Previous = AddingNode;
            if (index == 0)
                first = AddingNode;
            Count++;
        }
        public void AddBegin(T value)
        {
            MyListNode<T> item = new MyListNode<T>();
            item.value = value;
            if (first == null)
                first = item;
            else
            {
                first.Previous = item;
                item.Next = first;
                first = item;
            }
            Count++;
        }
        public void AddEnd(T value)
        {
            if (first == null)
            {
                first = new MyListNode<T>();
                first.value = value;
            }
            else
            {
                MyListNode<T> Node = first;
                while (Node.Next != null)
                {
                    Node = Node.Next;
                }
                Node.Next = new MyListNode<T>();
                Node.Next.value = value;
                Node.Next.Previous = Node;

            }
            Count++;
        }
        public void RemoveByIndex(int index)
        {
            if (index == 0)
            {
                first = first.Next;
                first.Previous = null;

                Count--;
            }
            else
            {
                MyListNode<T> DeletingNode = GetByIndex(index);
                if (DeletingNode != null)
                {
                    MyListNode<T> NextNode = DeletingNode.Next;
                    MyListNode<T> PrevNode = DeletingNode.Previous;
                    if (PrevNode != null)
                        NextNode.Previous = PrevNode;
                    if (NextNode != null)
                        PrevNode.Next = NextNode;

                    Count--;
                }
            }
        }
        public void Clear()
        {
            first = null;
            Count = 0;
        }
        public new string ToString
        {
            get
            {
                string str = "";
                MyListNode<T> Node = first;
                while (Node != null)
                {
                    str += Convert.ToString(Node.value) + " ";
                    Node = Node.Next;
                }
                return str;
            }
        }

        public MyListNode<T> GetByIndex(int index)
        {
            if (index < Count)
            {
                MyListNode<T> Node = first;
                for (int i = 0; i <= index; i++)
                {
                    if (Node != null)
                    {
                        if (i == index)
                            return Node;
                        Node = Node.Next;
                    }
                }
            }
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            MyListNode<T> Node = first;
            while (Node != null)
            {
                yield return Node.value;
                Node = Node.Next;
            }
        }

    }
    
}
