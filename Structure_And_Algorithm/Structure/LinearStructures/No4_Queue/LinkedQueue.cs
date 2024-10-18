using Structure_And_Algorithm.Structure.Linear.LinkedList;
using Structure_And_Algorithm.Structure.Nodes;

namespace Structure_And_Algorithm.Structure.Linear.Queue
{
    /// <summary>
    /// 링크드 리스트 기반 큐
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LinkedQueue<T> : AbstractQueue<T>
    {
        #region Member Fields
        DoublyLinkedList<T> linkedList;
        #endregion

        #region Properties
        public int Length { get => linkedList.Length; }
        #endregion

        #region Constructors
        public LinkedQueue() : base()
        {
            linkedList = new();
        }

        public LinkedQueue(T? data) : base()
        {
            linkedList = new();
            Enqueue(data);
        }
        #endregion

        #region Overrides
        public override void Enqueue(T? newData)
        {
            linkedList.Append(newData);
            rear++;
        }

        public override CustomLinkedListNode<T>? Peek()
        {
            CustomLinkedListNode<T>? dequeuedNode = linkedList.Search(0);
            return dequeuedNode != null ?dequeuedNode : null;
        }

        public override CustomLinkedListNode<T>? Dequeue()
        {
            CustomLinkedListNode<T>? dequeuedNode = linkedList.Delete(0);
            if(dequeuedNode != null)
            {
                front++;
                return dequeuedNode;
            }
            
            return null;
        }
        #endregion
    }
}
