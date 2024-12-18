﻿using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 링크드 리스트 기반 큐
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedQueue<T> : AbstractQueue<T>
    {
        #region Member Fields
        private DoublyLinkedList<T> linkedList;
        #endregion

        #region Properties
        public int Length { get => linkedList.Length; }
        #endregion

        #region Constructors
        public LinkedQueue() : base()
        {
            linkedList = new();
        }

        public LinkedQueue(T newData) : base()
        {
            linkedList = new(newData);
        }
        #endregion

        #region Overrides
        public override void Enqueue(T newData)
        {
            linkedList.Append(newData);
        }

        public override T? Peek()
        {
            return linkedList.Search(0);
        }

        public override T? Dequeue()
        {
            return linkedList.Delete(0);
        }
        #endregion
    }
}
