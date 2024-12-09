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
        public CustomLinkedListNode<T>? PreviousNode { get => (CustomLinkedListNode<T>?)nodes[0]; set => nodes[0] = value; }

        /// <summary>
        /// 다음 노드
        /// </summary>
        public CustomLinkedListNode<T>? NextNode { get => (CustomLinkedListNode<T>?)nodes[1]; set => nodes[1] = value; }
        #endregion

        #region Constructors
        public CustomLinkedListNode(T newData) : base(newData)
        {
            nodes = new AbstractNode<T>[2];
        }
        #endregion
    }
}
