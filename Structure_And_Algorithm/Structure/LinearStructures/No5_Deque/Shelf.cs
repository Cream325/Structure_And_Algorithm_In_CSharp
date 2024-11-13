using Structure_And_Algorithm.Structure.Linear.Queue;
using Structure_And_Algorithm.Structure.Linear.Stack;
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
        #region Constructors
        public Shelf(int capacity)
        {
            stack = new ArrayStack<T>(capacity);
            queue = new CircularQueue<T>(capacity);
        }
        #endregion

        #region Overrides
        public override void PushFront(T newData)
        {
            queue.Enqueue(newData);
        }

        public override void PushBack(T newData)
        {
            stack.Push(newData);
        }

        public override T? PeekFront()
        {
            return queue.Peek();
        }

        public override T? PeekBack()
        {
            return stack.Peek();
        }

        public override T? PopFront()
        {
            return queue.Dequeue();
        }

        public override T? PopBack()
        {
            return stack.Pop();
        }
        #endregion
    }
}
