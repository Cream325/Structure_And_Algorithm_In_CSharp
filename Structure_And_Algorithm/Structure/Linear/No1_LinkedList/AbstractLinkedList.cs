using System;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    public abstract class AbstractLinkedList<T>
    {
        #region Member Fields
        private CustomLinkedListNode<T>? headNode = null;
        private CustomLinkedListNode<T>? tailNode = null;
        private int length = 0;
        #endregion

        #region Properties
        public CustomLinkedListNode<T>? HeadNode { get => headNode; set => headNode = value; }
        public CustomLinkedListNode<T>? TailNode { get => tailNode; set => tailNode = value; }
        public int Length { get => length; set => length = value; }
        #endregion

        #region Constructors
        public AbstractLinkedList() { }

        public AbstractLinkedList(T? data)
        {
            Append(data);
        }
        #endregion

        #region Abstract Methods

        #region Append
        /// <summary>
        /// 링크드 리스트 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public abstract void Append(T newData);

        /// <summary>
        /// 링크드 리스트 - 전체 추가
        /// </summary>
        /// <param name="newDatas"></param>
        public abstract void AppendAll(T[] newDatas);
        #endregion

        #region Insert
        /// <summary>
        /// 링크드 리스트 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public abstract void Insert(T newData, int index);
        #endregion

        #region Search
        /// <summary>
        /// 링크드 리스트 - 단일 검색
        /// </summary>
        /// <param name="index"></param>
        public abstract CustomLinkedListNode<T>? Search(int index);
        #endregion

        #region Delete
        /// <summary>
        /// 링크드 리스트 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public abstract CustomLinkedListNode<T>? Delete(int index);
        #endregion

        #region Print
        /// <summary>
        /// 링크드 리스트 - 순회
        /// </summary>
        public abstract void Traversal();
        #endregion

        #endregion
    }
}
