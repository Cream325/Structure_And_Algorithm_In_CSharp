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

        #region Properties
        public int Length { get => linkedList.Length; }
        #endregion

        #region Constructors
        public LinkedStack() : base()
        {
            linkedList = new();
        }
        public LinkedStack(T data) : base()
        {
            linkedList = new(data);
        }
        #endregion

        #region Overrides
        public override void Push(T newData)
        {
            linkedList.Append(newData);
            top++;
        }

        public override CustomLinkedListNode<T>? Peek()
        {
            CustomLinkedListNode<T>? peekedNode = linkedList.Search(linkedList.Length - 1);
            return peekedNode != null ? peekedNode : null;
        }

        public override CustomLinkedListNode<T>? Pop()
        {
            CustomLinkedListNode<T>? poppedNode = linkedList.Delete(linkedList.Length - 1);
            if (poppedNode != null)
            {
                top--;
                return poppedNode;
            }

            return null;
        }
        #endregion
    }
}
