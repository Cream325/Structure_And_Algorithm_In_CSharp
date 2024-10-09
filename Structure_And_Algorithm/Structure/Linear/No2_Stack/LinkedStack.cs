using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    /// <summary>
    /// 링크드 리스트 기반 스택
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedStack<T> : DoublyLinkedList<T>, AbstractStack<T>
    {
        #region Constructors
        public LinkedStack() { }
        public LinkedStack(T? data)
        {
            Push(data);
        }
        #endregion

        #region Overrides
        public void Push(T? newData)
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
        #endregion
    }
}
