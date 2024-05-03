using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinkedList
{
    public abstract class AbstractLinkedList
    {
        public AbstractLinkedList() { }

        #region Member Fields
        private LinkedListNode headNode;
        private LinkedListNode tailNode;
        private int length = 0;
        #endregion

        #region Properties
        public LinkedListNode HeadNode { get => headNode; set => headNode = value; }
        public LinkedListNode TailNode { get => tailNode; set => tailNode = value; }
        public int Length { get => length; set => length = value; }
        #endregion

        #region Abstract Methods

        #region Append
        /// <summary>
        /// 링크드 리스트 - 단일 추가
        /// </summary>
        /// <param name="newData"></param>
        public abstract void Append(object newData);
        #endregion

        #region Insert
        /// <summary>
        /// 링크드 리스트 - 단일 삽입
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="index"></param>
        public abstract void Insert(object newData, int index);
        #endregion

        #region Search
        /// <summary>
        /// 링크드 리스트 - 단일 검색
        /// </summary>
        /// <param name="index"></param>
        public abstract LinkedListNode? Search(int index);
        #endregion

        #region Delete
        /// <summary>
        /// 링크드 리스트 - 단일 삭제
        /// </summary>
        /// <param name="index"></param>
        public abstract LinkedListNode? Delete(int index);
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
