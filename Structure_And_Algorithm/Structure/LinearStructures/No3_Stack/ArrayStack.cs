using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
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
        private FixedArray<T> array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public ArrayStack(int capacity) : base()
        {
            this.capacity = capacity;
            array = new(capacity);
        }

        public ArrayStack(int capacity, T newData) : this(capacity)
        {
            Push(newData);
        }
        #endregion

        #region Overrides
        public override void Push(T newData)
        {
            if (!IsFull())
            {
                array.Insert(newData, top++);
            }
        }

        public override T? Peek()
        {
            return !IsEmpty() ? array.Search(top-1) : default;
        }

        public override T? Pop()
        {
            return !IsEmpty() ? array.Delete(top--) : default;
        }

        public override bool IsEmpty()
        {
            return top <= 0;
        }

        public override bool IsFull()
        {
            return top >= Capacity;
        }
        #endregion
    }
}
