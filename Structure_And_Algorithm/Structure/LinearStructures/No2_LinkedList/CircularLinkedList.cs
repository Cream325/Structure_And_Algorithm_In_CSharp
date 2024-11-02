﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.LinkedList
{
    /// <summary>
    /// 순환 링크드 리스트
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class CircularLinkedList<T> : AbstractLinkedList<T>
    {
        #region Constructors
        public CircularLinkedList() : base() { }
        public CircularLinkedList(T? data) : base(data) { }
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

                headNode.NextNode = tailNode;
                tailNode.PreviousNode = headNode;

                headNode.PreviousNode = tailNode;
                tailNode.NextNode = headNode;
                length++;
                return;
            }

            // Head가 Tail과 같은 경우
            if (headNode.Equals(tailNode))
            {
                headNode.NextNode = newNode;
                newNode.PreviousNode = headNode;    
            }
            else
            {
                // 일반적인 경우
                tailNode.NextNode = newNode;
                newNode.PreviousNode = tailNode;
            }

            tailNode = newNode;
            headNode.PreviousNode = tailNode;
            tailNode.NextNode = headNode;
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
            // 헤드가 null인 경우, 인덱스가 length-1이상인 경우
            if(headNode == null || index >= length - 1)
            {
                Append(newData);
                return;
            }

            CustomLinkedListNode<T> newNode = new(newData);

            // 인덱스가 0이하인 경우
            if (index <= 0)
            {
                newNode.NextNode = headNode;
                headNode.PreviousNode = newNode;
                headNode = newNode;

                headNode.PreviousNode = tailNode;
                tailNode.NextNode = headNode;
            }
            else
            {
                // 일반적인 경우
                CustomLinkedListNode<T>? currentNode = Search(index);
                currentNode.PreviousNode.NextNode = newNode;
                newNode.PreviousNode = currentNode.PreviousNode;
                newNode.NextNode = currentNode;
                currentNode.PreviousNode = newNode;
            }

            length++;
        }
        #endregion

        #region Search
        public override CustomLinkedListNode<T>? Search(int index)
        {
            CustomLinkedListNode<T>? currentNode = headNode;

            if(currentNode != null)
            {
                if (index <= length / 2)
                {
                    while (currentNode.NextNode != headNode && --index >= 0)
                    {
                        currentNode = currentNode.NextNode;
                    }
                }
                else
                {
                    int maxIndex = length - 1;
                    currentNode = tailNode;
                    while (currentNode.PreviousNode != tailNode && --maxIndex >= index)
                    {
                        currentNode = currentNode.PreviousNode;
                    }
                }
            }

            return currentNode;
        }
        #endregion
        
        #region Delete
        public override CustomLinkedListNode<T>? Delete(int index)
        {
            // Head가 null인 경우
            if (headNode == null)
                return null;

            CustomLinkedListNode<T> deletedNode;
            CustomLinkedListNode<T> tempNode;

            // Head가 Tail과 같을 경우
            if(headNode.Equals(tailNode))
            {
                tempNode = headNode;
                headNode = null;
                tailNode = null;
            }
            else
            {
                // 인덱스가 0이하일 경우
                if (index <= 0)
                {
                    tempNode = headNode;
                    headNode.NextNode.PreviousNode = null;
                    headNode = headNode.NextNode;

                    headNode.PreviousNode = tailNode;
                    tailNode.NextNode = headNode;
                }
                else
                {
                    CustomLinkedListNode<T> currentNode = Search(index);
                    tempNode = currentNode;
                    currentNode.PreviousNode.NextNode = currentNode.NextNode;

                    // 인덱스가 length-1이상일 경우
                    if (index >= length - 1)
                    {
                        tailNode = currentNode.PreviousNode;

                        headNode.PreviousNode = tailNode;
                        tailNode.NextNode = headNode;
                    }
                    else
                        // 일반적인 경우
                        currentNode.NextNode.PreviousNode = currentNode.PreviousNode;
                }
            }

            deletedNode = tempNode;
            length--;

            return deletedNode;
        }
        #endregion

        #region Print
        public override void Traversal()
        {
            CustomLinkedListNode<T>? currentNode = headNode;

            if (currentNode != null)
            {
                do
                {
                    Console.Write(currentNode.Data + " ");
                    currentNode = currentNode.NextNode;
                } while(currentNode != headNode);
            }
        }
        #endregion

        #endregion
    }
}
