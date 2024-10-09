using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    public class DoublyLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public DoublyLinkedList() : base() { }
        public DoublyLinkedList(T? data) : base(data) { }
        #endregion

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
                newNode.PreviousNode = TailNode;
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
                    newNode.PreviousNode = TailNode;
                    TailNode = TailNode.NextNode;
                }
            }

            Length += newDatas.Length;
        }

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
                CustomLinkedListNode<T>? currentNode = Search(index);

                if (currentNode != null)
                {
                    newNode.NextNode = currentNode;

                    if (index == 0)
                    {
                        currentNode.PreviousNode = newNode;
                        HeadNode = newNode;
                    }
                    else
                    {
                        currentNode.PreviousNode.NextNode = newNode;
                        newNode.PreviousNode = currentNode.PreviousNode;
                        currentNode.PreviousNode = newNode;
                    }
                }
            }

            Length++;
        }

        public override CustomLinkedListNode<T>? Search(int index)
        {
            CustomLinkedListNode<T>? currentNode = index <= Length / 2 ? HeadNode : TailNode;

            if (currentNode != null)
            {
                if (currentNode == HeadNode)
                {
                    while (--index >= 0)
                    {
                        currentNode = currentNode.NextNode;
                    }
                }
                else
                {
                    while (++index <= Length - 1)
                    {
                        currentNode = currentNode.PreviousNode;
                    }
                }
            }

            return currentNode;
        }

        public override CustomLinkedListNode<T>? Delete(int index)
        {
            index = index <= Length - 1 ? index : Length - 1;
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

                if (tempNode.NextNode != null)
                {
                    tempNode.NextNode.PreviousNode = currentNode;
                }

                if (index >= Length - 1)
                {
                    TailNode = currentNode;
                }

                deletedNode = tempNode;
            }

            Length--;
            return deletedNode;
        }

        public override void Traversal()
        {
            CustomLinkedListNode<T>? currentNode = HeadNode;

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
    }
}
