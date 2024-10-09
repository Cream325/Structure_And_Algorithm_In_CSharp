using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    public class Shelf<T> : AbstractDeque<T>
    {
        #region Member Fields
        private CustomLinkedListNode<T>[] array;
        private int front = 0;
        private int back = 0;
        private int capacity;
        #endregion

        public int Capacity { get => capacity; }

        public Shelf(int capacity)
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity + 1];
        }

        #region Push
        private void PushFront(T newData)
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

        private void PushBack(T newData)
        {
            if (!IsFull())
            {
                int position = 0;
                CustomLinkedListNode<T> newNode = new(newData);

                if (back == 0)
                {
                    position = back;
                    back = capacity;
                }
                else
                {
                    position = back--;
                }

                array[position] = newNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        #endregion

        public void Push(T newData, IOType type)
        {
            if (type == IOType.Front)
            {
                PushFront(newData);
            }
            else
            {
                PushBack(newData);
            }
        }

        public CustomLinkedListNode<T>? Pop(IOType type = IOType.Back)
        {
            if (!IsEmpty())
            {
                if (back == capacity) { back = 0; }

                int position = back++;

                return array[position];
            }
            else
            {
                return null;
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
