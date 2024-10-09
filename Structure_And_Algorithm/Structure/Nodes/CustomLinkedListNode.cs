using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class CustomLinkedListNode<T> : CustomNode<T>
    {
        #region Properties
        public CustomLinkedListNode<T>? PreviousNode { get => (CustomLinkedListNode<T>?)nodeList[0]; set => nodeList[0] = value; }
        public CustomLinkedListNode<T>? NextNode { get => (CustomLinkedListNode<T>?)nodeList[1]; set => nodeList[1] = value; }
        #endregion

        #region Constructors
        public CustomLinkedListNode(T? data) : base(data)
        {
            nodeList.Add(null);
            nodeList.Add(null);
        }
        #endregion
    }
}
