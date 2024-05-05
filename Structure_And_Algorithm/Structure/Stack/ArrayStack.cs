using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Stack
{
    public class ArrayStack : AbstractStack
    {
        #region Member Fields
        private StackNode[] array;
        private int top = -1;
        private int capacity;
        #endregion

        #region Properties
        protected StackNode[] Array { get => array; set => array = value; }
        protected int Top { get => top; set => top = value; }
        public int Capacity { get => capacity; }
        #endregion

        public ArrayStack(int capacity)
        {
            this.capacity = capacity;
            array = new StackNode[capacity];
        }

        public void Push(object newData)
        {
            if (!IsFull())
            {
                StackNode newNode = new(newData);
                Array[++Top] = newNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public object? Peek()
        {
            if (!IsEmpty())
            {
                return Array[Top];
            }
            else
            {
                return null;
            }
        }

        public object? Pop()
        {
            if (!IsEmpty())
            {
                return Array[Top--];
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty() { return (Top == -1); }
        public bool IsFull() { return (Top > Capacity); }
    }
}
