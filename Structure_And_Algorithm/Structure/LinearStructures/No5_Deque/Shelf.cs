using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    /// <summary>
    /// 셸프(출력제한 덱)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Shelf<T> : AbstractDeque<T>
    {
        #region Member Fields
        private int front = 0;
        private int back = 0;
        private int capacity;
        private CustomLinkedListNode<T>[] array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public Shelf(int capacity)
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity + 1];
        }
        #endregion

        #region Overrides

        #region Push
        public override void Push(T? newData, IOType type)
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

        private void PushFront(T? newData)
        {
            if (!IsFull())
            {
                int position = 0;

                if (front == capacity)
                {
                    position = front;
                    front = 0;
                }
                else
                {
                    position = front++;
                }

                array[position] = new CustomLinkedListNode<T>(newData);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void PushBack(T? newData)
        {
            if (!IsFull())
            {
                int position = 0;

                if (back == 0)
                {
                    position = back;
                    back = capacity;
                }
                else
                {
                    position = back--;
                }

                array[position] = new CustomLinkedListNode<T>(newData);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        #endregion

        public override CustomLinkedListNode<T>? Pop(IOType type = IOType.Back)
        {
            if (!IsEmpty())
            {
                if (back == capacity)
                {
                    back = 0;
                }

                return array[back++];
            }
            else
            {
                return null;
            }
        }

        public override bool IsEmpty()
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
        #endregion
    }
}
