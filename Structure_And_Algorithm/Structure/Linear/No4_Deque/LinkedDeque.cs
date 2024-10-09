using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    /// <summary>
    /// 링크드 리스트 기반 덱
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedDeque<T> : DoublyLinkedList<T>, AbstractDeque<T>
    {
        #region Constructors
        public LinkedDeque() { }
        public LinkedDeque(T? data, IOType type)
        {
            Push(data, type);
        }
        #endregion

        #region Overrides

        #region Push
        public void Push(T? newData, IOType type)
        {
            if (type == IOType.Front)
            {
                PushFront(newData);
            }
            else
            {
                PushBack(newData);
            }
        }

        private void PushFront(T? newData)
        {
            Insert(newData, 0);
        }

        private void PushBack(T? newData)
        {
            Append(newData);
        }
        #endregion

        #region Pop
        public CustomLinkedListNode<T>? Pop(IOType type)
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

        private CustomLinkedListNode<T>? PopFront()
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

        private CustomLinkedListNode<T>? PopBack()
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
        #endregion

        public CustomLinkedListNode<T>? Front()
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

        public CustomLinkedListNode<T>? Back()
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
            return Length == 0;
        }
        #endregion
    }
}
