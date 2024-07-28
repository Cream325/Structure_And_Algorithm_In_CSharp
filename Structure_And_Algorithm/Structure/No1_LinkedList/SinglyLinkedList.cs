using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.LinkedList
{
    public class SinglyLinkedList : AbstractLinkedList
    {
        #region Append
        public override void Append(object newData)
        {
            LinkedListNode newNode = new(newData);

            if(HeadNode == null)
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

        public override void AppendAll(object[] newDatas)
        {
            for(int i = 0; i <  newDatas.Length; i++)
            {
                LinkedListNode newNode = new(newDatas[i]);

                if (HeadNode == null)
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
        public override void Insert(object newData, int index)
        {
            if(HeadNode == null || index >= Length)
            {
                Append(newData);
            }
            else
            {
                LinkedListNode newNode = new(newData);
                if (index == 0)
                {
                    newNode.NextNode = HeadNode;
                    HeadNode = newNode;
                }
                else
                {
                    LinkedListNode currentNode = (LinkedListNode)Search(index - 1);

                    newNode.NextNode = currentNode.NextNode;
                    currentNode.NextNode = newNode;
                }
            }

            Length++;
        }
        #endregion

        #region Search
        public override Node? Search(int index)
        {
            LinkedListNode? currentNode = HeadNode;

            while((currentNode.NextNode != null) && (--index) >= 0)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode;
        }
        #endregion

        #region Delete
        public override Node? Delete(int index)
        {
            index = index <= (Length - 1) ? index : (Length - 1);
            LinkedListNode? deletedNode = null;
            LinkedListNode currentNode = (LinkedListNode)Search(index - 1);

            if(index == 0)
            {
                HeadNode = currentNode.NextNode;
                deletedNode = currentNode;
            }
            else
            {
                LinkedListNode tempNode = currentNode.NextNode;
                currentNode.NextNode = tempNode.NextNode;

                if (index >= (Length - 1))
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
            LinkedListNode currentNode = HeadNode;

            while(currentNode != null)
            {
                Console.Write($"{currentNode.Data} ");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
        #endregion
    }
}
