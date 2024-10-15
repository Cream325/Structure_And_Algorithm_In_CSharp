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
        private CustomLinkedListNode<T>[] array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public CircularQueue(int capacity) : base()
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity + 1];
        }
        #endregion

        #region Overrides
        public override void Enqueue(T newData)
        {
            if (!IsFull())
            {
                rear = (++rear) % capacity;
                array[rear] = new(newData);
            }
        }

        public override CustomLinkedListNode<T>? Dequeue()
        {
            if(!IsEmpty())
            {
                front = (++front) % capacity;
                return array[front];
            }

            return null;
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
