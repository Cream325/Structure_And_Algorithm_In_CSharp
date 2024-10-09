using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 링크드 리스트 기반 큐
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedQueue<T> : DoublyLinkedList<T>, AbstractQueue<T>
    {
        #region Constructors
        public LinkedQueue() { }

        public LinkedQueue(T? data)
        {
            Enqueue(data);
        }
        #endregion

        #region Overrides
        public void Enqueue(T? newData)
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

        public bool IsEmpty()
        {
            return Length == 0;
        }
        #endregion
    }
}
