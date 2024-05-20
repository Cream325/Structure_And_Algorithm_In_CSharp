using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Queue
{
    public class CircularQueue : AbstractQueue
    {
        #region Member Fields
        private Node[] array;
        private int front = 0;
        private int rear = 0;
        private int capacity;
        #endregion

        #region Properties
        public int Front { get => front; }
        public int Rear { get => rear; }
        public int Capacity { get => capacity; }
        #endregion

        public CircularQueue(int capacity)
        {
            this.capacity = capacity;
            array = new Node[capacity + 1];
        }

        public void Enqueue(object newData)
        {
            if(!IsFull())
            {
                int position = 0;
                Node newNode = new(newData);

                if (rear == capacity)
                {
                    rear = 0;
                }

                position = rear;
                rear++;

                array[position] = newNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public Node? Dequeue()
        {
            int position = front;

            if(front == capacity)
            {
                front = 0;
            }
            else
            {
                front++;
            }

            return array[position];
        }

        public bool IsEmpty() { return front == rear; }

        public bool IsFull()
        {
            if(front < rear)
            {
                return (rear - front) == capacity;
            }
            else
            {
                return (rear + 1) == front;
            }
        }
    }
}
