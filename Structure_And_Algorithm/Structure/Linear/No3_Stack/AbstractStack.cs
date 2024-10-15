using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    /// <summary>
    /// 스택 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractStack<T>
    {
        #region Member Fields
        protected int top;
        #endregion

        #region Properties
        public int Top { get => top; }
        #endregion

        #region Constructors
        public AbstractStack()
        {
            top = 0;
        }
        #endregion

        #region Abstract Functions
        /// <summary>
        /// 스택 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public abstract void Push(T newData);

        /// <summary>
        /// 스택 - 단일 검색
        /// </summary>
        /// <returns></returns>
        public abstract CustomLinkedListNode<T>? Peek();
        
        /// <summary>
        /// 스택 - 단일 삭제
        /// </summary>
        /// <returns></returns>
        public abstract CustomLinkedListNode<T>? Pop();
        #endregion
    }
}
