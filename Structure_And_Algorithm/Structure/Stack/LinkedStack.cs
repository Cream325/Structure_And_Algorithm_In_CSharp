using Structure_And_Algorithm.Structure.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Stack
{
    public class LinkedStack : DoublyLinkedList, AbstractStack
    {
        public LinkedStack() { }

        public void Push(object newData)
        {
            base.Append(newData);
        }

        public object? Peek()
        {
            if(!IsEmpty())
            {
                return base.Search(Length - 1).Data;
            }
            else
            {
                return null;
            }
        }

        public object? Pop()
        {
            if (!IsEmpty())
            {
                return base.Delete(Length - 1).Data;
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty() { return (Length == 0); }
    }
}
