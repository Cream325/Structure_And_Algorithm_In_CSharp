using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 순환 연결 리스트
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public CircularLinkedList() : base() { }
        public CircularLinkedList(T newData) : base(newData) { }
        #endregion

        #region Overrides

        #region Insert
        public override void Insert(T newData, int index)
        {
            CustomLinkedListNode<T> newNode = new(newData);

            if (headNode == null)
            {
                // 헤드가 null인 경우
                headNode = newNode;
                tailNode = headNode;

                headNode.NextNode = tailNode;
                tailNode.PreviousNode = headNode;

                headNode.PreviousNode = tailNode;
                tailNode.NextNode = headNode;
            }
            else if (index <= 0)
            {
                // 인덱스가 0이하인 경우
                newNode.NextNode = headNode;
                headNode.PreviousNode = newNode;
                headNode = newNode;
            }
            else if (index >= length - 1)
            {
                // 인덱스가 length-1이상인 경우
                if (headNode.Equals(tailNode))
                {
                    headNode.NextNode = newNode;
                    newNode.PreviousNode = headNode;
                }
                else
                {
                    tailNode.NextNode = newNode;
                    newNode.PreviousNode = tailNode;
                }

                tailNode = newNode;
            }
            else
            {
                // 일반적인 경우
                CustomLinkedListNode<T>? currentNode = Search(index);
                currentNode.PreviousNode.NextNode = newNode;
                newNode.PreviousNode = currentNode.PreviousNode;
                newNode.NextNode = currentNode;
                currentNode.PreviousNode = newNode;
            }

            headNode.PreviousNode = tailNode;
            tailNode.NextNode = headNode;
            length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T> Search(int index)
        {
            if (headNode == null) return null;

            CustomLinkedListNode<T> currentNode = headNode;

            if (index <= length / 2)
            {
                while (currentNode.NextNode != headNode && --index >= 0)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            else
            {
                int maxIndex = length - 1;
                currentNode = tailNode;
                while (currentNode.PreviousNode != tailNode && --maxIndex >= index)
                {
                    currentNode = currentNode.PreviousNode;
                }
            }

            return currentNode;
        }
        #endregion
        
        #region Delete
        public override CustomLinkedListNode<T> Delete(int index)
        {
            // Head가 null인 경우
            if (headNode == null) return null;

            CustomLinkedListNode<T> deletedNode;
            CustomLinkedListNode<T> tempNode;

            if(headNode.Equals(tailNode))
            {
                // Head와 Tail이 같을 경우
                tempNode = headNode;
                headNode = null;
                tailNode = null;
            }
            else if (index <= 0)
            {
                // 인덱스가 0이하일 경우
                tempNode = headNode;
                headNode.NextNode.PreviousNode = null;
                headNode = headNode.NextNode;
            }
            else
            {
                // 인덱스가 length-1이상일 경우, 일반적인 경우
                CustomLinkedListNode<T> currentNode = Search(index);
                tempNode = currentNode;
                currentNode.PreviousNode.NextNode = currentNode.NextNode;

                if (index >= length - 1)
                    tailNode = currentNode.PreviousNode;
                else
                    currentNode.NextNode.PreviousNode = currentNode.PreviousNode;
            }

            headNode.PreviousNode = tailNode;
            tailNode.NextNode = headNode;
            deletedNode = tempNode;
            length--;

            return deletedNode;
        }
        #endregion

        #endregion
    }
}
