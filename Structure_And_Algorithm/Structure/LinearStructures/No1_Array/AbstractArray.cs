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
    public interface AbstractArray<T>
    {
        #region Insert
        /// <summary>
        /// 배열 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public abstract bool Insert(T newData, int index);
        #endregion

        #region Search
        /// <summary>
        /// 배열 - 단일 검색
        /// </summary>
        /// <param name="index"></param>
        public abstract T? Search(int index);
        #endregion

        #region Print

        public abstract int Size();
        
        #endregion

        #region Public Resize
        /// <summary>
        /// 배열 크기 재조정 함수
        /// </summary>
        /// <param name="type"></param>
        public abstract void ReSize(int newlen);
        #endregion

        public void Traversal()
        {
            int currentIndex = 0;

            while(currentIndex < Size() && Search(currentIndex) != null)
            {
                Console.Write($"{Search(currentIndex++)} ");
            }
        }
    }
}
