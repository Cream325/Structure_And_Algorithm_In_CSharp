using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 큐 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractQueue<T>
    {
        #region Member Fields
        protected int front;
        protected int rear;
        #endregion

        #region Properties
        public int Front { get => front; }
        public int Rear { get => rear; }
        #endregion

        #region Constructors
        public AbstractQueue()
        {
            front = 0;
            rear = 0;
        }

        public AbstractQueue(T data) : this()
        {
            Enqueue(data);
        }
        #endregion

        #region Abstract Functions
        /// <summary>
        /// 큐 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        public abstract void Enqueue(T newData);

        /// <summary>
        /// 큐 - 단일 삭제
        /// </summary>
        /// <returns></returns>
        public abstract CustomLinkedListNode<T>? Dequeue();
        #endregion
    }
}
