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
        private int capacity = 0;
        private CustomLinkedListNode<T>[] array;
        #endregion

        #region Properties
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
        public override void Push(T? newData)
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

        public override CustomLinkedListNode<T>? Peek()
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

        public override CustomLinkedListNode<T>? Pop()
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

        public override bool IsEmpty()
        {
            return top == -1;
        }
        #endregion

        #region Public Functions
        public bool IsFull()
        {
            return top > Capacity;
        }
        #endregion
    }
}
