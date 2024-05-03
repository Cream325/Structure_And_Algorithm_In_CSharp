using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinkedList
{
    public class CircularLinkedList : AbstractLinkedList
    {
        public CircularLinkedList() { }

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
                newNode.PreviousNode = TailNode;
                TailNode = TailNode.NextNode;
            }

            HeadNode.PreviousNode = TailNode;
            TailNode.NextNode = HeadNode;
            Length++;
        }

        public override void Insert(object newData, int index)
        {
            LinkedListNode newNode = new(newData);
            LinkedListNode currentNode = Search(index);

            if (HeadNode == null || index >= Length)
            {
                Append(newData);
                return;
            }
            else
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

            HeadNode.PreviousNode = TailNode;
            TailNode.NextNode = HeadNode;
            Length++;
        }

        public override LinkedListNode? Search(int index)
        {
            LinkedListNode currentNode = (index <= (Length / 2)) ? HeadNode : TailNode;

            if(currentNode == HeadNode)
            {
                while((--index) >= 0)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            else
            {
                while((++index) <= (Length - 1))
                {
                    currentNode = currentNode.PreviousNode;
                }
            }

            return currentNode;
        }

        public override LinkedListNode? Delete(int index)
        {
            index = index <= (Length - 1) ? index : (Length - 1);
            LinkedListNode? deletedNode = null;
            LinkedListNode currentNode = Search(index - 1);

            if(index == 0)
            {
                HeadNode = currentNode.NextNode;
                deletedNode = currentNode;

                if(Length != 1)
                {
                    HeadNode.PreviousNode = TailNode;
                    TailNode.NextNode = HeadNode;
                }
            }
            else
            {
                LinkedListNode tempNode = currentNode.NextNode;

                tempNode.PreviousNode.NextNode = tempNode.NextNode;
                tempNode.NextNode.PreviousNode = tempNode.PreviousNode;
                deletedNode = tempNode;
            }

            Length--;
            return deletedNode;
        }

        public override void Traversal()
        {
            LinkedListNode currentNode = HeadNode;

            do
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.NextNode;
            } while (currentNode != HeadNode);

            Console.WriteLine();
        }
    }
}
