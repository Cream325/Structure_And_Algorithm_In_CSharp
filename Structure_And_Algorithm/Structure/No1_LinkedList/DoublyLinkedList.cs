﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.LinkedList
{
    public class DoublyLinkedList : AbstractLinkedList
    {
        public override void Append(object newData)
        {
            LinkedListNode newNode = new(newData);

            if (HeadNode == null)
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

        public override void AppendAll(object[] newDatas)
        {
            for(int i = 0; i < newDatas.Length; i++)
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
                    newNode.PreviousNode = TailNode;
                    TailNode = TailNode.NextNode;
                }
            }

            Length += newDatas.Length;
        }

        public override void Insert(object newData, int index)
        {
            LinkedListNode newNode = new(newData);
            LinkedListNode currentNode = (LinkedListNode)Search(index);

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

            Length++;
        }

        public override Node? Search(int index)
        {
            LinkedListNode currentNode = (index <= (Length / 2)) ? HeadNode : TailNode;

            if (currentNode == HeadNode)
            {
                while ((--index) >= 0)
                {
                    currentNode = currentNode.NextNode;
                }
            }
            else
            {
                while ((++index) <= (Length - 1))
                {
                    currentNode = currentNode.PreviousNode;
                }
            }

            return currentNode;
        }

        public override Node? Delete(int index)
        {
            index = index <= (Length - 1) ? index : (Length - 1);
            LinkedListNode deletedNode = null;
            LinkedListNode currentNode = (LinkedListNode)Search(index - 1);

            if (index == 0)
            {
                HeadNode = currentNode.NextNode;
                deletedNode = currentNode;
            }
            else
            {
                LinkedListNode tempNode = currentNode.NextNode;
                currentNode.NextNode = tempNode.NextNode;

                if (tempNode.NextNode != null)
                {
                    tempNode.NextNode.PreviousNode = currentNode;
                }

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

            while (currentNode != null)
            {
                Console.Write(currentNode.Data + " ");
                currentNode = currentNode.NextNode;
            }

            Console.WriteLine();
        }
    }
}
