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
        private int front = 0;
        private int rear = 0;
        private int capacity = 0;
        private CustomLinkedListNode<T>[] array;
        #endregion

        #region Properties
        public int Front { get => front; }
        public int Rear { get => rear; }
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public CircularQueue(int capacity)
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity + 1];
        }
        #endregion

        #region Overrides
        public override void Enqueue(T? newData)
        {
            if (!IsFull())
            {
                if (rear == capacity)
                {
                    rear = 0;
                }

                int position = rear;
                rear++;

                array[position] = new CustomLinkedListNode<T>(newData);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public override CustomLinkedListNode<T>? Dequeue()
        {
            int position = front;

            if (front == capacity)
            {
                front = 0;
            }
            else
            {
                front++;
            }

            return array[position];
        }

        public override bool IsEmpty()
        {
            return front == rear;
        }

        public bool IsFull()
        {
            if (front < rear)
            {
                return (rear - front) == capacity;
            }
            else
            {
                return (rear + 1) == front;
            }
        }
        #endregion
    }
}
