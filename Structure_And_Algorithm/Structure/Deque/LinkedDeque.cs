using Structure_And_Algorithm.Structure.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Deque
{
    public class LinkedDeque : DoublyLinkedList, AbstractDeque
    {
        public void Push(object newData, IOType type)
        {
            if(type == IOType.Front)
            {
                PushFront(newData);
            }
            else
            {
                PushBack(newData);
            }
        }

        private void PushFront(object newData)
        {
            Insert(newData, 0);
        }

        private void PushBack(object newData)
        {
            Append(newData);
        }

        public Node? Pop(IOType type)
        {
            if (type == IOType.Front)
            {
                return PopFront();
            }
            else
            {
                return PopBack();
            }
        }

        private Node? PopFront()
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

        private Node? PopBack()
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

        public Node? Front()
        {
            if (!IsEmpty())
            {
                return Search(0);
            }
            else
            {
                return null;
            }
        }

        public Node? Back()
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

        public bool IsEmpty()
        {
            return (Length == 0);
        }
    }
}
