﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.LinkedList
{
    public class SinglyLinkedList : AbstractLinkedList
    {
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
            LinkedListNode currentNode = (LinkedListNode)Search(index - 1);

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

        public override Node? Search(int index)
        {
            LinkedListNode? currentNode = HeadNode;

            while((currentNode.NextNode != null) && (--index) >= 0)
            {
                currentNode = currentNode.NextNode;
            }

            return currentNode;
        }

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

        public override void Traversal()
        {
            LinkedListNode currentNode = HeadNode;

            while(currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
    }
}
