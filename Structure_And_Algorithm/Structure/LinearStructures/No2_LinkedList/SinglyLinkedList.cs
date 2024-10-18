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
    public class SinglyLinkedList<T> : AbstractLinkedList<T>
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

            // 헤드가 null인 경우
            if(headNode == null)
            {
                headNode = newNode;
                tailNode = headNode;
            }
            else
            {
                // 헤드 다음노드가 null인 경우, 일반적인 경우
                if (headNode.NextNode == null)
                    headNode.NextNode = newNode;
                else
                    tailNode.NextNode = newNode;

                tailNode = tailNode.NextNode;
            }

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

            // 헤드가 null인 경우, 인덱스가 0 이하인 경우
            if(headNode == null || index <= 0)
            {
                newNode.NextNode = headNode;
                headNode = newNode;
                length++;
                return;
            }

            // 인덱스가 리스트 최대 인덱스 이상인 경우 (Append와 연산이 같음)
            if(index >= length-1)
            {
                tailNode.NextNode = newNode;
                tailNode = tailNode.NextNode;
                length++;
                return;
            }

            //일반적인 경우
            CustomLinkedListNode<T>? currentNode = Search(index - 1);
            CustomLinkedListNode<T>? tempNode = currentNode.NextNode;
            currentNode.NextNode = newNode;
            newNode.NextNode = tempNode;
            length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T>? Search(int index)
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
        public override CustomLinkedListNode<T>? Delete(int index)
        {
            CustomLinkedListNode<T>? deletedNode = null;

            if (headNode != null)
            {
                // 헤드를 삭제할 경우
                if(headNode.NextNode == null || index <= 0)
                {
                    deletedNode = headNode;
                    headNode = headNode.NextNode;
                }
                else
                {
                    // 중간노드, 테일을 삭제할 경우
                    index = index >= length ? length-1 : index;
                    CustomLinkedListNode<T>? currentNode = Search(index - 1);
                    CustomLinkedListNode<T>? tempNode = currentNode.NextNode;
                    deletedNode = tempNode;
                    currentNode.NextNode = tempNode.NextNode;
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

            while (currentNode != null)
            {
                Console.Write($"{currentNode.Data} ");
                currentNode = currentNode.NextNode;
            }
        }
        #endregion

        #endregion
    }
}