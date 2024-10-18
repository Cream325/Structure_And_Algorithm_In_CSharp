using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Utils;
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
    public class LinkedDeque<T> : AbstractDeque<T>
    {
        #region Member Fields
        DoublyLinkedList<T> linkedList;
        #endregion

        #region Constructors
        public LinkedDeque()
        {
            linkedList = new();
        }

        public LinkedDeque(T? data, IOType type)
        {
            linkedList = new();
            Push(data, type);
        }
        #endregion

        #region Overrides

        #region Push
        public override void Push(T? newData, IOType type)
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
            linkedList.Insert(newData, 0);
        }

        private void PushBack(T? newData)
        {
            linkedList.Append(newData);
        }
        #endregion

        #region Pop
        public override CustomLinkedListNode<T>? Pop(IOType type)
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
                return linkedList.Delete(0);
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
                return linkedList.Delete(linkedList.Length - 1);
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
                return linkedList.Search(0);
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
                return linkedList.Search(linkedList.Length - 1);
            }
            else
            {
                return null;
            }
        }

        public override bool IsEmpty()
        {
            return linkedList.Length == 0;
        }
        #endregion
    }
}
