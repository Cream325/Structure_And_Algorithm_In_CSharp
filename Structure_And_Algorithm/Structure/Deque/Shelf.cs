using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Deque
{
    public class Shelf : AbstractDeque
    {
        #region Member Fields
        private Node[] array;
        private int front = 0;
        private int back = 0;
        private int capacity;
        #endregion

        public int Capacity { get => capacity; }

        public Shelf(int capacity)
        {
            this.capacity = capacity;
            array = new Node[capacity + 1];
        }

        #region Push
        private void PushFront(object newData)
        {
            if (!IsFull())
            {
                int position = 0;
                Node newNode = new(newData);

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

        private void PushBack(object newData)
        {
            if (!IsFull())
            {
                int position = 0;
                Node newNode = new(newData);

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

        public void Push(object newData, IOType type)
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

        public Node? Pop(IOType type = IOType.Back)
        {
            if (!IsEmpty())
            {
                if(back == capacity) { back = 0; }

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

            if(index == -1)
            {
                index = capacity;
            }

            return ((front % capacity) == back) && (index == front);
        }
    }
}
