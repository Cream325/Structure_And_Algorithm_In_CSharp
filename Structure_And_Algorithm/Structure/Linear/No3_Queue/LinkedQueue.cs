using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    public class LinkedQueue<T> : DoublyLinkedList<T>, AbstractQueue<T>
    {
        public void Enqueue(T newData)
        {
            Append(newData);
        }

        public CustomLinkedListNode<T>? Dequeue()
        {
            if (!IsEmpty())
            {
                return Delete(0);
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty() { return Length == 0; }
    }
}
