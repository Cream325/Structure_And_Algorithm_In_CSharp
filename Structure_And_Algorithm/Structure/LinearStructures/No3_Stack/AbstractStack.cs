using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Stack
{
    public abstract class IStack<T> {
        private AbstractArray<T> arr;

        #region Member Fields
        protected int top;
        #endregion

        #region Properties
        public int Top { get => top; }
        public int Capacity { get => arr.Size(); }
        #endregion

        #region Constructors
        public IStack(AbstractArray<T> a)
        {
            arr = a;
            top = 0;
        }
        #endregion

        #region Abstract Functions
        /// <summary>
        /// 스택 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public void Push(T newData) {
            if (!IsFull())
                arr.Insert(newData, top++);
        }

        /// <summary>
        /// 스택 - 단일 검색
        /// </summary>
        /// <returns></returns>
        public T? Peek() => !IsEmpty() ? arr.Search(top - 1) : default;
        
        /// <summary>
        /// 스택 - 단일 삭제
        /// </summary>
        /// <returns></returns>
        public T? Pop() => !IsEmpty() ? arr.Search(--top) : default;

        public bool IsEmpty() => top <= 0;

        public bool IsFull() => top >= Capacity;

        public void Resize(int a) => arr.ReSize(a);
        #endregion
    }

    /// <summary>
    /// 스택 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AbstractStack<T, Arr> : IStack<T>  where Arr : AbstractArray<T>, new() 
    {
        public AbstractStack() : base(new Arr()) {}
        public AbstractStack(int i) : base(new Arr()) => this.Resize(i);
    }
}