using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 단일 링크드 리스트
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SinglyLinkedList<T> : AbstractLinkedList<T, CustomLinkedListNode<T>>
    {
        #region Constructors
        public SinglyLinkedList() : base() { }
        public SinglyLinkedList(T? data) : base(data) { }
        #endregion

        #region Overrides

        #region Append
        public override void Append(T newData)
        {
            CustomLinkedListNode<T> newNode = new(newData);

            // Head가 null인 경우
            if(headNode == null)
            {
                headNode = newNode;
                tailNode = headNode;
                length++;
                return;
            }

            // Head가 Tail과 같은 경우
            if (headNode.Equals(tailNode))
                headNode.NextNode = newNode;
            else
                // 일반적인 경우
                tailNode.NextNode = newNode;

            tailNode = newNode;
            length++;
        }
        #endregion

        #region Insert
        public override bool Insert(T newData, int index)
        {
            // Head가 null인 경우, 인덱스가 length-1이상인 경우
            if(headNode == null || index >= length-1)
            {
                Append(newData);
                return false;
            }

            CustomLinkedListNode<T> newNode = new(newData);

            //인덱스가 0이하인 경우
            if (index <= 0)
            {
                newNode.NextNode = headNode;
                headNode = newNode;
            }
            else
            {
                // 일반적인 경우
                CustomLinkedListNode<T> currentNode = _Search(index - 1);
                CustomLinkedListNode<T> tempNode = currentNode.NextNode;
                currentNode.NextNode = newNode;
                newNode.NextNode = tempNode;
            }

            length++;

            return false;
        }
        #endregion

        #region Search
        public override T? Search(int i) {
            var _ = _Search(i);
            return _ == null ? default : _.Data;
        }
        private CustomLinkedListNode<T>? _Search(int index)
        {
            CustomLinkedListNode<T>? currentNode = headNode;

            if (currentNode != null)
            {
                while (currentNode.NextNode != null && --index >= 0)
                {
                    currentNode = currentNode.NextNode;
                }
            }

            return currentNode;
        }
        #endregion

        #region Delete

        public override T? Delete(int i) {
            var _ = _Delete(i);
            return _ == null ? default : _.Data;
        }
        private CustomLinkedListNode<T>? _Delete(int index)
        {
            // Head가 null인 경우
            if (headNode == null)
                return null;

            CustomLinkedListNode<T> deletedNode;
            CustomLinkedListNode<T> tempNode;

            // Head가 Tail과 같은 경우
            if(headNode.Equals(tailNode))
            {
                tempNode = headNode;
                headNode = null;
                tailNode = null;
            }
            else
            {
                // 인덱스가 0이하일 경우
                if(index <= 0)
                {
                    tempNode = headNode;
                    headNode = headNode.NextNode;
                }
                else
                {
                    // 인덱스가 length-1이상일 경우, 일반적인 경우
                    index = index >= length - 1 ? length - 1 : index;
                    CustomLinkedListNode<T> currentNode = _Search(index - 1);
                    tempNode = currentNode.NextNode;
                    currentNode.NextNode = tempNode.NextNode;
                    tailNode = currentNode;
                }
            }

            deletedNode = tempNode;
            length--;

            return deletedNode;
        }
        #endregion

        #endregion
    }
}