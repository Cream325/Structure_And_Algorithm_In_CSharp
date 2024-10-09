using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    public class Scroll<T> : AbstractDeque<T>
    {
        #region Member Fields
        private CustomLinkedListNode<T>[] array;
        private int front = 0;
        private int back = 0;
        private int capacity;
        #endregion

        public int Capacity { get => capacity; }

        public Scroll(int capacity)
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity + 1];
        }

        #region Pop
        private CustomLinkedListNode<T>? PopFront()
        {
            if (!IsEmpty())
            {
                if (front == 0) { front = capacity; }

                int position = --front;

                return array[position];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private CustomLinkedListNode<T>? PopBack()
        {
            if (!IsEmpty())
            {
                if (back == capacity) { back = 0; }

                int position = back++;

                return array[position];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        #endregion

        public void Push(T newData, IOType type = IOType.Front)
        {
            if (!IsFull())
            {
                int position = 0;
                CustomLinkedListNode<T> newNode = new(newData);

                if (front == capacity)
                {
                    position = front;
                    front = 0;
                }
                else
                {
                    position = front++;
                }

                array[position] = newNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public CustomLinkedListNode<T>? Pop(IOType type)
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

        public bool IsEmpty()
        {
            return front == back;
        }

        public bool IsFull()
        {
            int index = back - 1;

            if (index == -1)
            {
                index = capacity;
            }

            return front % capacity == back && index == front;
        }
    }
}
