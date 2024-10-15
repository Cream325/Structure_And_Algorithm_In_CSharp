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
        private int capacity;
        private CustomLinkedListNode<T>?[] array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public ArrayStack(int capacity) : base()
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>?[capacity];
        }

        public ArrayStack(int capacity, T data) : this(capacity)
        {
            Push(data);
        }
        #endregion

        #region Overrides
        public override void Push(T newData)
        {
            if (!IsFull())
                array[top++] = new(newData);
        }

        public override CustomLinkedListNode<T>? Peek()
        {
            return !IsEmpty() ? array[top-1] : default;
        }

        public override CustomLinkedListNode<T>? Pop()
        {
            return !IsEmpty() ? array[--top] : default;
        }
        #endregion

        #region Private Functions
        private bool IsEmpty()
        {
            return top <= 0;
        }

        private bool IsFull()
        {
            return top >= Capacity;
        }
        #endregion
    }
}
