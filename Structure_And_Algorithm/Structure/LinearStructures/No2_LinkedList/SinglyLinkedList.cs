using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;
using Structure_And_Algorithm.Structure.Utils;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 단일 연결 리스트
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SinglyLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public SinglyLinkedList() : base() { }
        public SinglyLinkedList(T newData) : base(newData) { }
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
                    //인덱스가 0인 경우
                    newNode.NextNode = headNode;
                    headNode = newNode;
                }
                else if (index == length - 1)
                {
                    // 인덱스가 length-1인 경우
                    if (headNode.Equals(tailNode))
                        headNode.NextNode = newNode;
                    else
                        tailNode.NextNode = newNode;

                    tailNode = newNode;
                }
                else
                {
                    // 일반적인 경우
                    CustomLinkedListNode<T> currentNode = SearchNode(index - 1);
                    CustomLinkedListNode<T> tempNode = currentNode.NextNode;
                    currentNode.NextNode = newNode;
                    newNode.NextNode = tempNode;
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

            while (currentNode.NextNode != null && --index >= 0)
            {
                currentNode = currentNode.NextNode;
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
                // Head와 Tail이 같은 경우
                tempNode = headNode;
                headNode = null;
                tailNode = null;
            }
            else if (index == 0)
            {
                // 인덱스가 0일 경우
                tempNode = headNode;
                headNode = headNode.NextNode;
            }
            else
            {
                // 인덱스가 length-1일 경우, 일반적인 경우
                CustomLinkedListNode<T> currentNode = SearchNode(index - 1);
                tempNode = currentNode.NextNode;
                currentNode.NextNode = tempNode.NextNode;
                tailNode = currentNode;
            }

            deletedNode = tempNode;
            length--;

            return deletedNode;
        }
        #endregion

        #endregion
    }
}