using System;
using Structure_And_Algorithm.Structure.LinearStructures.No1_Array;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 링크드 리스트 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractLinkedList<T, Node> 
    : AbstractArray<T>
    where Node : AbstractNode<T>, new()
    {
        #region Member Fields
        protected Node? headNode;
        protected Node? tailNode;
        protected int length;
        #endregion

        #region Properties
        /// <summary>
        /// 헤드 노드
        /// </summary>
        public Node? HeadNode { get => headNode; }
        /// <summary>
        /// 테일 노드
        /// </summary>
        public Node? TailNode { get => tailNode; }
        /// <summary>
        /// 링크드 리스트 길이
        /// </summary>
        public int Length { get => Size(); }
        #endregion

        #region Constructors
        public AbstractLinkedList()
        {
            headNode = null;
            tailNode = null;
            length = 0;
        }

        public AbstractLinkedList(T? data) : this()
        {
            Append(data);
        }
        #endregion

        #region Abstract Functions

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
        public void AppendAll(T[] newDatas) {
            for(int i = 0; i < newDatas.Length; i++)
            Append(newDatas[i]);

        }
        #endregion

        #region Insert
        #endregion

        #region Search
        /// <summary>
        /// 링크드 리스트 - 단일 검색
        /// </summary>
        /// <param name="index"></param>
        public abstract T? Search(int index);
        #endregion

        #region Delete
        /// <summary>
        /// 링크드 리스트 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public abstract T? Delete(int index);

        /// <summary>
        /// 링크드 리스트 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public abstract bool Insert(T newData, int index);

        public int Size() {
            return length;
        }
        public void ReSize(int newlen) {
            int l = this.length;
            for(int i = newlen; i < l; i++) Delete(Size() - 1);
            for(int i = l; i < newlen; i++) Append(default);
        }
        #endregion

        #endregion
    }
}
