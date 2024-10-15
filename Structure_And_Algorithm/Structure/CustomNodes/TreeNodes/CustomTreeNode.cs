using Structure_And_Algorithm.Structure.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.CustomNodes.TreeNodes
{
    public class CustomTreeNode<T> : CustomNode<T>
    {
        #region Properties
        /// <summary>
        /// 부모 노드
        /// </summary>
        public CustomTreeNode<T>? ParentNode { get => (CustomTreeNode<T>?)nodeList[0]; set => nodeList[0] = value; }
        /// <summary>
        /// 왼쪽 노드(자식 노드)
        /// </summary>
        public CustomTreeNode<T>? LeftNode { get => (CustomTreeNode<T>?)nodeList[1]; set => nodeList[1] = value; }
        /// <summary>
        /// 오른쪽 노드(형제 노드)
        /// </summary>
        public CustomTreeNode<T>? RightNode { get => (CustomTreeNode<T>?)nodeList[2]; set => nodeList[2] = value; }
        #endregion

        #region Constructors
        public CustomTreeNode(T? data) : base(data)
        {
            nodeList.Add(null);
            nodeList.Add(null);
            nodeList.Add(null);
        }
        #endregion
    }
}
