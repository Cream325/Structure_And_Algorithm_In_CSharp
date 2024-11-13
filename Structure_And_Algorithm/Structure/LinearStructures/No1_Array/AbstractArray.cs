using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Utils;
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
    public abstract class AbstractArray<T> : ILinearable<T>
    {
        #region Member Fields
        protected int capacity;
        protected int lastIndex;
        protected T[] array;
        #endregion

        #region Properties
        public int Capacity { get => capacity; }
        #endregion

        #region Constructors
        public AbstractArray(int capacity)
        {
            this.capacity = capacity;
            this.lastIndex = 0;
            this.array = new T[capacity];
        }

        public AbstractArray(int capacity, T newData) : this(capacity)
        {
            Append(newData);
        }
        #endregion

        #region Overrides
        public bool CheckIndex(int index)
        {
            if (index < 0)
                throw new RuntimeException(ErrorCode.UnderflowedIndex, "인덱스가 0미만이 될 수 없습니다.");
            else if (index >= capacity)
                throw new RuntimeException(ErrorCode.OverflowedIndex, "인덱스가 최대 길이 이상이 될 수 없습니다.");

            return true;
        }
        #endregion

        #region Abstract Functions

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
        public abstract T Search(int index);
        #endregion

        #region Delete
        /// <summary>
        /// 배열 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public abstract T Delete(int index);
        #endregion

        #endregion

        #region Public Functions

        #region Append
        /// <summary>
        /// 배열 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public void Append(T newData)
        {
            Insert(newData, lastIndex);
        }

        /// <summary>
        /// 배열 - 전체 추가
        /// </summary>
        /// <param name="newDatas"></param>
        public void AppendAll(T[] newDatas)
        {
            for(int i = 0; i < newDatas.Length; i++)
            {
                Append(newDatas[i]);
            }
        }
        #endregion

        #region Print
        /// <summary>
        /// 배열 - 순회
        /// </summary>
        public void Traversal()
        {
            if(capacity == 0) return;

            int currentIndex = 0;

            while (array[currentIndex] != null)
            {
                Console.Write($"{array[currentIndex++]} ");
            }
        }
        #endregion

        #endregion
    }
}
