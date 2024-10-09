using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    /// <summary>
    /// 덱 인터페이스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface AbstractDeque<T>
    {
        #region Abstract Functions
        /// <summary>
        /// 덱 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="type"></param>
        public abstract void Push(T? newData, IOType type);

        /// <summary>
        /// 덱 - 단일 삭제
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract CustomLinkedListNode<T>? Pop(IOType type);

        /// <summary>
        /// 덱 - 빈 공간 여부 확인
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty();
        #endregion
    }
}
