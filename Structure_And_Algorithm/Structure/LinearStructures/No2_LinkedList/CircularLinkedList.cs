using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 순환 링크드 리스트
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public CircularLinkedList() : base() { }
        public CircularLinkedList(T? data) : base(data) { }
        #endregion

        #region Overrides

        #region Append
        public override void Append(T newData)
        {
            CustomLinkedListNode<T> newNode = new(newData);

            // 헤드가 null인 경우
            if(headNode == null)
            {
                headNode = newNode;
                tailNode = headNode;

                headNode.NextNode = tailNode;
                tailNode.PreviousNode = headNode;
            }
            else
            {
                //일반적인 경우
                tailNode.NextNode = newNode;
                newNode.PreviousNode = tailNode;
                tailNode = tailNode.NextNode;
            }

            headNode.PreviousNode = tailNode;
            tailNode.NextNode = headNode;
            length++;
        }

        public override void AppendAll(T[] newDatas)
        {
            for (int i = 0; i < newDatas.Length; i++)
            {
                Append(newDatas[i]);
            }
        }
        #endregion

        #region Insert
        public override void Insert(T newData, int index)
        {
            CustomLinkedListNode<T> newNode = new(newData);

            // 헤드가 null인 경우, 인덱스가 리스트 최대 인덱스 이상인 경우 (Append와 연산이 같음)
            if(headNode == null || index >= length-1)
            {
                Append(newData);
                return;
            }

            // 인덱스가 0 이하인 경우
            if (index <= 0)
            {
                newNode.NextNode = headNode;
                headNode.PreviousNode = newNode;
                headNode = newNode;

                headNode.PreviousNode = tailNode;
                tailNode.NextNode = headNode;
                length++;
                return;
            }

            // 일반적인 경우
            CustomLinkedListNode<T>? currentNode = Search(index);
            currentNode.PreviousNode.NextNode = newNode;
            newNode.NextNode = currentNode;
            currentNode.PreviousNode = newNode;
            length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T>? Search(int index)
        {
            CustomLinkedListNode<T>? currentNode;

            if(index <= length/2)
            {
                // 헤드에서 검색
                currentNode = headNode;
                while(currentNode.NextNode != headNode && --index >= 0)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            else
            {
                // 테일에서 검색
                int maxIndex = length - 1;
                currentNode = tailNode;
                while(currentNode.PreviousNode != tailNode && --maxIndex >= index)
                {
                    currentNode = currentNode.PreviousNode;
                }
            }

            return currentNode;
        }
        #endregion
        
        // 수정필요
        #region Delete
        public override CustomLinkedListNode<T>? Delete(int index)
        {
            CustomLinkedListNode<T>? deletedNode = null;

            if(headNode != null)
            {
                // 헤드를 삭제할 경우
                if(headNode.NextNode == tailNode || index <= 0)
                {
                    deletedNode = headNode;
                    tailNode.PreviousNode = headNode.NextNode;
                    headNode = headNode.NextNode;
                }
                else
                {
                    index = index >= length ? length-1 : index;
                    CustomLinkedListNode<T>? currentNode = Search(index);

                    // 중간노드를 삭제할 경우
                    if(currentNode.NextNode != null)
                    {
                        currentNode.PreviousNode.NextNode = currentNode.NextNode;
                        currentNode.NextNode.PreviousNode = currentNode.PreviousNode;
                    }
                    else
                        // 테일을 삭제할 경우
                        currentNode.PreviousNode.NextNode = headNode;

                    deletedNode = currentNode;
                }

                length--;
            }

            return deletedNode;
        }
        #endregion

        #region Print
        public override void Traversal()
        {
            CustomLinkedListNode<T>? currentNode = headNode;

            if (currentNode != null)
            {
                do
                {
                    Console.Write(currentNode.Data + " ");
                    currentNode = currentNode.NextNode;
                } while(currentNode != headNode);
            }
        }
        #endregion

        #endregion
    }
}
