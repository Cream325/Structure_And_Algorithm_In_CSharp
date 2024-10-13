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
    public class LinkedStack<T> : AbstractStack<T>
    {
        #region Member Fields
        private DoublyLinkedList<T> linkedList;
        #endregion

        #region Constructors
        public LinkedStack()
        {
            linkedList = new();
        }
        public LinkedStack(T? data)
        {
            linkedList = new();
            Push(data);
        }
        #endregion

        #region Overrides
        public override void Push(T? newData)
        {
            linkedList.Append(newData);
        }

        public override CustomLinkedListNode<T>? Peek()
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

        public override CustomLinkedListNode<T>? Pop()
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

        public override bool IsEmpty() { return linkedList.Length == 0; }
        #endregion
    }
}
