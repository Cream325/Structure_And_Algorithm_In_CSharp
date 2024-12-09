using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.CustomNodes.TreeNodes
{
    public class CustomTreeNode<T> : AbstractNode<T>
    {
        #region Properties
        /// <summary>
        /// 부모 노드
        /// </summary>
        public CustomTreeNode<T>? ParentNode { get => (CustomTreeNode<T>?)nodes[0]; set => nodes[0] = value; }
        /// <summary>
        /// 왼쪽 노드(자식 노드)
        /// </summary>
        public CustomTreeNode<T>? LeftNode { get => (CustomTreeNode<T>?)nodes[1]; set => nodes[1] = value; }
        /// <summary>
        /// 오른쪽 노드(형제 노드)
        /// </summary>
        public CustomTreeNode<T>? RightNode { get => (CustomTreeNode<T>?)nodes[2]; set => nodes[2] = value; }
        #endregion

        #region Constructors
        public CustomTreeNode(T newData) : base(newData)
        {
            nodes = new AbstractNode<T>[3];
        }
        #endregion
    }
}
