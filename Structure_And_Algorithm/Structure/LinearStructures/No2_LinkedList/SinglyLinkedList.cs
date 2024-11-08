using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

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
            else if (index <= 0)
            {
                //인덱스가 0이하인 경우
                newNode.NextNode = headNode;
                headNode = newNode;
            }
            else if (index >= length - 1)
            {
                // 인덱스가 length-1이상인 경우
                if(headNode.Equals(tailNode))
                    headNode.NextNode = newNode;
                else
                    tailNode.NextNode = newNode;

                tailNode = newNode;
            }
            else
            {
                // 일반적인 경우
                CustomLinkedListNode<T> currentNode = Search(index - 1);
                CustomLinkedListNode<T> tempNode = currentNode.NextNode;
                currentNode.NextNode = newNode;
                newNode.NextNode = tempNode;
            }

            length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T> Search(int index)
        {
            if(headNode == null) return null;

            CustomLinkedListNode<T> currentNode = headNode;

            while (currentNode.NextNode != null && --index >= 0)
            {
                currentNode = currentNode.NextNode;
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
                // Head와 Tail이 같은 경우
                tempNode = headNode;
                headNode = null;
                tailNode = null;
            }
            else if (index <= 0)
            {
                // 인덱스가 0이하일 경우
                tempNode = headNode;
                headNode = headNode.NextNode;
            }
            else
            {
                // 인덱스가 length-1이상일 경우, 일반적인 경우
                index = index >= length - 1 ? length - 1 : index;
                CustomLinkedListNode<T> currentNode = Search(index - 1);
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