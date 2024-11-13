using System;
using System.Diagnostics;
using Structure_And_Algorithm.Structure.LinearStructures;
using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Utils;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 연결 리스트 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractLinkedList<T> : ILinearable<T>, INodeAvailable<T>
    {
        #region Member Fields
        protected CustomLinkedListNode<T>? headNode;
        protected CustomLinkedListNode<T>? tailNode;
        protected int length;
        #endregion

        #region Properties
        /// <summary>
        /// 헤드 노드
        /// </summary>
        public CustomLinkedListNode<T>? HeadNode { get => headNode; }
        /// <summary>
        /// 테일 노드
        /// </summary>
        public CustomLinkedListNode<T>? TailNode { get => tailNode; }
        /// <summary>
        /// 연결 리스트 길이
        /// </summary>
        public int Length { get => length; }
        #endregion

        #region Constructors
        public AbstractLinkedList()
        {
            headNode = null;
            tailNode = null;
            length = 0;
        }

        public AbstractLinkedList(T newData) : this()
        {
            Append(newData);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// 연결 리스트 - 단일 검색
        /// </summary>
        /// <param name="index"></param>
        public T Search(int index)
        {
            AbstractNode<T> searchedNode = SearchNode(index);
            if (searchedNode != null)
                return searchedNode.Data;

            return default;
        }

        public  bool CheckIndex(int index)
        {
            if (index < 0)
                throw new RuntimeException(ErrorCode.UnderflowedIndex, "인덱스가 0미만이 될 수 없습니다.");
            else if (index > 1 && index >= length)
                throw new RuntimeException(ErrorCode.OverflowedIndex, "인덱스가 최대 길이 이상이 될 수 없습니다.");

            return true;
        }

        public bool CheckIsHeaderNull(AbstractNode<T>? header)
        {
            if (header == null)
                throw new RuntimeException(ErrorCode.NullOfHeader, "Head가 null이 될 수 없습니다.");

            return true;
        }
        #endregion

        #region Abstract Functions

        #region Insert
        /// <summary>
        /// 연결 리스트 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public abstract void Insert(T newData, int index);
        #endregion

        #region Search
        /// <summary>
        /// 연결 리스트 - 단일 노드 검색
        /// </summary>
        /// <param name="index"></param>
        public abstract AbstractNode<T> SearchNode(int index);
        #endregion

        #region Delete
        /// <summary>
        /// 연결 리스트 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public abstract T Delete(int index);
        #endregion

        #endregion

        #region Public Functions

        #region Append
        /// <summary>
        /// 연결 리스트 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public void Append(T newData)
        {
            Insert(newData, length - 1);
        }

        /// <summary>
        /// 연결 리스트 - 전체 추가
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
        /// 연결 리스트 - 순회
        /// </summary>
        public void Traversal()
        {
            CheckIsHeaderNull(headNode);

            CustomLinkedListNode<T> currentNode = headNode;

            do
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.NextNode;
            } while (currentNode != headNode && currentNode != null);
        }
        #endregion

        #endregion
    }
}
