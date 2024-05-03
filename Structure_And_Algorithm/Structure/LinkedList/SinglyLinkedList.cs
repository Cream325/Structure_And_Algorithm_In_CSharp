using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.LinkedList
{
    public class SinglyLinkedList : AbstractLinkedList
    {
        public SinglyLinkedList() { }

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

        public override void Insert(object newData, int index)
        {
            LinkedListNode newNode = new(newData);
            LinkedListNode currentNode = Search(index - 1);

            if(HeadNode == null || index >= Length)
            {
                Append(newData);
                return;
            }

            if(index == 0)
            {
                newNode.NextNode = currentNode;
                HeadNode = newNode;
            }
            else
            {
                newNode.NextNode = currentNode.NextNode;
                currentNode.NextNode = newNode;
            }

            Length++;
        }

        public override LinkedListNode? Search(int index)
        {
            LinkedListNode? currentNode = HeadNode;

            while((currentNode != null) && (--index) >= 0)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode;
        }

        public override LinkedListNode? Delete(int index)
        {
            LinkedListNode? deletedNode = null;
            LinkedListNode currentNode = Search(index - 1);

            if(index == 0)
            {
                HeadNode = currentNode.NextNode;
                deletedNode = currentNode;
            }
            else
            {
                LinkedListNode tempNode = currentNode.NextNode;
                currentNode.NextNode = tempNode.NextNode;
                deletedNode = tempNode;
            }

            Length--;
            return deletedNode;
        }

        public override void Traversal()
        {
            LinkedListNode currentNode = HeadNode;

            while(currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.NextNode;
            }
        }
    }
}
