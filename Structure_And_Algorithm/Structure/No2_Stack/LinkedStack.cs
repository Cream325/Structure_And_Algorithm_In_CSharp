using Structure_And_Algorithm.Structure.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Stack
{
    public class LinkedStack : DoublyLinkedList, AbstractStack
    {
        public void Push(object newData)
        {
            Append(newData);
        }

        public Node? Peek()
        {
            if(!IsEmpty())
            {
                return Search(Length - 1);
            }
            else
            {
                return null;
            }
        }

        public Node? Pop()
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

        public bool IsEmpty() { return (Length == 0); }
    }
}
