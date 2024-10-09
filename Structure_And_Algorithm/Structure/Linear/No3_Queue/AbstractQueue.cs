using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 큐 인터페이스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface AbstractQueue<T>
    {
        #region Abstract Functions
        /// <summary>
        /// 큐 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        public abstract void Enqueue(T? newData);

        /// <summary>
        /// 큐 - 단일 삭제
        /// </summary>
        /// <returns></returns>
        public abstract CustomLinkedListNode<T>? Dequeue();

        /// <summary>
        /// 큐 - 빈 공간 여부 확인
        /// </summary>
        /// <returns></returns>
        public abstract bool IsEmpty();
        #endregion
    }
}
