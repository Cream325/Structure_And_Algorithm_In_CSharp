using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 이중 연결 리스트
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public DoublyLinkedList() : base() { }
        public DoublyLinkedList(T newData) : base(newData) { }
        #endregion

        #region Overrides

        #region Insert
        public override void Insert(T newData, int index)
        {
            CustomLinkedListNode<T> newNode = new(newData);

            if (headNode == null)
            {
                // Head가 null인 경우
                headNode = newNode;
                tailNode = headNode;
            }
            else
            {
                CheckIndex(index);

                if (index == 0 && length > 1)
                {
                    // 인덱스가 0인 경우
                    newNode.NextNode = headNode;
                    headNode.PreviousNode = newNode;
                    headNode = newNode;
                }
                else if (index == length - 1)
                {
                    // 인덱스가 length-1인 경우
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
                    CustomLinkedListNode<T>? currentNode = SearchNode(index);
                    currentNode.PreviousNode.NextNode = newNode;
                    newNode.PreviousNode = currentNode.PreviousNode;
                    newNode.NextNode = currentNode;
                    currentNode.PreviousNode = newNode;
                }
            }

            length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T>? SearchNode(int index)
        {
            CheckIsHeaderNull(headNode);
            CheckIndex(index);

            CustomLinkedListNode<T> currentNode = headNode;

            if (index <= length / 2)
            {
                while (currentNode.NextNode != null && --index >= 0)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            else
            {
                int maxIndex = length - 1;
                currentNode = tailNode;
                while (currentNode.PreviousNode != null && --maxIndex >= index)
                {
                    currentNode = currentNode.PreviousNode;
                }
            }

            return currentNode;
        }
        #endregion

        #region Delete
        public override CustomLinkedListNode<T>? DeleteNode(int index)
        {
            CheckIsHeaderNull(headNode);
            CheckIndex(index);

            CustomLinkedListNode<T> deletedNode;
            CustomLinkedListNode<T> tempNode;

            if(headNode.Equals(tailNode))
            {
                // Head와 Tail이 같을 경우
                tempNode = headNode;
                headNode = null;
                tailNode = null;
            }
            else if (index == 0)
            {
                // 인덱스가 0일 경우
                tempNode = headNode;
                headNode.NextNode.PreviousNode = null;
                headNode = headNode.NextNode;
            }
            else
            {
                // 인덱스가 length-1일 경우, 일반적인 경우
                CustomLinkedListNode<T> currentNode = SearchNode(index);
                tempNode = currentNode;
                currentNode.PreviousNode.NextNode = currentNode.NextNode;

                if (index == length - 1)
                    tailNode = currentNode.PreviousNode;
                else
                    currentNode.NextNode.PreviousNode = currentNode.PreviousNode;
            }

            deletedNode = tempNode;
            length--;

            return deletedNode;
        }
        #endregion

        #endregion
    }
}
