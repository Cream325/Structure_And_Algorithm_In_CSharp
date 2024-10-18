using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinearStructures.No1_Array
{
    /// <summary>
    /// 배열 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractArray<T>
    {
        #region Member Fields
        protected int capacity;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public AbstractArray(int capacity)
        {
            this.capacity = capacity;
        }
        #endregion

        #region Abstract Functions

        #region Append
        /// <summary>
        /// 배열 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public abstract void Append(T newData);

        /// <summary>
        /// 배열 - 전체 추가
        /// </summary>
        /// <param name="newDatas"></param>
        public abstract void AppendAll(T[] newDatas);
        #endregion

        #region Insert
        /// <summary>
        /// 배열 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public abstract void Insert(T newData, int index);
        #endregion

        #region Search
        /// <summary>
        /// 배열 - 단일 검색
        /// </summary>
        /// <param name="index"></param>
        public abstract T? Search(int index);
        #endregion

        #region Delete
        /// <summary>
        /// 배열 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public abstract T? Delete(int index);
        #endregion

        #region Print
        /// <summary>
        /// 배열 - 순회
        /// </summary>
        public abstract void Traversal();
        #endregion

        #endregion
    }
}
