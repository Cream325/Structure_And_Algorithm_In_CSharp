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
    /// 스크롤(입력제한 덱)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Scroll<T> : AbstractDeque<T>
    {
        #region Member Fields
        private int front = 0;
        private int back = 0;
        private int capacity;
        private T[] array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public Scroll(int capacity)
        {
            this.capacity = capacity;
            array = new T[capacity + 1];
        }
        #endregion

        #region Overrides
        public override void Push(T? newData, IOType type = IOType.Front)
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

                array[position] = newData;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        #region Pop
        public override T? Pop(IOType type)
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

        private T? PopFront()
        {
            if (!IsEmpty())
            {
                if (front == 0)
                {
                    front = capacity;
                }

                return array[--front];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private T? PopBack()
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
                throw new IndexOutOfRangeException();
            }
        }
        #endregion

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
