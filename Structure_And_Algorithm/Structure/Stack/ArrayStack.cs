using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Stack
{
    public class ArrayStack : AbstractStack
    {
        #region Member Fields
        private Node[] array;
        private int top = -1;
        private int capacity;
        #endregion

        #region Properties
        public int Top { get => top; }
        public int Capacity { get => capacity; }
        #endregion

        public ArrayStack(int capacity)
        {
            this.capacity = capacity;
            array = new Node[capacity];
        }

        public void Push(object newData)
        {
            if (!IsFull())
            {
                Node newNode = new(newData);
                array[++top] = newNode;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public Node? Peek()
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

        public Node? Pop()
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

        public bool IsEmpty() { return (top == -1); }
        public bool IsFull() { return (top > Capacity); }
    }
}
