using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class CustomLinkedListNode<T> : AbstractNode<T>
    {
        #region Properties
        /// <summary>
        /// 이전 노드
        /// </summary>
        public CustomLinkedListNode<T>? PreviousNode { get => (CustomLinkedListNode<T>?)nodeList[0]; set => nodeList[0] = value; }

        /// <summary>
        /// 다음 노드
        /// </summary>
        public CustomLinkedListNode<T>? NextNode { get => (CustomLinkedListNode<T>?)nodeList[1]; set => nodeList[1] = value; }
        #endregion

        #region Constructors
        public CustomLinkedListNode(T? data) : base(data)
        {
            nodeList.Add(null);
            nodeList.Add(null);
        }

        public CustomLinkedListNode() : base(default) {}
        #endregion
    }
}
