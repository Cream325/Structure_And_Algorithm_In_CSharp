using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    /// <summary>
    /// 배열 기반 스택
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayStack<T> : AbstractStack<T>
    {
        #region Member Fields
        private int top = -1;
        private int capacity = 0;
        private CustomLinkedListNode<T>[] array;
        #endregion

        #region Properties
        public int Top { get => top; }
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public ArrayStack(int capacity)
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity];
        }
        #endregion

        #region Overrides
        public void Push(T? newData)
        {
            if (!IsFull())
            {
                array[++top] = new CustomLinkedListNode<T>(newData);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public CustomLinkedListNode<T>? Peek()
        {
            if (!IsEmpty())
            {
                return array[top];
            }
            else
            {
                return null;
            }
        }

        public CustomLinkedListNode<T>? Pop()
        {
            if (!IsEmpty())
            {
                return array[top--];
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top > Capacity;
        }
        #endregion
    }
}
