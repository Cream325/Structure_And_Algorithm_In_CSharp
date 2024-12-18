﻿using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 순환 큐
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularQueue<T> : AbstractQueue<T>
    {
        #region Member Fields
        private int capacity;
        private FixedArray<T> array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public CircularQueue(int capacity) : base()
        {
            this.capacity = capacity;
            array = new(capacity + 1);
        }

        public CircularQueue(int capacity, T newData) : this(capacity)
        {
            Enqueue(newData);
        }
        #endregion

        #region Overrides
        public override void Enqueue(T newData)
        {
            if (!IsFull())
            {
                rear = (++rear) % capacity;
                array.Insert(newData, rear);
            }
        }

        public override T? Peek()
        {
            if(!IsEmpty())
            {
                return array.Search(front);
            }

            return default;
        }

        public override T? Dequeue()
        {
            if(!IsEmpty())
            {
                front = (++front) % capacity;
                return array.Delete(front);
            }

            return default;
        }
        #endregion

        #region Private Functions
        private bool IsEmpty()
        {
            return front == rear;
        }

        private bool IsFull()
        {
            return front == (rear + 1) % capacity;
        }
        #endregion
    }
}
