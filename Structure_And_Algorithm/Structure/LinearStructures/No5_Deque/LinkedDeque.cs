using Structure_And_Algorithm.Structure.Linear.LinkedList;
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
    /// 링크드 리스트 기반 덱
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedDeque<T> : AbstractDeque<T>
    {
        #region Constructors
        public LinkedDeque()
        {
            stack = new LinkedStack<T>();
            queue = new LinkedQueue<T>();
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
