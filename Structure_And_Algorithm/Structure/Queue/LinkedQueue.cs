using Structure_And_Algorithm.Structure.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Queue
{
    public class LinkedQueue : DoublyLinkedList, AbstractQueue
    {
        public void Enqueue(object newData)
        {
            Append(newData);
        }

        public Node? Dequeue()
        {
            if(!IsEmpty())
            {
                Node dequeuedNode = Delete(0);
                return dequeuedNode;
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty() { return Length == 0; }
    }
}
