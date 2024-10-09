using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    public class LinkedStack<T> : DoublyLinkedList<T>, AbstractStack<T>
    {
        public void Push(T newData)
        {
            Append(newData);
        }

        public CustomLinkedListNode<T>? Peek()
        {
            if (!IsEmpty())
            {
                return Search(Length - 1);
            }
            else
            {
                return null;
            }
        }

        public CustomLinkedListNode<T>? Pop()
        {
            if (!IsEmpty())
            {
                return Delete(Length - 1);
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty() { return Length == 0; }
    }
}
