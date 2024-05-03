using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Stack
{
    public class ArrayStack : StackNode, AbstractStack
    {
        public ArrayStack(int capacity) : base(capacity) { }

        public void Push(object newData)
        {
            if (!IsFull())
            {
                Array[++Top] = newData;
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
