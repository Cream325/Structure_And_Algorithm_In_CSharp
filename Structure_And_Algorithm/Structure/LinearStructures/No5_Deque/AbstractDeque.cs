using Structure_And_Algorithm.Structure.Linear.Queue;
using Structure_And_Algorithm.Structure.Linear.Stack;
using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Utils;

namespace Structure_And_Algorithm.Structure.Linear.Deque
{
    /// <summary>
    /// 덱 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractDeque<T>
    {
        #region Member Fields
        protected AbstractStack<T> stack;
        protected AbstractQueue<T> queue;
        #endregion

        #region Abstract Functions
        /// <summary>
        /// 덱 - 단일 추가(전단)
        /// </summary>
        /// <param name="newData"></param>
        public abstract void PushFront(T newData);

        /// <summary>
        /// 덱 - 단일 추가(후단)
        /// </summary>
        /// <param name="newData"></param>
        public abstract void PushBack(T newData);

        /// <summary>
        /// 덱 - 단일 검색(전단)
        /// </summary>
        /// <returns></returns>
        public abstract T? PeekFront();

        /// <summary>
        /// 덱 - 단일 검색(후단)
        /// </summary>
        /// <returns></returns>
        public abstract T? PeekBack();

        /// <summary>
        /// 덱 - 단일 삭제(전단)
        /// </summary>
        /// <returns></returns>
        public abstract T? PopFront();

        /// <summary>
        /// 덱 - 단일 삭제(후단)
        /// </summary>
        /// <returns></returns>
        public abstract T? PopBack();
        #endregion
    }
}
