﻿using System;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 링크드 리스트 추상 클래스
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractLinkedList<T>
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
        /// 링크드 리스트 길이
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
