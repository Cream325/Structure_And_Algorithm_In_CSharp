using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    public class ArrayStack<T> : AbstractStack<T>
    {
        #region Member Fields
        private CustomLinkedListNode<T>[] array;
        private int top = -1;
        private int capacity = 0;
        #endregion

        #region Properties
        public int Top { get => top; }
        public int Capacity { get => capacity; }
        #endregion

        public ArrayStack(int capacity)
        {
            this.capacity = capacity;
            array = new CustomLinkedListNode<T>[capacity];
        }

        public void Push(T newData)
        {
            if (!IsFull())
            {
                CustomLinkedListNode<T> newNode = new(newData);
                array[++top] = newNode;
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

        public bool IsEmpty() { return top == -1; }
        public bool IsFull() { return top > Capacity; }
    }
}
