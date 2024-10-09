using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class CustomTreeNode<T> : CustomNode<T>
    {
        #region Properties
        public CustomTreeNode<T>? ParentNode { get => (CustomTreeNode<T>?)nodeList[0]; set => nodeList[0] = value; }
        public CustomTreeNode<T>? LeftNode { get => (CustomTreeNode<T>?)nodeList[1]; set => nodeList[1] = value; }
        public CustomTreeNode<T>? RightNode { get => (CustomTreeNode<T>?)nodeList[2]; set => nodeList[2] = value; }
        #endregion

        public CustomTreeNode(T? data) : base(data)
        {
            nodeList.Add(null);
            nodeList.Add(null);
            nodeList.Add(null);
        }
    }
}
