using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    public class SinglyLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public SinglyLinkedList() : base() { }
        public SinglyLinkedList(T? data) : base(data) { }
        #endregion

        #region Append
        public override void Append(T newData)
        {
            CustomLinkedListNode<T> newNode = new(newData);

            if (HeadNode == null && TailNode == null)
            {
                HeadNode = newNode;
                TailNode = HeadNode;
            }
            else
            {
                TailNode.NextNode = newNode;
                TailNode = TailNode.NextNode;
            }

            Length++;
        }

        public override void AppendAll(T[] newDatas)
        {
            for (int i = 0; i < newDatas.Length; i++)
            {
                CustomLinkedListNode<T> newNode = new(newDatas[i]);

                if (HeadNode == null && TailNode == null)
                {
                    HeadNode = newNode;
                    TailNode = HeadNode;
                }
                else
                {
                    TailNode.NextNode = newNode;
                    TailNode = TailNode.NextNode;
                }
            }

            Length += newDatas.Length;
        }
        #endregion

        #region Insert
        public override void Insert(T newData, int index)
        {
            if (HeadNode == null || Length <= index)
            {
                Append(newData);
                return;
            }
            else
            {
                CustomLinkedListNode<T> newNode = new(newData);

                if (index == 0)
                {
                    newNode.NextNode = HeadNode;
                    HeadNode = newNode;
                }
                else
                {
                    CustomLinkedListNode<T>? currentNode = Search(index - 1);

                    if (currentNode != null)
                    {
                        newNode.NextNode = currentNode.NextNode;
                        currentNode.NextNode = newNode;
                    }
                }
            }

            Length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T>? Search(int index)
        {
            CustomLinkedListNode<T>? currentNode = HeadNode;
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
            index = Length - 1 >= index ? index : Length - 1;
            CustomLinkedListNode<T>? deletedNode = null;
            CustomLinkedListNode<T>? currentNode = Search(index - 1);

            if (index == 0)
            {
                HeadNode = currentNode.NextNode;
                deletedNode = currentNode;
            }
            else
            {
                CustomLinkedListNode<T>? tempNode = currentNode.NextNode;
                currentNode.NextNode = tempNode.NextNode;

                if (index >= Length - 1)
                {
                    TailNode = currentNode;
                }

                deletedNode = tempNode;
            }

            Length--;
            return deletedNode;
        }
        #endregion

        #region Print
        public override void Traversal()
        {
            CustomLinkedListNode<T>? currentNode = HeadNode;

            while (currentNode != null)
            {
                Console.Write($"{currentNode.Data} ");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
        #endregion
    }
}